using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RE_JavaTexturePackage2NBTP.SDK
{
    internal class Utils
    {
        public static string GetGamePath()
        {
            RegistryKey key = null;
            try
            {
                key = Registry.CurrentUser.OpenSubKey("Software\\Netease\\MCLauncher", false);
            }
            finally
            {
                if (key == null)
                {
                    key = Registry.CurrentUser.OpenSubKey("Software\\Netease\\PC4399_MCLauncher", false);
                }
            }

            if (key == null)
            {
                key.Close();
                return null;
            }

            string path = key.GetValue("MinecraftBENeteasePath")?.ToString();
            key.Close();
            if (string.IsNullOrEmpty(path)) return null;
            else return path + "\\windowsmc";
        }

        public static string CalculateMD5(object obj)
        {
            byte[] bytes;

            // 将对象序列化为字节数组
            using (MemoryStream stream = new MemoryStream())
            {
                XmlSerializer serializer = new XmlSerializer(obj.GetType());
                serializer.Serialize(stream, obj);
                bytes = stream.ToArray();
            }

            // 计算 MD5 值
            using (MD5 md5 = MD5.Create())
            {
                byte[] hashBytes = md5.ComputeHash(bytes);

                // 将字节数组转换为十六进制字符串
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("x2"));
                }

                return sb.ToString();
            }
        }

        public static void ExportTGA(Bitmap bitmap, string filePath)
        {
            using (var stream = File.Open(filePath, FileMode.Create))
            {
                using (var writer = new BinaryWriter(stream))
                {
                    writer.Write((byte)0); // ID length
                    writer.Write((byte)0); // Color map type
                    writer.Write((byte)2); // Image type (uncompressed true-color)
                    writer.Write((short)0); // Color map origin
                    writer.Write((short)0); // Color map length
                    writer.Write((byte)0); // Color map entry size
                    writer.Write((short)0); // X origin
                    writer.Write((short)0); // Y origin
                    writer.Write((short)bitmap.Width); // Image width
                    writer.Write((short)bitmap.Height); // Image height
                    writer.Write((byte)32); // Pixel depth (32 bits per pixel)
                    writer.Write(
                        (byte)8); // Image descriptor (bits 0-3: attribute bits per pixel, bits 4-5: reserved, bit 6: origin in lower left corner, bit 7: alpha bits in pixel)

                    // Write pixel data
                    for (int y = bitmap.Height - 1;
                         y >= 0;
                         y--) // Reverse iteration to match TGA's bottom-to-top row order
                    {
                        for (int x = 0; x < bitmap.Width; x++)
                        {
                            Color pixelColor = bitmap.GetPixel(x, y);
                            writer.Write(pixelColor.B);
                            writer.Write(pixelColor.G);
                            writer.Write(pixelColor.R);
                            writer.Write(pixelColor.A);
                        }
                    }
                }
            }
        }

        public static string GetFileNameFromPath(string path)
        {

            int lastIndex = path.LastIndexOf('\\');
            if (lastIndex == -1)
            {
                lastIndex = path.LastIndexOf('/');
            }

            if (lastIndex == -1)
            {
                return path; // 如果没有路径分隔符，则返回整个字符串作为文件名
            }

            return path.Substring(lastIndex + 1);


        }
    }
}
