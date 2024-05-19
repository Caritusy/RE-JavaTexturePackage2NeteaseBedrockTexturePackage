using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RE_JavaTexturePackage2NBTP.ConvertAPI
{
    internal class widgetsAPI
    {
        public widgetsAPI() { }
        public void Convert(string file, string BEUIFolder)
        {
            using (Bitmap icons = new Bitmap(file))
            {
                int originalSize = 256;
                int iconSize = 9;
                int hotbarWid = 20;
                int hotbarHid = 22;
                int hotbarSelectedSize = 24;
                int crossHairSize = 16;

                float Scale = icons.Width / originalSize;
                hotbarWid = (int)(hotbarWid * Scale);
                hotbarHid = (int)(hotbarHid * Scale);
                hotbarSelectedSize = (int)(hotbarSelectedSize * Scale);
                for (int i = 0; i < 8 + 1; i++)
                {
                    int x = hotbarWid * i;
                    int y = 0;

                    Rectangle smallImageRect = new Rectangle(x, y, hotbarWid, hotbarHid);
                    using (Bitmap smallImage = icons.Clone(smallImageRect, icons.PixelFormat))
                    {
                        string s = $"hotbar_{i}.png";
                        if (File.Exists($"{BEUIFolder}/{s}"))
                        {
                            smallImage.Save($"{BEUIFolder}/{s}", System.Drawing.Imaging.ImageFormat.Png);
                        }
                    }
                }

                for (int i = 0; i < 0 + 1; i++)
                {
                    int x = hotbarWid * i;
                    int y = (int)(Scale * 22);

                    Rectangle smallImageRect = new Rectangle(x, y, hotbarSelectedSize + (int)(1 * Scale), hotbarSelectedSize);
                    using (Bitmap smallImage = icons.Clone(smallImageRect, icons.PixelFormat))
                    {
                        string s = $"selected_hotbar_slot.png";
                        if (File.Exists($"{BEUIFolder}/{s}"))
                        {
                            smallImage.Save($"{BEUIFolder}/{s}", System.Drawing.Imaging.ImageFormat.Png);
                        }
                    }
                }
            }
        }
    }
}
