using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marketplace
{
    class AltasDefectivas
    {
        public static Item [] altasProductos()
        {
            return new Item [] {
                // Weapon
               new Item (Items.Kzarka_Longsword, "Kzarka Longsword", 23, "750000", Item.GORANGE, Item.WEAPON),
               new Item (Items.Kzarka_Blade, "Kzarka Blade", 40, "730000", Item.GGREEN, Item.WEAPON),
               new Item (Items.Kzarka_Shortsword, "Kzarka Shortsword", 54, "750000", Item.GWHITE, Item.WEAPON),
               new Item (Items.Kzarka_Staff, "Kzarka Staff", 12, "710000", Item.GGOLD, Item.WEAPON),
               new Item (Items.Kzarka_Axe, "Kzarka Axe", 34, "723000", Item.GBLUE, Item.WEAPON),
               new Item (Items.Kzarka_Longsword, "Kzarka Longbow", 78, "745000", Item.GORANGE, Item.WEAPON),
               new Item (Items.Kzarka_Kriegsmesser, "Kzarka Kriegsmesser", 2, "767000", Item.GGREEN, Item.WEAPON),
               new Item (Items.Artisan_Hunting_Musket, "Artisan Hunting Musket", 5, "850000", Item.GBLUE, Item.WEAPON),
               new Item (Items.Kutum_Talisman, "Kutum Talisman", 12, "650000", Item.GGOLD, Item.WEAPON),
               // Second Weapon
               new Item (Items.Roaring_Magical_Dagger, "Roaring Magical Dagger", 21, "123000", Item.GWHITE, Item.SWEAPON),
               new Item (Items.Roaring_Magical_Shield, "Roaring Magical Shield", 45, "234000", Item.GBLUE, Item.SWEAPON),
               new Item (Items.Kzarka_Amulet, "Kzarka Amulet", 32, "156000", Item.GGREEN, Item.SWEAPON),
               new Item (Items.Kutum_Horn_Bow, "Kutum Horn Bow", 16, "212000", Item.GWHITE, Item.SWEAPON),
               new Item (Items.Blade_Trinket_of_Agony, "Blade Trinket of Agony", 15, "156000", Item.GORANGE, Item.SWEAPON),
               new Item (Items.Roaring_Magical_Ornamental_Knot, "Roaring Magical Ornamental Knot", 24, "189000", Item.GGOLD, Item.SWEAPON),
               new Item (Items.Kutum_Shuriken, "Kutum Shuriken", 11, "200000", Item.GBLUE, Item.SWEAPON),
               new Item (Items.Kutum_Kunai, "Kutum Kunai", 10, "150000", Item.GWHITE, Item.SWEAPON),
               // Armor
               new Item (Items.Ultimate_Grunil_Helmet, "Ultimate Grunil Helmet", 4, "450000", Item.GGOLD, Item.ARMOR),
               new Item (Items.Ultimate_Grunil_Armor, "Ultimate Grunil Armor", 6, "460000", Item.GORANGE, Item.ARMOR),
               new Item (Items.Ultimate_Grunil_Gloves, "Ultimate Grunil Gloves", 8, "455000", Item.GWHITE, Item.ARMOR),
               new Item (Items.Ultimate_Grunil_Shoes, "Ultimate Grunil Shoes", 1, "456000", Item.GGREEN, Item.ARMOR),
               // Accessories
               new Item (Items.Corrupt_Ruby_Earrings, "Corrupt Ruby Earrings", 1, "456000", Item.GGREEN, Item.ACCESSORIES),
               new Item (Items.Corrupt_Ruby_Necklace, "Corrupt Ruby Necklace", 3, "498000", Item.GORANGE, Item.ACCESSORIES),
               new Item (Items.Corrupt_Ruby_Ring, "Corrupt Ruby Ring", 5, "400000", Item.GWHITE, Item.ACCESSORIES),
               new Item (Items.Daybreak_Blue_Coral_Belt, "Daybreak Blue Coral Belt", 6, "410000", Item.GGOLD, Item.ACCESSORIES),
               // Ore
               new Item (Items.Copper_Ore, "Copper Ore", 200, "410000", Item.GWHITE, Item.ORES),
               new Item (Items.Gold_Ore, "Gold Ore", 150, "489000", Item.GWHITE, Item.ORES),
               new Item (Items.Iron_Ore, "Iron Ore", 120, "456000", Item.GWHITE, Item.ORES),
               new Item (Items.Lead_Ore, "Lead Ore", 150, "442000", Item.GWHITE, Item.ORES),
               new Item (Items.Platinum_Ore, "Platinum Ore", 50, "400000", Item.GWHITE, Item.ORES),
               new Item (Items.Silver_Ore, "Silver Ore", 60, "420000", Item.GWHITE, Item.ORES),
               // Plants
               new Item (Items.Special_Amanita_Mushroom, "Special Amanita Mushroom", 120, "120000", Item.GBLUE, Item.PLANTS),
               new Item (Items.High_Quality_Everlasting_Herb, "High-Quality Everlasting Herb", 110, "110000", Item.GGREEN, Item.PLANTS),
               new Item (Items.Cotton, "Cotton", 140, "124000", Item.GGREEN, Item.PLANTS),
               // Material
               new Item (Items.Acacia_Plank, "Acacia Plank", 120, "120000", Item.GWHITE, Item.MATERIAL),
               new Item (Items.Acacia_Timber, "Acacia Timber", 120, "120000", Item.GWHITE, Item.MATERIAL),
               new Item (Items.Acacia_Sap, "Acacia Sap", 20, "20000", Item.GWHITE, Item.MATERIAL),
               // Seeds
               new Item (Items.Corn_Seed, "Corn Seed", 20, "2000", Item.GWHITE, Item.SEEDS),
               new Item (Items.Carrot_Seed, "Carrot Seed", 10, "1000", Item.GWHITE, Item.SEEDS),
               new Item (Items.Grape_Seed, "Grape Seed", 12, "1200", Item.GWHITE, Item.SEEDS),
               // Hide
               new Item (Items.Bear_Hide, "Bear Hide", 200, "230000", Item.GWHITE, Item.HIDE),
               new Item (Items.Belladonna_Elephant_Hide, "Belladonna Elephant Hide", 220, "212000", Item.GWHITE, Item.HIDE),
               new Item (Items.Black_Leopard_Hide, "Black Leopard Hide", 240, "265000", Item.GWHITE, Item.HIDE),
               // Sea
               new Item (Items.Albacove, "Albacove", 20, "130000", Item.GGOLD, Item.SEA),
               // Blackstone
               new Item (Items.Black_Stone__Armor_, "Black Stone (Armor)", 20, "250000", Item.GORANGE, Item.BLACKSTONE),
               new Item (Items.Black_Stone__Weapon_, "Black Stone (Weapon)", 10, "250000", Item.GORANGE, Item.BLACKSTONE),
               // Crystal
               new Item (Items.Ancient_Magic_Crystal___Destruction, "Ancient Magic Crystal - Destruction", 10, "250000", Item.GORANGE, Item.CRYSTAL),
               new Item (Items.Ancient_Magic_Crystal___Healing, "Ancient Magic Crystal - Healing", 4, "225000", Item.GGOLD, Item.CRYSTAL),
               // Potion
               new Item (Items.Elixir_of_Deep_Sea, "Elixir of Deep Sea", 200, "450000", Item.GGOLD, Item.POTION),
               // Food
               new Item (Items.Classic_Couscous, "Classic Couscous", 150, "480000", Item.GGOLD, Item.FOOD),
               new Item (Items.Jumbo_King_of_Jungle_Hamburg, "Jumbo King of Jungle Hamburg", 50, "510000", Item.GGOLD, Item.FOOD),
               // Dye
               new Item (Items.Violet_Dye_Box, "Violet Dye Box", 2, "400000", Item.GGOLD, Item.DYE),
               // House
               new Item (Items._1st_Floor__No__1_1__Chapel, "1st Floor, No. 1-1, Chapel", 2, "900000", Item.GWHITE, Item.HOUSE),
               // Mount
               new Item (Items.Wagon_Registration_White_Wagon, "Wagon Registration: White Wagon", 2, "1000000", Item.GWHITE, Item.MOUNT),
               // Pet
               new Item (Items.Desert_Fox, "Desert Fox", 1, "6000000", Item.GWHITE, Item.PETS),
            };
        }
   
    }
}
