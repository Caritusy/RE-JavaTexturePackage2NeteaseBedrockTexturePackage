using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RE_JavaTexturePackage2NBTP
{
    internal class ZipHelper
    {
        public static void Extract(string zipFilePath, string extractPath)
        {
            // 如果目标目录不存在，创建目标目录
            if (!Directory.Exists(extractPath))
            {
                Directory.CreateDirectory(extractPath);
                ZipFile.ExtractToDirectory(zipFilePath, extractPath);
            }

            // 解压缩文件
            
        }

        public static bool IsValid(string zipFilePath)
        {
            try
            {
                // 尝试打开 ZIP 文件
                using (ZipArchive archive = ZipFile.OpenRead(zipFilePath))
                {
                    // 如果能够成功打开并读取 ZIP 文件，认为它是一个合法的 ZIP 文件
                    return true;
                }
            }
            catch (InvalidDataException)
            {
                // 如果无法打开 ZIP 文件，抛出异常，认为它不是一个合法的 ZIP 文件
                return false;
            }
        }
    }
}
