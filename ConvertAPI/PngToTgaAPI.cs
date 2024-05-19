using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RE_JavaTexturePackage2NBTP.SDK;

namespace RE_JavaTexturePackage2NBTP.ConvertAPI
{
    internal class PngToTgaAPI
    {
        public PngToTgaAPI()
        {
        }
        public bool Contains(string filename)
        {
            return CONVERTS.TryGetValue(filename, out _);
        }
        public bool Convert(string file)
        {
            try
            {
                Utils.ExportTGA((Bitmap)Image.FromFile(file), file + ".rep");
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine($"[PngToTgaAPI - Error] {e}");
                return false;
            }
        }
        Dictionary<string, string> CONVERTS = new Dictionary<string, string>()
        {
            {"cactus_bottom.png", "cactus_bottom.tga"},
            {"cactus_side.png", "cactus_side.tga"},
            {"cactus_top.png", "cactus_top.tga"},
            {"double_plant_fern_bottom.png", "double_plant_fern_bottom.tga"},
            {"double_plant_fern_top.png", "double_plant_fern_top.tga"},
            {"double_plant_grass_bottom.png", "double_plant_grass_bottom.tga"},
            {"double_plant_grass_top.png", "double_plant_grass_top.tga"},
            {"double_plant_syringa_bottom.png", "double_plant_syringa_bottom.tga"},
            {"double_plant_syringa_top.png", "double_plant_syringa_top.tga"},
            {"fern.png", "fern.tga"},
            {"fern_carried.png", "fern_carried.tga"},
            {"grass_side.png", "grass_side.tga"},
            {"grass_side_snowed.png", "grass_side_snowed.tga"},
            {"grindstone_pivot.png", "grindstone_pivot.tga"},
            {"grindstone_round.png", "grindstone_round.tga"},
            {"grindstone_side.png", "grindstone_side.tga"},
            {"kelp_a.png", "kelp_a.tga"},
            {"kelp_b.png", "kelp_b.tga"},
            {"kelp_c.png", "kelp_c.tga"},
            {"kelp_d.png", "kelp_d.tga"},
            {"kelp_top.png", "kelp_top.tga"},
            {"kelp_top_bulb.png", "kelp_top_bulb.tga"},
            {"leaves_acacia.png", "leaves_acacia.tga"},
            {"leaves_acacia_carried.png", "leaves_acacia_carried.tga"},
            {"leaves_big_oak.png", "leaves_big_oak.tga"},
            {"leaves_big_oak_carried.png", "leaves_big_oak_carried.tga"},
            {"leaves_birch.png", "leaves_birch.tga"},
            {"leaves_birch_carried.png", "leaves_birch_carried.tga"},
            {"leaves_jungle.png", "leaves_jungle.tga"},
            {"leaves_jungle_carried.png", "leaves_jungle_carried.tga"},
            {"leaves_oak.png", "leaves_oak.tga"},
            {"leaves_oak_carried.png", "leaves_oak_carried.tga"},
            {"leaves_spruce.png", "leaves_spruce.tga"},
            {"leaves_spruce_carried.png", "leaves_spruce_carried.tga"},
            {"reeds.png", "reeds.tga"},
            {"scaffolding_bottom.png", "scaffolding_bottom.tga"},
            {"scaffolding_side.png", "scaffolding_side.tga"},
            {"scaffolding_top.png", "scaffolding_top.tga"},
            {"seagrass_doubletall_bottom_a.png", "seagrass_doubletall_bottom_a.tga"},
            {"seagrass_doubletall_bottom_b.png", "seagrass_doubletall_bottom_b.tga"},
            {"seagrass_doubletall_top_a.png", "seagrass_doubletall_top_a.tga"},
            {"seagrass_doubletall_top_b.png", "seagrass_doubletall_top_b.tga"},
            {"stonecutter2_saw.png", "stonecutter2_saw.tga"},
            {"tallgrass.png", "tallgrass.tga"},
            {"tallgrass_carried.png", "tallgrass_carried.tga"},
            {"fireworks_charge.png", "fireworks_charge.tga"},
            {"leather_boots.png", "leather_boots.tga"},
            {"leather_helmet.png", "leather_helmet.tga"},
            {"leather_horse_armor.png", "leather_horse_armor.tga"},
            {"leather_leggings.png", "leather_leggings.tga"},
            {"leather_1.png", "leather_1.tga"},
            {"leather_2.png", "leather_2.tga"}
        };
    }
}
