using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using RE_JavaTexturePackage2NBTP.ConvertAPI;

namespace RE_JavaTexturePackage2NBTP.SDK
{
    internal class PackageConverter
    {
        public int sucCount = 0;
        public int failCount = 0;
        public string BEPath = "";
        public RenameAPI rAPI = new();
        public DestroyStageConvertAPI destAPI = new();
        public PngToTgaAPI p2taAPI = new();
        public iconsAPI iconAPI = new();
        public widgetsAPI widgetAPI = new();

        public JavaPackage currentPackage;


        public string DataPath => BEPath + "/data/resource_packs/";
        public string VanillaPath => DataPath + "/vanilla/";
        public string VanillaBasePath => DataPath + "/vanilla_base/";

        public string TextureBase => VanillaPath + "/textures/";
        public string SoundBase => VanillaPath + "/sounds/";

        public string BlockBase
        {
            get
            {
                if (currentPackage.packInfo.pack.pack_format > 6)
                {
                    return "/block/";
                }
                return "/blocks/";
            }
        }

        public string ItemBase
        {
            get
            {
                if (currentPackage.packInfo.pack.pack_format > 6)
                {
                    return "/item/";
                }
                return "/items/";
            }
        }

        public PackageConverter(string BEPath, JavaPackage pck)
        {
            this.BEPath = BEPath;
            if (!Directory.Exists(DataPath) || !Directory.Exists(VanillaPath))
            {
                throw new Exception($"[ConvertAPI - Error] {BEPath} 不是合法的Netease MinecraftBE文件夹");
            }
            currentPackage = pck;
        }

        public void Convert()
        {
            if (currentPackage.IsTexture)
            {
                foreach (string block in Directory.GetFiles(currentPackage.TextureFolder + BlockBase))
                {
                    string FileName = Path.GetFileName(block);
                    if (FileName.EndsWith(".rep")) continue;
                    try
                    {
                        if (!File.Exists(TextureBase + "/blocks/" + FileName))
                        {
                            FileName = rAPI.Convert(FileName);
                        }
                        File.Copy(block, TextureBase + "/blocks/" + FileName, true);
                        sucCount++;
                        Console.WriteLine($"[ConvertAPI - Info] 成功 {block}");
                    }
                    catch (RenameException ex)
                    {
                        if (FileName.StartsWith("destroy") && !FileName.EndsWith(".rep"))
                        {
                            if (File.Exists(block + ".rep"))
                            {
                                File.Delete(block + ".rep");
                            }
                            destAPI.Convert(block);
                            File.Copy(block + ".rep", TextureBase + "/environment/" + FileName, true);
                            sucCount++;
                            Console.WriteLine($"[ConvertAPI - Info] 成功 {block}");
                        }
                        if (p2taAPI.Contains(FileName))
                        {
                            p2taAPI.Convert(block);
                            File.Copy(block + ".rep", TextureBase + "/blocks/" + FileName.Replace(".png", ".tga"), true);
                            sucCount++;
                            Console.WriteLine($"[ConvertAPI - Info] 成功 {block}");
                        }
                        //Console.WriteLine(ex);
                    }
                    catch (Exception ex)
                    {
                        failCount++;
                        Console.WriteLine(ex);
                    }

                }

                foreach (string item in Directory.GetFiles(currentPackage.TextureFolder + ItemBase))
                {
                    string FileName = Path.GetFileName(item);
                    try
                    {

                        if (!File.Exists(TextureBase + "/items/" + FileName))
                        {
                            FileName = rAPI.Convert(FileName);
                        }
                        File.Copy(item, TextureBase + "/items/" + FileName, true);
                        sucCount++;
                        Console.WriteLine($"[ConvertAPI - Info] 成功 {item}");
                    }
                    catch (RenameException ex)
                    {
                        if (p2taAPI.Contains(FileName))
                        {
                            p2taAPI.Convert(item);
                            File.Copy(item + ".rep", TextureBase + "/items/" + FileName.Replace(".png", ".tga"), true);
                            sucCount++;
                            Console.WriteLine($"[ConvertAPI - Info] 成功 {item}");
                        }
                        //Console.WriteLine(ex);
                    }
                    catch (Exception ex)
                    {
                        failCount++;
                        Console.WriteLine(ex);
                    }

                }

                foreach (string armor in Directory.GetFiles(currentPackage.TextureFolder + "/models/armor/"))
                {
                    string FileName = Path.GetFileName(armor);
                    try
                    {

                        if (!File.Exists(TextureBase + "/models/armor/" + FileName))
                        {
                            FileName = rAPI.Convert(FileName);
                        }
                        File.Copy(armor, TextureBase + "/models/armor/" + FileName, true);
                        sucCount++;
                        Console.WriteLine($"[ConvertAPI - Info] 成功 {armor}");
                    }
                    catch (RenameException ex)
                    {
                        if (p2taAPI.Contains(FileName))
                        {
                            p2taAPI.Convert(armor);
                            File.Copy(armor + ".rep", TextureBase + "/models/armor/" + FileName.Replace(".png", ".tga"), true);
                            sucCount++;
                            Console.WriteLine($"[ConvertAPI - Info] 成功 {armor}");
                        }
                        //Console.WriteLine(ex);
                    }
                    catch (Exception ex)
                    {
                        failCount++;
                        Console.WriteLine(ex);
                    }

                }

                foreach (string armor in Directory.GetFiles(currentPackage.TextureFolder + "/environment/"))
                {
                    string FileName = Path.GetFileName(armor);
                    try
                    {

                        if (!File.Exists(TextureBase + "/environment/" + FileName))
                        {
                            FileName = rAPI.Convert(FileName);
                        }
                        File.Copy(armor, TextureBase + "/environment/" + FileName, true);
                        sucCount++;
                        Console.WriteLine($"[ConvertAPI - Info] 成功 {armor}");
                    }
                    catch (Exception ex)
                    {
                        failCount++;
                        Console.WriteLine(ex);
                    }

                }

                foreach (string armor in Directory.GetFiles(currentPackage.TextureFolder + "/font/"))
                {
                    string FileName = Path.GetFileName(armor);
                    try
                    {

                        if (!File.Exists(VanillaPath + "/font/" + FileName))
                        {
                            FileName = rAPI.Convert(FileName);
                        }
                        File.Copy(armor, VanillaPath + "/font/" + FileName, true);
                        sucCount++;
                        Console.WriteLine($"[ConvertAPI - Info] 成功 {armor}");
                    }
                    catch (Exception ex)
                    {
                        failCount++;
                        Console.WriteLine(ex);
                    }

                }

                foreach (string ui in Directory.GetFiles(currentPackage.TextureFolder + "/gui/"))
                {
                    string FileName = Path.GetFileName(ui);
                    if (FileName == "icons.png")
                    {
                        iconAPI.Convert(ui, TextureBase + "/ui/", VanillaBasePath);
                        Console.WriteLine($"[ConvertAPI - Info] 成功 {ui}");
                        sucCount++;
                    }
                    else if (FileName == "widgets.png")
                    {
                        widgetAPI.Convert(ui, TextureBase + "/ui/");
                        Console.WriteLine($"[ConvertAPI - Info] 成功 {ui}");
                        sucCount++;
                    }
                }

                if (Directory.Exists(currentPackage.TextureFolder + "/gui/title/"))
                {
                    if (Directory.Exists(currentPackage.TextureFolder + "/gui/title/background/"))
                    {
                        foreach (string file in Directory.GetFiles(currentPackage.TextureFolder + "/gui/title/background/"))
                        {
                            string target = TextureBase + "/ui/" + Path.GetFileName(file);
                            if (File.Exists(target))
                            {
                                File.Copy(file, target,true);
                            }
                        }
                    }

                }
            }


            if (currentPackage.IsSound)
            {
                foreach (string dire in Directory.GetDirectories(currentPackage.SoundFolder))
                {
                    string CurrentFolder = SoundBase + "/" + Path.GetFileName(dire);
                    if (!Directory.Exists(CurrentFolder))
                    {
                        continue;
                    }

                    foreach (string file in Directory.GetFiles(dire))
                    {
                        string FileName = Path.GetFileName(file).Replace(".ogg", ".fsb");
                        if (!File.Exists(CurrentFolder + "/" + FileName))
                        {
                            failCount++;
                            Console.WriteLine($"[ConvertAPI - Info] 失败 {file}");
                            continue;
                        }
                        File.Copy(file, CurrentFolder + "/" + FileName, true);
                        sucCount++;
                        Console.WriteLine($"[ConvertAPI - Info] 成功 {file}");
                    }
                }
            }
        }

    }
}
