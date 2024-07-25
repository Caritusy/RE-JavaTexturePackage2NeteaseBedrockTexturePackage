using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RE_JavaTexturePackage2NBTP.SDK
{
    public class JavaPackage
    {
        public class PackInfo //这是用于加载pack.mcmeta信息的类
        {
            public Pack pack { get; set; }
        }

        public class Pack //同上
        {
            public int pack_format { get; set; }
            public string description { get; set; }
        }

        public JavaPackage(string path) //初始化，引入参数路径
        {
            Path = path;
            MD5 = Utils.CalculateMD5(Path); //防重复用计算MD5(虽然好像没啥用)
            TempPath = $"{System.IO.Path.GetTempPath()}/REJTP2BTP-{MD5}/";


        }

        public string Path { get; private set; }
        public string TempPath { get; private set; }
        public string MD5 { get; private set; }
        public PackInfo packInfo { get; private set; }
        
        public bool IsSound { get; private set; }
        public bool IsTexture { get; private set; }

        public string SoundFolder
        {
            get
            {
                return $"{TempPath}/assets/minecraft/sounds/"; //获取音频文件夹
            }
        }

        public string TextureFolder
        {
            get
            {
                return $"{TempPath}/assets/minecraft/textures/"; //获取材质文件夹
            }
        }

        public string STName //获取包类型
        {
            get
            {
                if (!IsSound && IsTexture) return "(材质包)";
                if (IsSound && !IsTexture) return "(音效包)";
                if (IsSound && IsTexture) return "(音效+材质包)";
                if (!IsSound && !IsTexture) return "(未知)";
                return "(未知)";
            }
        }
    
        public string Name //名字
        {
            get
            {
                return STName + System.IO.Path.GetFileName(Path);
            }
        }

        public bool Extract()
        {
            try
            {
                ZipHelper.Extract(Path, TempPath);
                packInfo = JsonConvert.DeserializeObject<PackInfo>(File.ReadAllText($"{TempPath}/pack.mcmeta"));
                IsSound = Directory.Exists(SoundFolder);
                IsTexture = Directory.Exists(TextureFolder);
                Console.WriteLine($"[JavaPackage - Info] 成功解压{Utils.GetFileNameFromPath(Path)}");
                return true;
                
            }
            catch (Exception e)
            {
                Console.WriteLine($"[JavaPackage - Error] 在解压{Utils.GetFileNameFromPath(Path)}的过程中出现错误: {e.Message}, 重试中...");
                return false;
            }
            
        }

    }
}
