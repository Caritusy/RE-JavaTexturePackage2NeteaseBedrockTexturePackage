using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RE_JavaTexturePackage2NBTP.ConvertAPI
{

    public class RenameException : Exception
    {

        public RenameException(string? message) : base(message)
        {
        }
    }
    internal class RenameAPI
    {
        public RenameAPI()
        {
        }

        public string Convert(string source)
        {
            string ret = "";
            if (Converter.TryGetValue(source, out ret)) return ret;
            throw new RenameException($"[RenameAPI - Error] 不存在 {source} 作为转换项");
        }

        Dictionary<string, string> Converter = new Dictionary<string, string>()
        {
            {"pack.png", "pack_icon.png"},

            // Base folder
            {"assets/minecraft//", "/"},
            {"assets/minecraft/sounds/", "sounds/"},

            // Folder
            {"/block/", ""},
            {"/item/", ""},

            // Andesite
            {"andesite.png", "stone_andesite.png"},
            {"polished_andesite.png", "stone_andesite_smooth.png"},

            // Anvil
            {"anvil.png", "anvil_base.png"},
            {"anvil_top.png", "anvil_top_damaged_0.png"},
            {"chipped_anvil_top.png", "anvil_top_damaged_1.png"},
            {"damaged_anvil_top.png", "anvil_top_damaged_2.png"},

            // Apple
            {"golden_apple.png", "apple_golden.png"},

            // Armor & tool
            {"armorstand/wood.png", "armor_stand.png"},
            {"elytra.png", "elytra.png"},
            {"golden_axe.png", "gold_axe.png"},
            {"golden_boots.png", "gold_boots.png"},
            {"golden_chestplate.png", "gold_chestplate.png"},
            {"golden_helmet.png", "gold_helmet.png"},
            {"golden_hoe.png", "gold_hoe.png"},
            {"golden_horse_armor.png", "gold_horse_armor.png"},
            {"golden_leggings.png", "gold_leggings.png"},
            {"golden_pickaxe.png", "gold_pickaxe.png"},
            {"golden_shovel.png", "gold_shovel.png"},
            {"golden_sword.png", "gold_sword.png"},
            {"wooden_axe.png", "wood_axe.png"},
            {"wooden_hoe.png", "wood_hoe.png"},
            {"wooden_pickaxe.png", "wood_pickaxe.png"},
            {"wooden_shovel.png", "wood_shovel.png"},
            {"wooden_sword.png", "wood_sword.png"},
            {"chainmail_layer_1.png", "chain_1.png"},
            {"chainmail_layer_2.png", "chain_2.png"},
            {"diamond_layer_1.png", "diamond_1.png"},
            {"diamond_layer_2.png", "diamond_2.png"},
            {"gold_layer_1.png", "gold_1.png"},
            {"gold_layer_2.png", "gold_2.png"},
            {"iron_layer_1.png", "iron_1.png"},
            {"iron_layer_2.png", "iron_2.png"},
            {"leather_layer_1.png", "leather_1.png"},
            {"leather_layer_1_overlay.png", "leather_1_overlay.png"},
            {"leather_layer_2.png", "leather_2.png"},
            {"leather_layer_2_overlay.png", "leather_2_overlay.png"},
            {"netherite_layer_1.png", "netherite_1.png"},
            {"netherite_layer_2.png", "netherite_2.png"},
            {"turtle_layer_1.png", "turtle_1.png"},

            // Arrow
            {"arrow.png", "arrows.png"},

            // Bamboo
            {"bamboo_large_leaves.png", "bamboo_leaf.png"},
            {"bamboo_small_leaves.png", "bamboo_small_leaf.png"},
            {"bamboo_stage0.png", "bamboo_sapling.png"},
            {"bamboo_stalk.png", "bamboo_stem.png"},

            // Barrier
            {"barrier.png", "barrier.png"},

            // Bear
            {"bear/polarbear.png", "polarbear.png"},

            // Bed
            {"bed/light_gray.png", "bed/silver.png"},

            // Bee
            {"beehive_end.png", "beehive_top.png"},

            // Beetroot
            {"beetroots_stage0.png", "beetroots_stage_0.png"},
            {"beetroots_stage1.png", "beetroots_stage_1.png"},
            {"beetroots_stage2.png", "beetroots_stage_2.png"},
            {"beetroots_stage3.png", "beetroots_stage_3.png"},

            // Bell
            {"bell/bell_body.png", "bell/bell.png"},
            {"bell.png", "villagebell.png"},

            // Boat
            {"boat/acacia.png", "boat/boat_acacia.png"},
            {"boat/birch.png", "boat/boat_birch.png"},
            {"boat/dark_oak.png", "boat/boat_darkoak.png"},
            {"boat/jungle.png", "boat/boat_jungle.png"},
            {"boat/oak.png", "boat/boat_oak.png"},
            {"boat/spruce.png", "boat/boat_spruce.png"},
            {"acacia_boat.png", "boat_acacia.png"},
            {"birch_boat.png", "boat_birch.png"},
            {"dark_oak_boat.png", "boat_darkoak.png"},
            {"jungle_boat.png", "boat_jungle.png"},
            {"oak_boat.png", "boat_oak.png"},
            {"spruce_boat.png", "boat_spruce.png"},

            // Bone
            {"bone_meal.png", "dye_powder_white.png"},

            // Book
            {"book.png", "book_normal.png"},
            {"enchanted_book.png", "book_enchanted.png"},
            {"knowledge_book.png", "book_knowledge.png"},
            {"writable_book.png", "book_writable.png"},
            {"written_book.png", "book_written.png"},

            // Bow
            {"bow.png", "bow_standby.png"},

            // Brick
            {"bricks.png", "brick.png"},

            // Bucket
            {"bucket.png", "bucket_empty.png"},
            {"cod_bucket.png", "bucket_cod.png"},
            {"lava_bucket.png", "bucket_lava.png"},
            {"milk_bucket.png", "bucket_milk.png"},
            {"pufferfish_bucket.png", "bucket_pufferfish.png"},
            {"salmon_bucket.png", "bucket_salmon.png"},
            {"tropical_fish_bucket.png", "bucket_tropical.png"},
            {"water_bucket.png", "bucket_water.png"},

            // Campfire
            {"campfire_fire.png", "campfire.png"},
            {"soul_campfire_fire.png", "soul_campfire.png"},

            // Carrot
            {"carrots_stage0.png", "carrots_stage_0.png"},
            {"carrots_stage1.png", "carrots_stage_1.png"},
            {"carrots_stage2.png", "carrots_stage_2.png"},
            {"carrots_stage3.png", "carrots_stage_3.png"},
            {"golden_carrot.png", "carrot_golden.png"},

            // Cat
            {"cat/all_black.png", "cat/allblackcat.png"},
            {"cat/black.png", "cat/tuxedo.png"},
            {"cat/british_shorthair.png", "cat/britishshorthair.png"},
            {"cat/cat_collar.png", "cat/graytabby_tame.png"},
            {"cat/red.png", "cat/redtabby.png"},
            {"cat/siamese.png", "cat/siamesecat.png"},

            // Chest
            {"chest/normal_double.png", "chest/double_normal.png"},

            // Chorus fruit
            {"popped_chorus_fruit.png", "chorus_fruit_popped.png"},

            // Cobblestone
            {"mossy_cobblestone.png", "cobblestone_mossy.png"},

            // Cobweb
            {"cobweb.png", "web.png"},

            // Cocoa
            {"cocoa_stage0.png", "cocoa_stage_0.png"},
            {"cocoa_stage1.png", "cocoa_stage_1.png"},
            {"cocoa_stage2.png", "cocoa_stage_2.png"},
            {"cocoa_beans.png", "dye_powder_brown.png"},

            // Comparator
            {"comparator.png", "comparator_off.png"},

            // Composter
            {"composter_compost.png", "compost.png"},
            {"composter_ready.png", "compost_ready.png"},

            // Concrete
            {"black_concrete.png", "concrete_black.png"},
            {"blue_concrete.png", "concrete_blue.png"},
            {"brown_concrete.png", "concrete_brown.png"},
            {"cyan_concrete.png", "concrete_cyan.png"},
            {"gray_concrete.png", "concrete_gray.png"},
            {"green_concrete.png", "concrete_green.png"},
            {"light_blue_concrete.png", "concrete_light_blue.png"},
            {"light_gray_concrete.png", "concrete_silver.png"},
            {"lime_concrete.png", "concrete_lime.png"},
            {"magenta_concrete.png", "concrete_magenta.png"},
            {"orange_concrete.png", "concrete_orange.png"},
            {"pink_concrete.png", "concrete_pink.png"},
            {"purple_concrete.png", "concrete_purple.png"},
            {"red_concrete.png", "concrete_red.png"},
            {"white_concrete.png", "concrete_white.png"},
            {"yellow_concrete.png", "concrete_yellow.png"},

            // Concrete powder
            {"black_concrete_powder.png", "concrete_powder_black.png"},
            {"blue_concrete_powder.png", "concrete_powder_blue.png"},
            {"brown_concrete_powder.png", "concrete_powder_brown.png"},
            {"cyan_concrete_powder.png", "concrete_powder_cyan.png"},
            {"gray_concrete_powder.png", "concrete_powder_gray.png"},
            {"green_concrete_powder.png", "concrete_powder_green.png"},
            {"light_blue_concrete_powder.png", "concrete_powder_light_blue.png"},
            {"light_gray_concrete_powder.png", "concrete_powder_silver.png"},
            {"lime_concrete_powder.png", "concrete_powder_lime.png"},
            {"magenta_concrete_powder.png", "concrete_powder_magenta.png"},
            {"orange_concrete_powder.png", "concrete_powder_orange.png"},
            {"pink_concrete_powder.png", "concrete_powder_pink.png"},
            {"purple_concrete_powder.png", "concrete_powder_purple.png"},
            {"red_concrete_powder.png", "concrete_powder_red.png"},
            {"white_concrete_powder.png", "concrete_powder_white.png"},
            {"yellow_concrete_powder.png", "concrete_powder_yellow.png"},

            // Conduit
            {"conduit/base.png", "conduit_base.png"},
            {"conduit/cage.png", "conduit_cage.png"},
            {"conduit/closed_eye.png", "conduit_closed.png"},
            {"conduit/open_eye.png", "conduit_open.png"},
            {"conduit/wind.png", "conduit_wind_horizontal.png"},
            {"conduit/wind_vertical.png", "conduit_wind_vertical.png"},
            {"heart_of_the_sea.png", "heartofthesea_closed.png"},

            // Coral
            {"brain_coral.png", "coral_plant_pink.png"},
            {"bubble_coral.png", "coral_plant_purple.png"},
            {"fire_coral.png", "coral_plant_red.png"},
            {"horn_coral.png", "coral_plant_yellow.png"},
            {"tube_coral.png", "coral_plant_blue.png"},
            {"brain_coral_block.png", "coral_pink.png"},
            {"bubble_coral_block.png", "coral_purple.png"},
            {"fire_coral_block.png", "coral_red.png"},
            {"horn_coral_block.png", "coral_yellow.png"},
            {"tube_coral_block.png", "coral_blue.png"},
            {"brain_coral_fan.png", "coral_fan_pink.png"},
            {"bubble_coral_fan.png", "coral_fan_purple.png"},
            {"fire_coral_fan.png", "coral_fan_red.png"},
            {"horn_coral_fan.png", "coral_fan_yellow.png"},
            {"tube_coral_fan.png", "coral_fan_blue.png"},
            {"dead_brain_coral_block.png", "coral_pink_dead.png"},
            {"dead_bubble_coral_block.png", "coral_purple_dead.png"},
            {"dead_fire_coral_block.png", "coral_red_dead.png"},
            {"dead_horn_coral_block.png", "coral_yellow_dead.png"},
            {"dead_tube_coral_block.png", "coral_blue_dead.png"},
            {"dead_brain_coral_fan.png", "coral_fan_pink_dead.png"},
            {"dead_bubble_coral_fan.png", "coral_fan_purple_dead.png"},
            {"dead_fire_coral_fan.png", "coral_fan_red_dead.png"},
            {"dead_horn_coral_fan.png", "coral_fan_yellow_dead.png"},
            {"dead_tube_coral_fan.png", "coral_fan_blue_dead.png"},
            {"dead_brain_coral.png", "coral_plant_pink_dead.png"},
            {"dead_bubble_coral.png", "coral_plant_purple_dead.png"},
            {"dead_fire_coral.png", "coral_plant_red_dead.png"},
            {"dead_horn_coral.png", "coral_plant_yellow_dead.png"},
            {"dead_tube_coral.png", "coral_plant_blue_dead.png"},

            // Cow
            {"cow/red_mooshroom.png", "cow/mooshroom.png"},

            // Crimson
            {"crimson_nylium.png", "crimson_nylium_top.png"},
            {"crimson_planks.png", "huge_fungus/crimson_planks.png"},
            {"crimson_stem.png", "huge_fungus/crimson_log_side.png"},
            {"crimson_stem_top.png", "huge_fungus/crimson_log_top.png"},
            {"stripped_crimson_stem.png", "huge_fungus/stripped_crimson_stem_side.png"},
            {"stripped_crimson_stem_top.png", "huge_fungus/stripped_crimson_stem_top.png"},

            // Dead bush
            {"dead_bush.png", "deadbush.png"},

            // Destroy stage
            {"destroy_stage_0.png", "/environment/destroy_stage_0.png"},
            {"destroy_stage_1.png", "/environment/destroy_stage_1.png"},
            {"destroy_stage_2.png", "/environment/destroy_stage_2.png"},
            {"destroy_stage_3.png", "/environment/destroy_stage_3.png"},
            {"destroy_stage_4.png", "/environment/destroy_stage_4.png"},
            {"destroy_stage_5.png", "/environment/destroy_stage_5.png"},
            {"destroy_stage_6.png", "/environment/destroy_stage_6.png"},
            {"destroy_stage_7.png", "/environment/destroy_stage_7.png"},
            {"destroy_stage_8.png", "/environment/destroy_stage_8.png"},
            {"destroy_stage_9.png", "/environment/destroy_stage_9.png"},

            // Diorite
            {"diorite.png", "stone_diorite.png"},
            {"polished_diorite.png", "stone_diorite_smooth.png"},

            // Dispenser
            {"dispenser_front.png", "dispenser_front_horizontal.png"},

            // Door
            {"acacia_door_bottom.png", "door_acacia_lower.png"},
            {"birch_door_bottom.png", "door_birch_lower.png"},
            {"crimson_door_bottom.png", "huge_fungus/crimson_door_lower.png"},
            {"crimson_door_top.png", "huge_fungus/crimson_door_top.png"},
            {"dark_oak_door_bottom.png", "door_dark_oak_lower.png"},
            {"iron_door_bottom.png", "door_iron_lower.png"},
            {"jungle_door_bottom.png", "door_jungle_lower.png"},
            {"oak_door_bottom.png", "door_wood_lower.png"},
            {"spruce_door_bottom.png", "door_spruce_lower.png"},
            {"acacia_door_top.png", "door_acacia_upper.png"},
            {"birch_door_top.png", "door_birch_upper.png"},
            {"dark_oak_door_top.png", "door_dark_oak_upper.png"},
            {"iron_door_top.png", "door_iron_upper.png"},
            {"jungle_door_top.png", "door_jungle_upper.png"},
            {"oak_door_top.png", "door_wood_upper.png"},
            {"spruce_door_top.png", "door_spruce_upper.png"},
            {"warped_door_bottom.png", "huge_fungus/warped_door_lower.png"},
            {"warped_door_top.png", "huge_fungus/warped_door_top.png"},
            {"acacia_door.png", "door_acacia.png"},
            {"birch_door.png", "door_birch.png"},
            {"dark_oak_door.png", "door_dark_oak.png"},
            {"iron_door.png", "door_iron.png"},
            {"jungle_door.png", "door_jungle.png"},
            {"oak_door.png", "door_wood.png"},
            {"spruce_door.png", "door_spruce.png"},

            // Dragon
            {"enderdragon/", "dragon/"},
            {"dragon/dragon_fireball.png", "dragon_fireball.png"},
            {"dragon_breath.png", "dragons_breath.png"},
            {"fire_charge.png", "fireball.png"},

            // Dropper
            {"dropper_front.png", "dropper_front_horizontal.png"},

            // Dye
            {"cactus_green.png", "dye_powder_green.png"}, // 1.13
            {"dandelion_yellow.png", "dye_powder_yellow.png"}, // 1.13
            {"rose_red.png", "dye_powder_red.png"}, // 1.13
            {"black_dye.png", "dye_powder_black_new.png"},
            {"blue_dye.png", "dye_powder_blue_new.png"},
            {"brown_dye.png", "dye_powder_brown_new.png"},
            {"cyan_dye.png", "dye_powder_cyan.png"},
            {"gray_dye.png", "dye_powder_gray.png"},
            {"green_dye.png", "dye_powder_green.png"},
            {"light_blue_dye.png", "dye_powder_light_blue.png"},
            {"light_gray_dye.png", "dye_powder_silver.png"},
            {"lime_dye.png", "dye_powder_lime.png"},
            {"magenta_dye.png", "dye_powder_magenta.png"},
            {"orange_dye.png", "dye_powder_orange.png"},
            {"pink_dye.png", "dye_powder_pink.png"},
            {"purple_dye.png", "dye_powder_purple.png"},
            {"red_dye.png", "dye_powder_red.png"},
            {"white_dye.png", "dye_powder_white_new.png"},
            {"yellow_dye.png", "dye_powder_yellow.png"},

            // End crystal
            {"end_crystal/", "endercrystal/"},
            {"endercrystal/end_crystal.png", "endercrystal/endercrystal.png"},
            {"endercrystal/end_crystal_beam.png", "endercrystal/endercrystal_beam.png"},

            // End portal
            {"end_portal_frame_eye.png", "endframe_eye.png"},
            {"end_portal_frame_side.png", "endframe_side.png"},
            {"end_portal_frame_top.png", "endframe_top.png"},

            // End stone
            {"end_stone_bricks.png", "end_bricks.png"},

            // Farmland
            {"farmland.png", "farmland_dry.png"},
            {"farmland_moist.png", "farmland_wet.png"},

            // Fern
            {"large_fern_bottom.png", "double_plant_fern_bottom.png"},
            {"large_fern_top.png", "double_plant_fern_top.png"},

            // Firework
            {"firework_rocket.png", "fireworks.png"},
            {"firework_star_overlay.png", "fireworks_charge.png"},

            // Fish
            {"fishing_hook.png", "fishhook.png"},
            {"cod.png", "fish_raw.png"},
            {"cooked_cod.png", "fish_cooked.png"},
            {"cooked_salmon.png", "fish_salmon_cooked.png"},
            {"fishing_rod.png", "fishing_rod_uncast.png"},
            {"pufferfish.png", "fish_pufferfish_raw.png"},
            {"salmon.png", "fish_salmon_raw.png"},
            {"tropical_fish.png", "fish_clownfish_raw.png"},

            // Flesh
            {"beef.png", "beef_raw.png"},
            {"chicken.png", "chicken_raw.png"},
            {"cooked_beef.png", "beef_cooked.png"},
            {"cooked_chicken.png", "chicken_cooked.png"},
            {"cooked_mutton.png", "mutton_cooked.png"},
            {"cooked_porkchop.png", "porkchop_cooked.png"},
            {"mutton.png", "mutton_raw.png"},
            {"porkchop.png", "porkchop_raw.png"},

            // Fletching table
            {"fletching_table_front.png", "fletcher_table_side2.png"},
            {"fletching_table_side.png", "fletcher_table_side1.png"},
            {"fletching_table_top.png", "fletcher_table_top.png"},

            // Flower
            {"allium.png", "flower_allium.png"},
            {"azure_bluet.png", "flower_houstonia.png"},
            {"blue_orchid.png", "flower_blue_orchid.png"},
            {"cornflower.png", "flower_cornflower.png"},
            {"dandelion.png", "flower_dandelion.png"},
            {"lilac_bottom.png", "double_plant_syringa_bottom.png"},
            {"lilac_top.png", "double_plant_syringa_top.png"},
            {"lily_of_the_valley.png", "flower_lily_of_the_valley.png"},
            {"orange_tulip.png", "flower_tulip_orange.png"},
            {"poppy.png", "flower_rose.png"},
            {"oxeye_daisy.png", "flower_oxeye_daisy.png"},
            {"peony_bottom.png", "double_plant_paeonia_bottom.png"},
            {"peony_top.png", "double_plant_paeonia_top.png"},
            {"pink_tulip.png", "flower_tulip_pink.png"},
            {"red_tulip.png", "flower_tulip_red.png"},
            {"rose_bush_bottom.png", "double_plant_rose_bottom.png"},
            {"rose_bush_top.png", "double_plant_rose_top.png"},
            {"sunflower_back.png", "double_plant_sunflower_back.png"},
            {"sunflower_bottom.png", "double_plant_sunflower_bottom.png"},
            {"sunflower_front.png", "double_plant_sunflower_front.png"},
            {"sunflower_top.png", "double_plant_sunflower_top.png"},
            {"white_tulip.png", "flower_tulip_white.png"},
            {"wither_rose.png", "flower_wither_rose.png"},

            // Fox
            {"fox/snow_fox.png", "fox/arctic_fox.png"},
            {"fox/snow_fox_sleep.png", "fox/arctic_fox_sleep.png"},

            // Furnace
            {"blast_furnace_front.png", "blast_furnace_front_off.png"},
            {"furnace_front.png", "furnace_front_off.png"},
            {"smoker_front.png", "smoker_front_off.png"},

            // Glass
            {"black_stained_glass.png", "glass_black.png"},
            {"blue_stained_glass.png", "glass_blue.png"},
            {"brown_stained_glass.png", "glass_brown.png"},
            {"cyan_stained_glass.png", "glass_cyan.png"},
            {"gray_stained_glass.png", "glass_gray.png"},
            {"green_stained_glass.png", "glass_green.png"},
            {"light_blue_stained_glass.png", "glass_light_blue.png"},
            {"light_gray_stained_glass.png", "glass_silver.png"},
            {"lime_stained_glass.png", "glass_lime.png"},
            {"magenta_stained_glass.png", "glass_magenta.png"},
            {"orange_stained_glass.png", "glass_orange.png"},
            {"pink_stained_glass.png", "glass_pink.png"},
            {"purple_stained_glass.png", "glass_purple.png"},
            {"red_stained_glass.png", "glass_red.png"},
            {"white_stained_glass.png", "glass_white.png"},
            {"yellow_stained_glass.png", "glass_yellow.png"},

            // Glass pane
            {"black_stained_glass_pane_top.png", "glass_pane_top_black.png"},
            {"blue_stained_glass_pane_top.png", "glass_pane_top_blue.png"},
            {"brown_stained_glass_pane_top.png", "glass_pane_top_brown.png"},
            {"cyan_stained_glass_pane_top.png", "glass_pane_top_cyan.png"},
            {"gray_stained_glass_pane_top.png", "glass_pane_top_gray.png"},
            {"green_stained_glass_pane_top.png", "glass_pane_top_green.png"},
            {"light_blue_stained_glass_pane_top.png", "glass_pane_top_light_blue.png"},
            {"light_gray_stained_glass_pane_top.png", "glass_pane_top_silver.png"},
            {"lime_stained_glass_pane_top.png", "glass_pane_top_lime.png"},
            {"magenta_stained_glass_pane_top.png", "glass_pane_top_magenta.png"},
            {"orange_stained_glass_pane_top.png", "glass_pane_top_orange.png"},
            {"pink_stained_glass_pane_top.png", "glass_pane_top_pink.png"},
            {"purple_stained_glass_pane_top.png", "glass_pane_top_purple.png"},
            {"red_stained_glass_pane_top.png", "glass_pane_top_red.png"},
            {"white_stained_glass_pane_top.png", "glass_pane_top_white.png"},
            {"yellow_stained_glass_pane_top.png", "glass_pane_top_yellow.png"},

            // Glazed terracotta
            {"black_glazed_terracotta.png", "glazed_terracotta_black.png"},
            {"blue_glazed_terracotta.png", "glazed_terracotta_blue.png"},
            {"brown_glazed_terracotta.png", "glazed_terracotta_brown.png"},
            {"cyan_glazed_terracotta.png", "glazed_terracotta_cyan.png"},
            {"gray_glazed_terracotta.png", "glazed_terracotta_gray.png"},
            {"green_glazed_terracotta.png", "glazed_terracotta_green.png"},
            {"light_blue_glazed_terracotta.png", "glazed_terracotta_light_blue.png"},
            {"light_gray_glazed_terracotta.png", "glazed_terracotta_silver.png"},
            {"lime_glazed_terracotta.png", "glazed_terracotta_lime.png"},
            {"magenta_glazed_terracotta.png", "glazed_terracotta_magenta.png"},
            {"orange_glazed_terracotta.png", "glazed_terracotta_orange.png"},
            {"pink_glazed_terracotta.png", "glazed_terracotta_pink.png"},
            {"purple_glazed_terracotta.png", "glazed_terracotta_purple.png"},
            {"red_glazed_terracotta.png", "glazed_terracotta_red.png"},
            {"white_glazed_terracotta.png", "glazed_terracotta_white.png"},
            {"yellow_glazed_terracotta.png", "glazed_terracotta_yellow.png"},

            // Granite
            {"granite.png", "stone_granite.png"},
            {"polished_granite.png", "stone_granite_smooth.png"},

            // Grass
            {"grass.png", "tallgrass.png"},
            {"grass_block_side.png", "grass_side_carried.png"},
            {"grass_block_side_overlay.png", "grass_side.png"},
            {"grass_block_snow.png", "grass_side_snowed.png"},
            {"grass_block_top.png", "grass_top.png"},
            {"tall_grass_bottom.png", "double_plant_grass_bottom.png"},
            {"tall_grass_top.png", "double_plant_grass_top.png"},

            // Hoglin
            {"hoglin/zoglin.png", "zoglin/zoglin.png"},

            // Honey
            {"honey_block_bottom.png", "honey_bottom.png"},
            {"honey_block_side.png", "honey_side.png"},
            {"honey_block_top.png", "honey_top.png"},
            {"honeycomb_block.png", "honeycomb.png"},

            // Horse
            {"horse/", "horse2/"},

            // Ice
            {"packed_ice.png", "ice_packed.png"},

            // Illager & pillager
            {"illager/evoker_fangs.png", "illager/fangs.png"},
            {"illager/pillager.png", "pillager.png"},
            {"illager/vex.png", "vex/vex.png"},
            {"illager/vex_charging.png", "vex/vex_charging.png"},
            {"illager/vindicator.png", "vindicator.png"},

            // Ink sac
            {"ink_sac.png", "dye_powder_black.png"},

            // Item frame
            {"item_frame.png", "itemframe_background.png"},

            // Iron golem
            {"iron_golem/iron_golem.png", "iron_golem.png"},

            // Jigsaw
            {"jigsaw_bottom.png", "jigsaw_back.png"},
            {"jigsaw_top.png", "jigsaw_front.png"},

            // Kelp
            {"dried_kelp_side.png", "dried_kelp_side_a.png"},
            {"kelp.png", "kelp_top.png"},
            {"kelp_plant.png", "kelp_a.png"},

            // Lapis lazuli
            {"lapis_lazuli.png", "dye_powder_blue.png"},

            // Leaves
            {"acacia_leaves.png", "leaves_acacia.png"},
            {"birch_leaves.png", "leaves_birch.png"},
            {"dark_oak_leaves.png", "leaves_big_oak.png"},
            {"jungle_leaves.png", "leaves_jungle.png"},
            {"oak_leaves.png", "leaves_oak.png"},
            {"spruce_leaves.png", "leaves_spruce.png"},

            // Lily Pad
            {"lily_pad.png", "waterlily.png"},

            // Llama
            {"llama/brown.png", "llama/llama_brown.png"},
            {"llama/creamy.png", "llama/llama_creamy.png"},
            {"llama/gray.png", "llama/llama_gray.png"},
            {"llama/white.png", "llama/llama_white.png"},
            {"llama/decor/black.png", "llama/decor/decor_black.png"},
            {"llama/decor/blue.png", "llama/decor/decor_blue.png"},
            {"llama/decor/brown.png", "llama/decor/decor_brown.png"},
            {"llama/decor/cyan.png", "llama/decor/decor_cyan.png"},
            {"llama/decor/gray.png", "llama/decor/decor_gray.png"},
            {"llama/decor/green.png", "llama/decor/decor_green.png"},
            {"llama/decor/light_blue.png", "llama/decor/decor_light_blue.png"},
            {"llama/decor/light_gray.png", "llama/decor/decor_silver.png"},
            {"llama/decor/lime.png", "llama/decor/decor_lime.png"},
            {"llama/decor/magenta.png", "llama/decor/decor_magenta.png"},
            {"llama/decor/orange.png", "llama/decor/decor_orange.png"},
            {"llama/decor/pink.png", "llama/decor/decor_pink.png"},
            {"llama/decor/purple.png", "llama/decor/decor_purple.png"},
            {"llama/decor/red.png", "llama/decor/decor_red.png"},
            {"llama/decor/trader_llama.png", "llama/decor/trader_llama_decor.png"},
            {"llama/decor/white.png", "llama/decor/decor_white.png"},
            {"llama/decor/yellow.png", "llama/decor/decor_yellow.png"},

            // Log
            {"acacia_log.png", "log_acacia.png"},
            {"birch_log.png", "log_birch.png"},
            {"dark_oak_log.png", "log_big_oak.png"},
            {"jungle_log.png", "log_jungle.png"},
            {"oak_log.png", "log_oak.png"},
            {"spruce_log.png", "log_spruce.png"},

            // Log top
            {"acacia_log_top.png", "log_acacia_top.png"},
            {"birch_log_top.png", "log_birch_top.png"},
            {"dark_oak_log_top.png", "log_big_oak_top.png"},
            {"jungle_log_top.png", "log_jungle_top.png"},
            {"oak_log_top.png", "log_oak_top.png"},
            {"spruce_log_top.png", "log_spruce_top.png"},

            // Map
            {"filled_map.png", "map_filled.png"},
            {"filled_map_markings.png", "map_filled_markings.png"},
            {"map.png", "map_empty.png"},

            // Melon
            {"attached_melon_stem.png", "melon_stem_connected.png"},
            {"melon_stem.png", "melon_stem_disconnected.png"},
            {"glistering_melon_slice.png", "melon_speckled.png"},
            {"melon_slice.png", "melon.png"},

            // Minecart
            {"chest_minecart.png", "minecart_chest.png"},
            {"command_block_minecart.png", "minecart_command_block.png"},
            {"furnace_minecart.png", "minecart_furnace.png"},
            {"hopper_minecart.png", "minecart_hopper.png"},
            {"minecart.png", "minecart_normal.png"},
            {"tnt_minecart.png", "minecart_tnt.png"},

            // Mob effect
            {"/mob_effect/absorption.png", "/ui/absorption_effect.png"},
            {"/mob_effect/bad_omen.png", "/ui/bad_omen_effect.png"},
            {"/mob_effect/blindness.png", "/ui/blindness_effect.png"},
            {"/mob_effect/conduit_power.png", "/ui/conduit_power_effect.png"},
            {"/mob_effect/dolphins_grace.png", "/ui/dolphins_grace_effect.png"},
            {"/mob_effect/fire_resistance.png", "/ui/fire_resistance_effect.png"},
            {"/mob_effect/glowing.png", "/ui/glowing_effect.png"},
            {"/mob_effect/haste.png", "/ui/haste_effect.png"},
            {"/mob_effect/health_boost.png", "/ui/health_boost_effect.png"},
            {"/mob_effect/hero_of_the_village.png", "/ui/village_hero_effect.png"},
            {"/mob_effect/hunger.png", "/ui/hunger_effect.png"},
            {"/mob_effect/instant_damage.png", "/ui/instant_damage_effect.png"},
            {"/mob_effect/instant_health.png", "/ui/instant_health_effect.png"},
            {"/mob_effect/invisibility.png", "/ui/invisibility_effect.png"},
            {"/mob_effect/jump_boost.png", "/ui/jump_boost_effect.png"},
            {"/mob_effect/levitation.png", "/ui/levitation_effect.png"},
            {"/mob_effect/luck.png", "/ui/luck_effect.png"},
            {"/mob_effect/mining_fatigue.png", "/ui/mining_fatigue_effect.png"},
            {"/mob_effect/nausea.png", "/ui/nausea_effect.png"},
            {"/mob_effect/night_vision.png", "/ui/night_vision_effect.png"},
            {"/mob_effect/poison.png", "/ui/poison_effect.png"},
            {"/mob_effect/regeneration.png", "/ui/regeneration_effect.png"},
            {"/mob_effect/resistance.png", "/ui/resistance_effect.png"},
            {"/mob_effect/saturation.png", "/ui/saturation_effect.png"},
            {"/mob_effect/slow_falling.png", "/ui/slow_falling_effect.png"},
            {"/mob_effect/slowness.png", "/ui/slowness_effect.png"},
            {"/mob_effect/speed.png", "/ui/speed_effect.png"},
            {"/mob_effect/strength.png", "/ui/strength_effect.png"},
            {"/mob_effect/unluck.png", "/ui/unluck_effect.png"},
            {"/mob_effect/water_breathing.png", "/ui/water_breathing_effect.png"},
            {"/mob_effect/weakness.png", "/ui/weakness_effect.png"},
            {"/mob_effect/wither.png", "/ui/wither_effect.png"},

            // Mushroom
            {"brown_mushroom.png", "mushroom_brown.png"},
            {"red_mushroom.png", "mushroom_red.png"},
            {"brown_mushroom_block.png", "mushroom_block_skin_brown.png"},
            {"red_mushroom_block.png", "mushroom_block_skin_red.png"},
            {"mushroom_stem.png", "mushroom_block_skin_stem.png"},

            // Music disc
            {"music_disc_11.png", "record_11.png"},
            {"music_disc_13.png", "record_13.png"},
            {"music_disc_blocks.png", "record_blocks.png"},
            {"music_disc_cat.png", "record_cat.png"},
            {"music_disc_chirp.png", "record_chirp.png"},
            {"music_disc_far.png", "record_far.png"},
            {"music_disc_mall.png", "record_mall.png"},
            {"music_disc_mellohi.png", "record_mellohi.png"},
            {"music_disc_pigstep.png", "record_pigstep.png"},
            {"music_disc_stal.png", "record_stal.png"},
            {"music_disc_strad.png", "record_strad.png"},
            {"music_disc_wait.png", "record_wait.png"},
            {"music_disc_ward.png", "record_ward.png"},

            // Nether brick
            {"nether_bricks.png", "nether_brick.png"},
            {"red_nether_bricks.png", "red_nether_brick.png"},
            {"nether_brick.png", "netherbrick.png"},

            // Nether portal
            {"nether_portal.png", "portal.png"},

            // Nether wart
            {"nether_wart_stage0.png", "nether_wart_stage_0.png"},
            {"nether_wart_stage1.png", "nether_wart_stage_1.png"},
            {"nether_wart_stage2.png", "nether_wart_stage_2.png"},

            // Note block
            {"note_block.png", "noteblock.png"},

            // Nautilus shell
            {"nautilus_shell.png", "nautilus.png"},

            // Observer
            {"observer_back_on.png", "observer_back_lit.png"},

            // Painting
            {"/painting/paintings_kristoffer_zetterstrand.png", "/painting/kz.png"}, // 1.13

            // Panda
            {"panda/aggressive_panda.png", "panda/panda_aggressive.png"},
            {"panda/brown_panda.png", "panda/panda_brown.png"},
            {"panda/lazy_panda.png", "panda/panda_lazy.png"},
            {"panda/playful_panda.png", "panda/panda_playful.png"},
            {"panda/weak_panda.png", "panda/panda_sneezy.png"},
            {"panda/worried_panda.png", "panda/panda_worried.png"},

            // Piglin
            {"piglin/zombified_piglin.png", "piglin/zombie_piglin.png"},

            // Piston
            {"piston_top.png", "piston_top_normal.png"},

            // Planks
            {"acacia_planks.png", "planks_acacia.png"},
            {"birch_planks.png", "planks_birch.png"},
            {"dark_oak_planks.png", "planks_big_oak.png"},
            {"jungle_planks.png", "planks_jungle.png"},
            {"oak_planks.png", "planks_oak.png"},
            {"spruce_planks.png", "planks_spruce.png"},

            // Podzol
            {"podzol_side.png", "dirt_podzol_side.png"},
            {"podzol_top.png", "dirt_podzol_top.png"},

            // Potato
            {"potatoes_stage0.png", "potatoes_stage_0.png"},
            {"potatoes_stage1.png", "potatoes_stage_1.png"},
            {"potatoes_stage2.png", "potatoes_stage_2.png"},
            {"potatoes_stage3.png", "potatoes_stage_3.png"},
            {"baked_potato.png", "potato_baked.png"},
            {"poisonous_potato.png", "potato_poisonous.png"},

            // Potion
            {"lingering_potion.png", "potion_bottle_lingering_empty.png"},
            {"potion.png", "potion_bottle_empty.png"},
            {"splash_potion.png", "potion_bottle_splash_empty.png"},

            // Prismarine
            {"dark_prismarine.png", "prismarine_dark.png"},
            {"prismarine.png", "prismarine_rough.png"},

            // Pumpkin
            {"attached_pumpkin_stem.png", "pumpkin_stem_connected.png"},
            {"carved_pumpkin.png", "pumpkin_face_off.png"},
            {"jack_o_lantern.png", "pumpkin_face_on.png"},
            {"pumpkin_stem.png", "pumpkin_stem_disconnected.png"},

            // Quartz
            {"chiseled_quartz_block.png", "quartz_block_chiseled.png"},
            {"chiseled_quartz_block_top.png", "quartz_block_chiseled_top.png"},
            {"nether_quartz_ore.png", "quartz_ore.png"},
            {"quartz_pillar.png", "quartz_block_lines.png"},
            {"quartz_pillar_top.png", "quartz_block_lines_top.png"},

            // Rabbit
            {"rabbit/black.png", "rabbit/blackrabbit.png"},
            {"cooked_rabbit.png", "rabbit_cooked.png"},
            {"rabbit.png", "rabbit_raw.png"},

            // Rail
            {"activator_rail.png", "rail_activator.png"},
            {"activator_rail_on.png", "rail_activator_powered.png"},
            {"detector_rail.png", "rail_detector.png"},
            {"detector_rail_on.png", "rail_detector_powered.png"},
            {"powered_rail.png", "rail_golden.png"},
            {"powered_rail_on.png", "rail_golden_powered.png"},
            {"rail.png", "rail_normal.png"},
            {"rail_corner.png", "rail_normal_turned.png"},

            // Red sand
            {"chiseled_red_sandstone.png", "red_sandstone_carved.png"},
            {"cut_red_sandstone.png", "red_sandstone_smooth.png"},
            {"red_sandstone.png", "red_sandstone_normal.png"},

            // Redstone
            {"redstone.png", "redstone_dust.png"},

            // Redstone lamp
            {"redstone_lamp.png", "redstone_lamp_off.png"},

            // Repeater
            {"repeater.png", "repeater_off.png"},

            // Saddle
            {"pig/pig_saddle.png", "saddle.png"},

            // Sand
            {"chiseled_sandstone.png", "sandstone_carved.png"},
            {"cut_sandstone.png", "sandstone_smooth.png"},
            {"sandstone.png", "sandstone_normal.png"},

            // Sapling
            {"acacia_sapling.png", "sapling_acacia.png"},
            {"birch_sapling.png", "sapling_birch.png"},
            {"dark_oak_sapling.png", "sapling_roofed_oak.png"},
            {"jungle_sapling.png", "sapling_jungle.png"},
            {"oak_sapling.png", "sapling_oak.png"},
            {"spruce_sapling.png", "sapling_spruce.png"},

            // Sea grass
            {"tall_seagrass_top.png", "seagrass_doubletall_top_a.png"},
            {"tall_seagrass_bottom.png", "seagrass_doubletall_bottom_a.png"},
            {"seagrass.png", "seagrass_carried.png"},

            // Seed
            {"beetroot_seeds.png", "seeds_beetroot.png"},
            {"melon_seeds.png", "seeds_melon.png"},
            {"pumpkin_seeds.png", "seeds_pumpkin.png"},
            {"wheat_seeds.png", "seeds_wheat.png"},

            // Shield
            {"shield_base_nopattern.png", "shield.png"},

            // Shulker
            {"black_shulker_box.png", "shulker_top_black.png"},
            {"blue_shulker_box.png", "shulker_top_blue.png"},
            {"brown_shulker_box.png", "shulker_top_brown.png"},
            {"cyan_shulker_box.png", "shulker_top_cyan.png"},
            {"gray_shulker_box.png", "shulker_top_gray.png"},
            {"green_shulker_box.png", "shulker_top_green.png"},
            {"light_blue_shulker_box.png", "shulker_top_light_blue.png"},
            {"light_gray_shulker_box.png", "shulker_top_silver.png"},
            {"lime_shulker_box.png", "shulker_top_lime.png"},
            {"magenta_shulker_box.png", "shulker_top_magenta.png"},
            {"orange_shulker_box.png", "shulker_top_orange.png"},
            {"pink_shulker_box.png", "shulker_top_pink.png"},
            {"purple_shulker_box.png", "shulker_top_purple.png"},
            {"red_shulker_box.png", "shulker_top_red.png"},
            {"shulker_box.png", "shulker_top_undyed.png"},
            {"white_shulker_box.png", "shulker_top_white.png"},
            {"yellow_shulker_box.png", "shulker_top_yellow.png"},
            {"shulker/shulker.png", "shulker/shulker_undyed.png"},
            {"shulker/shulker_light_gray.png", "shulker/shulker_silver.png"},

            // Sign
            {"signs/acacia.png", "sign_acacia.png"},
            {"signs/birch.png", "sign_birch.png"},
            {"signs/crimson.png", "sign_crimson.png"},
            {"signs/dark_oak.png", "sign_darkoak.png"},
            {"signs/jungle.png", "sign_jungle.png"},
            {"signs/oak.png", "sign.png"},
            {"signs/spruce.png", "sign_spruce.png"},
            {"signs/warped.png", "sign_warped.png"},
            {"acacia_sign.png", "sign_acacia.png"},
            {"birch_sign.png", "sign_birch.png"},
            {"crimson_sign.png", "sign_crimson.png"},
            {"dark_oak_sign.png", "sign_darkoak.png"},
            {"jungle_sign.png", "sign_jungle.png"},
            {"oak_sign.png", "sign.png"},
            {"spruce_sign.png", "sign_spruce.png"},
            {"warped_sign.png", "sign_warped.png"},

            // Slime
            {"slime_block.png", "slime.png"},
            {"slime_ball.png", "slimeball.png"},

            // Smooth stone
            {"smooth_stone.png", "stone_slab_top.png"},
            {"smooth_stone_slab_side.png", "stone_slab_side.png"},

            // Spawner
            {"spawner.png", "mob_spawner.png"},

            // Spider
            {"fermented_spider_eye.png", "spider_eye_fermented.png"},

            // Sponge
            {"wet_sponge.png", "sponge_wet.png"},

            // Stone brick
            {"chiseled_stone_bricks.png", "stonebrick_carved.png"},
            {"cracked_stone_bricks.png", "stonebrick_cracked.png"},
            {"mossy_stone_bricks.png", "stonebrick_mossy.png"},
            {"stone_bricks.png", "stonebrick.png"},

            // Stone cutter
            {"stonecutter_bottom.png", "stonecutter2_bottom.png"},
            {"stonecutter_saw.png", "stonecutter2_saw.png"},
            {"stonecutter_side.png", "stonecutter2_side.png"},
            {"stonecutter_top.png", "stonecutter2_top.png"},

            // Strider
            {"strider/strider_cold.png", "strider/strider_suffocated.png"},

            // Structure
            {"structure_void.png", "structure_void.png"},

            // Sugar cane
            {"sugar_cane.png", "reeds.png"},

            // Terracotta
            {"black_terracotta.png", "hardened_clay_stained_black.png"},
            {"blue_terracotta.png", "hardened_clay_stained_blue.png"},
            {"brown_terracotta.png", "hardened_clay_stained_brown.png"},
            {"cyan_terracotta.png", "hardened_clay_stained_cyan.png"},
            {"gray_terracotta.png", "hardened_clay_stained_gray.png"},
            {"green_terracotta.png", "hardened_clay_stained_green.png"},
            {"light_blue_terracotta.png", "hardened_clay_stained_light_blue.png"},
            {"light_gray_terracotta.png", "hardened_clay_stained_silver.png"},
            {"lime_terracotta.png", "hardened_clay_stained_lime.png"},
            {"magenta_terracotta.png", "hardened_clay_stained_magenta.png"},
            {"orange_terracotta.png", "hardened_clay_stained_orange.png"},
            {"pink_terracotta.png", "hardened_clay_stained_pink.png"},
            {"purple_terracotta.png", "hardened_clay_stained_purple.png"},
            {"red_terracotta.png", "hardened_clay_stained_red.png"},
            {"terracotta.png", "hardened_clay.png"},
            {"white_terracotta.png", "hardened_clay_stained_white.png"},
            {"yellow_terracotta.png", "hardened_clay_stained_yellow.png"},

            // Torch
            {"redstone_torch.png", "redstone_torch_on.png"},
            {"torch.png", "torch_on.png"},

            // Totem of undying
            {"totem_of_undying.png", "totem.png"},

            // Trapdoor
            {"crimson_trapdoor.png", "huge_fungus/crimson_trapdoor.png"},
            {"oak_trapdoor.png", "trapdoor.png"},
            {"warped_trapdoor.png", "huge_fungus/warped_trapdoor.png"},

            // Tripwire
            {"tripwire.png", "trip_wire.png"},
            {"tripwire_hook.png", "trip_wire_source.png"},

            // Turtle
            {"turtle_egg.png", "turtle_egg_not_cracked.png"},
            {"turtle/big_sea_turtle.png", "sea_turtle.png"},
            {"scute.png", "turtle_shell_piece.png"},

            // UI
            {"/gui/options_background.png", "/ui/background.png"},
            {"/gui/title/background/panorama_0.png", "/ui/panorama_0.png"},
            {"/gui/title/background/panorama_1.png", "/ui/panorama_1.png"},
            {"/gui/title/background/panorama_2.png", "/ui/panorama_2.png"},
            {"/gui/title/background/panorama_3.png", "/ui/panorama_3.png"},
            {"/gui/title/background/panorama_4.png", "/ui/panorama_4.png"},
            {"/gui/title/background/panorama_5.png", "/ui/panorama_5.png"},
            {"/gui/title/background/panorama_overlay.png", "/ui/panorama_overlay.png"},

            // Villager
            {"villager/", "villager2/"},
            {"villager2/profession/", "villager2/professions/"},
            {"villager2/profession_level/", "villager2/levels/"},
            {"villager2/type/", "villager2/biomes/"},
            {"villager2/biomes/desert.png", "villager2/biomes/biome_desert.png"},
            {"villager2/biomes/jungle.png", "villager2/biomes/biome_jungle.png"},
            {"villager2/biomes/plains.png", "villager2/biomes/biome_plains.png"},
            {"villager2/biomes/savanna.png", "villager2/biomes/biome_savanna.png"},
            {"villager2/biomes/snow.png", "villager2/biomes/biome_snow.png"},
            {"villager2/biomes/swamp.png", "villager2/biomes/biome_swamp.png"},
            {"villager2/biomes/taiga.png", "villager2/biomes/biome_taiga.png"},
            {"villager2/levels/diamond.png", "villager2/levels/level_diamond.png"},
            {"villager2/levels/emerald.png", "villager2/levels/level_emerald.png"},
            {"villager2/levels/gold.png", "villager2/levels/level_gold.png"},
            {"villager2/levels/iron.png", "villager2/levels/level_iron.png"},
            {"villager2/levels/stone.png", "villager2/levels/level_stone.png"},
            {"villager2/professions/mason.png", "villager2/professions/stonemason.png"},

            // Vine
            {"twisting_vines.png", "twisting_vines_bottom.png"},
            {"twisting_vines_plant.png", "twisting_vines_base.png"},
            {"weeping_vines.png", "weeping_vines_bottom.png"},
            {"weeping_vines_plant.png", "weeping_vines_base.png"},

            // Warped
            {"stripped_warped_stem.png", "huge_fungus/stripped_warped_stem_side.png"},
            {"stripped_warped_stem_top.png", "huge_fungus/stripped_warped_stem_top.png"},
            {"warped_nylium.png", "warped_nylium_top.png"},
            {"warped_planks.png", "huge_fungus/warped_planks.png"},
            {"warped_stem.png", "huge_fungus/warped_stem_side.png"},
            {"warped_stem_top.png", "huge_fungus/warped_stem_top.png"},

            // Water
            {"water_flow.png", "water_flow_grey.png"},
            {"water_still.png", "water_still_grey.png"},

            // Wheat
            {"wheat_stage0.png", "wheat_stage_0.png"},
            {"wheat_stage1.png", "wheat_stage_1.png"},
            {"wheat_stage2.png", "wheat_stage_2.png"},
            {"wheat_stage3.png", "wheat_stage_3.png"},
            {"wheat_stage4.png", "wheat_stage_4.png"},
            {"wheat_stage5.png", "wheat_stage_5.png"},
            {"wheat_stage6.png", "wheat_stage_6.png"},
            {"wheat_stage7.png", "wheat_stage_7.png"},

            // Wither
            {"wither/", "wither_boss/"},
            {"wither_boss/wither_armor.png", "wither_boss/wither_armor_white.png"},

            // Wool
            {"black_wool.png", "wool_colored_black.png"},
            {"blue_wool.png", "wool_colored_blue.png"},
            {"brown_wool.png", "wool_colored_brown.png"},
            {"cyan_wool.png", "wool_colored_cyan.png"},
            {"gray_wool.png", "wool_colored_gray.png"},
            {"green_wool.png", "wool_colored_green.png"},
            {"light_blue_wool.png", "wool_colored_light_blue.png"},
            {"light_gray_wool.png", "wool_colored_silver.png"},
            {"lime_wool.png", "wool_colored_lime.png"},
            {"magenta_wool.png", "wool_colored_magenta.png"},
            {"orange_wool.png", "wool_colored_orange.png"},
            {"pink_wool.png", "wool_colored_pink.png"},
            {"purple_wool.png", "wool_colored_purple.png"},
            {"red_wool.png", "wool_colored_red.png"},
            {"white_wool.png", "wool_colored_white.png"},
            {"yellow_wool.png", "wool_colored_yellow.png"},

            // Zombie
            {"zombie_pigman.png", "pig/pigzombie.png"},
            {"zombie_villager/", "zombie_villager2/"},
            {"zombie_villager2/profession/", "zombie_villager2/professions/"},
            {"zombie_villager2/profession_level/", "zombie_villager2/levels/"},
            {"zombie_villager2/type/", "zombie_villager2/biomes/"},
            {"zombie_villager2/zombie_villager.png", "zombie_villager2/zombie-villager.png"},
            {"zombie_villager2/biomes/desert.png", "zombie_villager2/biomes/biome-desert-zombie.png"},
            {"zombie_villager2/biomes/jungle.png", "zombie_villager2/biomes/biome-jungle-zombie.png"},
            {"zombie_villager2/biomes/plains.png", "zombie_villager2/biomes/biome-plains-zombie.png"},
            {"zombie_villager2/biomes/savanna.png", "zombie_villager2/biomes/biome-savanna-zombie.png"},
            {"zombie_villager2/biomes/snow.png", "zombie_villager2/biomes/biome-snow-zombie.png"},
            {"zombie_villager2/biomes/swamp.png", "zombie_villager2/biomes/biome-swamp-zombie.png"},
            {"zombie_villager2/biomes/taiga.png", "zombie_villager2/biomes/biome-taiga-zombie.png"},
            {"zombie_villager2/levels/diamond.png", "zombie_villager2/levels/level_diamond.png"},
            {"zombie_villager2/levels/emerald.png", "zombie_villager2/levels/level_emerald.png"},
            {"zombie_villager2/levels/gold.png", "zombie_villager2/levels/level_gold.png"},
            {"zombie_villager2/levels/iron.png", "zombie_villager2/levels/level_iron.png"},
            {"zombie_villager2/levels/stone.png", "zombie_villager2/levels/level_stone.png"},
            {"zombie_villager2/professions/mason.png", "zombie_villager2/professions/stonemason.png"},

            // Other Changes requested by umfy
            {"/block/dirt_path_side.png", "grass_path_side.png"},
            {"/block/dirt_path_top.png", "grass_path_top.png"},
            {"/block/mangrove_log.png", "mangrove_log_side.png"},
            {"/block/stripped_mangrove_log.png", "stripped_mangrove_log_side.png"},
            {"/block/cherry_log.png", "cherry_log_side.png"},
            {"/block/stripped_cherry_log.png", "stripped_cherry_log_side.png"},

            //font
            {"ascii.png","default8.png" }
        };
    }
}
