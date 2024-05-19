using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RE_JavaTexturePackage2NBTP.ConvertAPI
{
    internal class SkyConvertAPI
    {
        public SkyConvertAPI() { }
        public void Convert(string path)
        {
            using (Bitmap pic = (Bitmap)Bitmap.FromFile(path))
            {
                int smallX = pic.Width / 3;
                int smallY = pic.Height / 2;

                for (int i = 0; i < 3; i++)
                {
                    int x = i * smallX;
                    int y = i * smallY;
                    Rectangle curr = new Rectangle(x, y, smallX, smallY);
                    using (var picnew = pic.Clone(curr, pic.PixelFormat))
                    {
                        picnew.Save(Path.GetDirectoryName(path) + $"/sky_{i}.png.rep");
                    }
                }
            }
        }
    }
}
