using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RE_JavaTexturePackage2NBTP
{
    public class JavaPackage
    {
        public class PackInfo
        {
            public Pack pack { get; set; }
        }

        public class Pack
        {
            public int pack_format { get; set; }
            public string description { get; set; }
        }

        public JavaPackage(string path)
        {
            Path = path;
            MD5 = Utils.CalculateMD5(Path);
            TempPath = $"{System.IO.Path.GetTempPath()}/REJTP2BTP-{MD5}/";
            ZipHelper.Extract(Path,TempPath);
            packInfo = JsonConvert.DeserializeObject<PackInfo>(File.ReadAllText($"{TempPath}/pack.mcmeta"));
            IsSound = Directory.Exists(SoundFolder);
            IsTexture = Directory.Exists(TextureFolder);
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
                return $"{TempPath}/assets/minecraft/sounds/";
            }
        }

        public string TextureFolder
        {
            get
            {
                return $"{TempPath}/assets/minecraft/textures/";
            }
        }

        public string STName
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

        public string Name
        {
            get 
            {
                return STName + System.IO.Path.GetFileName(Path);
            }
        }

    }
}
