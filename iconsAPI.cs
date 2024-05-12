using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RE_JavaTexturePackage2NBTP
{
    internal class iconsAPI
    {
        public iconsAPI() { }

        public void Convert(string file,string BEUIFolder,string vanillaBase)
        {
            int originalSize = 256;
            int iconSize = 9;
            int hotbarWid = 20;
            int hotbarHid = 22;
            int hotbarSelectedSize = 24;
            int crossHairSize = 16;
            using (Bitmap icons = new Bitmap(file))
            {
                float Scale = icons.Width / originalSize;
                iconSize = (int)(iconSize * Scale);
                crossHairSize = (int)(crossHairSize * Scale);

                Rectangle crosshairRect = new Rectangle(0, 0, crossHairSize, crossHairSize);
                using (Bitmap smallImage = icons.Clone(crosshairRect, icons.PixelFormat))
                {
                    string s = "cross_hair.png";
                    //for (int y = 0; y < smallImage.Height; y++)
                    //{
                    //    for (int x = 0; x < smallImage.Width; x++)
                    //    {
                    //        Color pixelColor = smallImage.GetPixel(x, y);

                    //        if (pixelColor.A == 0)
                    //        {
                    //            smallImage.SetPixel(x, y, Color.FromArgb(255, 255, 255, 0));
                    //        }
                    //    }
                    //} //这个颜色调整导致了准心不透明
                    if (File.Exists($"{vanillaBase}/textures/ui/{s}"))
                    {
                        smallImage.Save($"{vanillaBase}/textures/ui/{s}", System.Drawing.Imaging.ImageFormat.Png);
                    }
                }
                //Line 1
                for (int i = 0; i < 18 + 1; i++)
                {
                    int x = (int)(16 * Scale) + (iconSize) * i;
                    int y = 0;

                    Rectangle smallImageRect = new Rectangle(x, y, iconSize, iconSize);
                    using (Bitmap smallImage = icons.Clone(smallImageRect, icons.PixelFormat))
                    {
                        string s = $"imgay.png"; // 小贴图的导出路径
                        switch (i)
                        {
                            case 0:
                                s = "heart_background.png";
                                break;
                            case 1:
                                s = "heart_blink.png";
                                break;
                            case 2:
                                s = "heart_nulldata.png";
                                break;
                            case 3:
                                s = "heart_nulldata0.png";
                                break;
                            case 4:
                                s = "heart.png";
                                break;
                            case 5:
                                s = "heart_half.png";
                                break;
                            case 6:
                                s = "heart_flash.png";
                                break;
                            case 7:
                                s = "heart_flash_half.png";
                                break;
                            case 8:
                                s = "poison_heart.png";
                                break;
                            case 9:
                                s = "poison_heart_half.png";
                                break;
                            case 10:
                                s = "poison_heart_flash.png";
                                break;
                            case 11:
                                s = "poison_heart_flash_half.png";
                                break;
                            case 12:
                                s = "wither_heart.png";
                                break;
                            case 13:
                                s = "wither_heart_half.png";
                                break;
                            case 14:
                                s = "wither_heart_flash.png";
                                break;
                            case 15:
                                s = "wither_heart_flash_half.png";
                                break;
                            case 16:
                                s = "absorption_heart.png";
                                break;
                            case 17:
                                s = "absorption_heart_half.png";
                                break;

                        }
                        if (File.Exists($"{BEUIFolder}/{s}"))
                        {
                            smallImage.Save($"{BEUIFolder}/{s}", System.Drawing.Imaging.ImageFormat.Png);
                        }
                    }
                }

                // Line 2
                for (int i = 0; i < 12 + 1; i++)
                {
                    int x = (int)(16 * Scale) + (iconSize) * i;
                    int y = (int)(9 * Scale);

                    Rectangle smallImageRect = new Rectangle(x, y, iconSize, iconSize);
                    using (Bitmap smallImage = icons.Clone(smallImageRect, icons.PixelFormat))
                    {
                        string s = $"imgay.png"; // 小贴图的导出路径
                        switch (i)
                        {
                            case 0:
                                s = "armor_empty.png";
                                break;
                            case 1:
                                s = "armor_half.png";
                                break;
                            case 2:
                                s = "armor_full.png";
                                break;
                            case 3:
                                s = "heart_nulldata0.png";
                                break;
                            case 4:
                                s = "heart_nulldata1.png";
                                break;
                            case 5:
                                s = "heart_nulldata2.png";
                                break;
                            case 6:
                                s = "heart_nulldata3.png";
                                break;
                            case 7:
                                s = "heart_nulldata4.png";
                                break;
                            case 8:
                                s = "horse_heart.png";
                                break;
                            case 9:
                                s = "horse_heart_half.png";
                                break;
                            case 10:
                                s = "horse_heart_flash.png";
                                break;
                            case 11:
                                s = "horse_heart_flash_half.png";
                                break;
                        }
                        if (File.Exists($"{BEUIFolder}/{s}"))
                        {
                            smallImage.Save($"{BEUIFolder}/{s}", System.Drawing.Imaging.ImageFormat.Png);
                        }
                    }
                }

                //Line 3
                for (int i = 0; i < 2 + 1; i++)
                {
                    int x = (int)(16 * Scale) + (iconSize) * i;
                    int y = (int)(18 * Scale);

                    Rectangle smallImageRect = new Rectangle(x, y, iconSize, iconSize);
                    using (Bitmap smallImage = icons.Clone(smallImageRect, icons.PixelFormat))
                    {
                        string s = $"imgay.png"; // 小贴图的导出路径
                        switch (i)
                        {
                            case 0:
                                s = "bubble.png";
                                break;
                            case 1:
                                s = "bubble_pop.png";
                                break;
                        }
                        if (File.Exists($"{BEUIFolder}/{s}"))
                        {
                            smallImage.Save($"{BEUIFolder}/{s}", System.Drawing.Imaging.ImageFormat.Png);
                        }
                    }
                }

                // Line 4
                for (int i = 0; i < 12 + 1; i++)
                {
                    int x = (int)(16 * Scale) + (iconSize) * i;
                    int y = (int)(27 * Scale);

                    Rectangle smallImageRect = new Rectangle(x, y, iconSize, iconSize);
                    using (Bitmap smallImage = icons.Clone(smallImageRect, icons.PixelFormat))
                    {
                        string s = $"imgay.png"; // 小贴图的导出路径
                        switch (i)
                        {
                            case 0:
                                s = "hunger_background.png";
                                break;
                            case 1:
                                s = "hunger_blink.png";
                                break;
                            case 2:
                                s = "hunger_effect_background.png";
                                break;
                            case 3:
                                s = "heart_nulldata0.png";
                                break;
                            case 4:
                                s = "hunger_full.png";
                                break;
                            case 5:
                                s = "hunger_half.png";
                                break;
                            case 6:
                                s = "hunger_flash_full.png";
                                break;
                            case 7:
                                s = "hunger_flash_half.png";
                                break;
                            case 8:
                                s = "hunger_effect_full.png";
                                break;
                            case 9:
                                s = "hunger_effect_half.png";
                                break;
                            case 10:
                                s = "hunger_effect_flash_full.png";
                                break;
                            case 11:
                                s = "hunger_effect_flash_half.png";
                                break;
                        }
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
