using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RE_JavaTexturePackage2NBTP.ConvertAPI
{
    internal class DestroyStageConvertAPI
    {
        public DestroyStageConvertAPI()
        {
        }
        public void Convert(string file)
        {
            using (Bitmap image = (Bitmap)Image.FromFile(file))
            {
                for (int y = 0; y < image.Height; y++)
                {
                    for (int x = 0; x < image.Width; x++)
                    {
                        Color pixelColor = image.GetPixel(x, y);

                        // 如果 alpha 值为 0，则设置像素为白色并将 alpha 通道设置为 1
                        if (pixelColor.A == 0)
                        {
                            image.SetPixel(x, y, Color.FromArgb(255, 255, 255, 255));
                        }
                    }
                }
                image.Save(file + ".rep", ImageFormat.Png);
            }
        }
    }
}
