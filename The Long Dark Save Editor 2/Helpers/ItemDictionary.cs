using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Long_Dark_Save_Editor_2.Helpers
{
    public static class ItemDictionary
    {
        /// <summary>
        /// All known items in the game (for item ID lookup and inventory display)
        /// Updated for The Long Dark version 2.4.0 (including TFTFT and Broken Silence)
        /// </summary>
        public static Dictionary<string, string> Items = new Dictionary<string, string>
        {
            // Clothing - Accessories
            { "GEAR_BallisticVest", "Ballistic Vest" },
            { "GEAR_Crampons", "Crampons" },
            { "GEAR_ToolBelt", "Foreman's Tool Belt" },
            { "GEAR_ImprovisedCrampons", "Improvised Crampons" },
            { "GEAR_ImprovisedDownInsulation", "Improvised Insulation" },
            { "GEAR_MooseHideBag", "Moose-Hide Satchel" },
            { "GEAR_RifleScabbardA", "Security Chief's Rifle Holster" },
            { "GEAR_TechnicalBackpack", "Technical Backpack" },
            { "GEAR_EarMuffs", "Wool Ear Wrap" },

            // Clothing - Gloves
            { "GEAR_BasicGloves", "Driving Gloves" },
            { "GEAR_FleeceMittens", "Fleece Mittens" },
            { "GEAR_Gauntlets", "Gauntlets" },
            { "GEAR_ImprovisedMittens", "Improvised Hand Wraps" },
            { "GEAR_RabbitSkinMittens", "Rabbitskin Mitts" },
            { "GEAR_SkiGloves", "Ski Gloves" },
            { "GEAR_Mittens", "Wool Mittens" },
            { "GEAR_WorkGloves", "Work Gloves" },

            // Clothing - Headgear
            { "GEAR_HatLeatherAviatorA", "Aviator Cap" },
            { "GEAR_Balaclava", "Balaclava" },
            { "GEAR_BaseballCap", "Baseball Cap" },
            { "GEAR_CougarWrap", "Cougar Hide Wrap" },
            { "GEAR_CottonScarf", "Cotton Scarf" },
            { "GEAR_BasicWoolHat", "Cotton Toque" },
            { "GEAR_WoolWrapCap", "Fleece Cowl" },
            { "GEAR_ImprovisedHat", "Improvised Head Wrap" },
            { "GEAR_WoolWrap", "Long Wool Scarf" },
            { "GEAR_RabbitskinHat", "Rabbitskin Hat" },
            { "GEAR_HatGatorBalaclavaA", "Technical Balaclava" },
            { "GEAR_WolfSkinHat", "Wolfskin Hat" },
            { "GEAR_Toque", "Wool Toque" },

            // Clothing - Pants
            { "GEAR_CargoPants", "Cargo Pants" },
            { "GEAR_CombatPants", "Combat Pants" },
            { "GEAR_DeerSkinPants", "Deerskin Pants" },
            { "GEAR_Jeans", "Jeans" },
            { "GEAR_InsulatedPants", "Snow Pants" },
            { "GEAR_LongUnderwear", "Thermal Underwear" },
            { "GEAR_WolfSkinPant", "Wolfskin Pants" },
            { "GEAR_LongUnderwearWool", "Wool Longjohns" },
            { "GEAR_WorkPants", "Work Pants" },

            // Clothing - Shirts
            { "GEAR_BearSkinCoat", "Bearskin Coat" },
            { "GEAR_CowichanSweater", "Cowichan Sweater" },
            { "GEAR_DownVest", "Down Vest" },
            { "GEAR_CottonShirt", "Dress Shirt" },
            { "GEAR_PremiumWinterCoat", "Expedition Parka" },
            { "GEAR_FishermanSweater", "Fisherman's Sweater" },
            { "GEAR_JacketLeatherFlightA", "Flight Jacket" },
            { "GEAR_JerseyHockeyA", "Hockey Jersey" },
            { "GEAR_CottonHoodie", "Hoodie" },
            { "GEAR_SkiJacket", "Light Shell" },
            { "GEAR_MackinawJacket", "Mackinaw Jacket" },
            { "GEAR_QualityWinterCoat", "Mariner's Pea Coat" },
            { "GEAR_MilitaryParka", "Military Coat" },
            { "GEAR_MooseHideCloak", "Moose-Hide Cloak" },
            { "GEAR_HeavyParka", "Old Fashioned Parka" },
            { "GEAR_PlaidShirt", "Plaid Shirt" },
            { "GEAR_LightParka", "Simple Parka" },
            { "GEAR_DownSkiJacket", "Ski Jacket" },
            { "GEAR_InsulatedVest", "Sport Vest" },
            { "GEAR_FleeceSweater", "Sweatshirt" },
            { "GEAR_HeavyWoolSweater", "Thick Wool Sweater" },
            { "GEAR_WoolSweater", "Thin Wool Sweater" },
            { "GEAR_TeeShirt", "T-Shirt" },
            { "GEAR_TShirtCM", "T-Shirt (CM)" },
            { "GEAR_TShirtGBI", "T-Shirt (GBI)" },
            { "GEAR_TShirtSnappy", "T-Shirt (Snappy)" },
            { "GEAR_DownParka", "Urban Parka" },
            { "GEAR_BasicWinterCoat", "Windbreaker" },
            { "GEAR_WolfSkinCape", "Wolfskin Coat" },
            { "GEAR_WolfSkinCapeTallTales", "Wolfskin Coat (Tales)" },
            { "GEAR_WoolShirt", "Wool Shirt" },

            // Clothing - Shoes
            { "GEAR_ClimbingSocks", "Climbing Socks" },
            { "GEAR_CombatBoots", "Combat Boots" },
            { "GEAR_DeerSkinBoots", "Deerskin Boots" },
            { "GEAR_InsulatedBoots", "Insulated Boots" },
            { "GEAR_LeatherShoes", "Leather Shoes" },
            { "GEAR_MuklukBoots", "Mukluks" },
            { "GEAR_BasicShoes", "Running Shoes" },
            { "GEAR_SkiBoots", "Ski Boots" },
            { "GEAR_CottonSocks", "Sports Socks" },
            { "GEAR_BasicBoots", "Trail Boots" },
            { "GEAR_WoolSocks", "Wool Socks" },
            { "GEAR_WorkBoots", "Work Boots" },

            // Collectibles - Memento (selected examples - there are many)
            { "GEAR_VisorNoteBlackrockKey3", "Memento - Blackrock - Memento Key" },
            { "GEAR_BIKey1", "Memento - Bleak Inlet - Memento Key" },
            { "GEAR_BIKey2", "Memento - Bleak Inlet - Memento Key" },
            { "GEAR_BoltCutters", "Memento - Bolt Cutters" },
            { "GEAR_BRKey1", "Memento - Broken Railroad - Memento Key" },
            { "GEAR_BRKey2", "Memento - Broken Railroad - Memento Key" },
            { "GEAR_VisorNoteACKey1", "Memento - Coastal Highway - Memento Key" },
            { "GEAR_VisorNoteDPKey1", "Memento - Desolation Point - Memento Key" },
            { "GEAR_VisorNoteHRVKey1", "Memento - Hushed River Valley - Memento Key" },
            { "GEAR_VisorNoteMTKey1", "Memento - Mountain Town - Memento Key" },
            { "GEAR_MountainTownFarmKey", "Memento - Mountain Town - Paradise Meadows Farm Key" },
            { "GEAR_VisorNoteMLKey2", "Memento - Mystery Lake - Memento Key" },
            { "GEAR_VisorNoteMLKey3", "Memento - Mystery Lake - Memento Key" },
            { "GEAR_LangstonMineLockboxKey1", "Memento - Zone of Contamination - Mine Lockbox Key" },
            { "GEAR_Tale2_LockerKey", "Memento - Zone of Contamination - Mine Lockbox Key" },
            { "GEAR_LangstonMineKey1", "Memento - Zone of Contamination - Mine Office Key" },
            { "GEAR_Tale2_CorpseKey", "Memento - Zone of Contamination - Mine Office Key" },

            // Collectibles - Note (selected examples - there are many)
            { "GEAR_MineRegionPumphouseNote", "Note - - Langston Mine Memo" },
            { "GEAR_MineRegionBunkhouseNote", "Note - - Mining Newsletter" },
            { "GEAR_AirfieldGeologistNote1", "Note - Airfield - Faded Paper" },
            { "GEAR_AirfieldJunkerNote", "Note - Airfield - Journal Page" },
            { "GEAR_AirfieldHangarNote", "Note - Airfield - Memo" },
            { "GEAR_AirfieldControlNote", "Note - Airfield - Note" },
            { "GEAR_AirfieldTowerNote", "Note - Airfield - Note (bugged)" },
            { "GEAR_AirfieldCabinNote", "Note - Airfield - Page" },
            { "GEAR_AirfieldCargomasterNote", "Note - Airfield - Paper" },
            { "GEAR_AirfieldSecChiefNote1", "Note - Airfield - Stained Paper" },
            { "GEAR_CanyonFishingHutJournal", "Note - Ash Canyon - Diary Page" },
            { "GEAR_CanyonClimbersCaveNote", "Note - Ash Canyon - Notebook Page" },
            { "GEAR_CanyonDeadClimberNote", "Note - Ash Canyon - Notebook Page" },
            { "GEAR_BackerNote1A", "Note - Backer - A Note Left Behind" },

            // Collectibles - Polaroid
            { "GEAR_PostCard_AC_CentralSpire", "Polaroid - Ash Canyon - High Meadow" },
            { "GEAR_PostCard_AC_TopShelf", "Polaroid - Ash Canyon - Wolf's Jaw Overlook" },
            { "GEAR_PostCard_BR_Canyon", "Polaroid - Blackrock - Fool's Corner" },
            { "GEAR_PostCard_BR_Prison", "Polaroid - Blackrock - Prison" },
            { "GEAR_PostCard_BI_EchoOne-RadioTower", "Polaroid - Bleak Inlet - Echo One Radio Tower" },
            { "GEAR_PostCard_CR_AbandonedLookout", "Polaroid - Coastal Highway - Abandoned Lookout" },
            { "GEAR_PostCard_FM_MuskegOverlook", "Polaroid - Forlorn Muskeg - Muskeg Overlook" },
            { "GEAR_PostCard_FM_ShortwaveTower", "Polaroid - Forlorn Muskeg - Shortwave Tower" },
            { "GEAR_PostCard_RV_Pensive", "Polaroid - Hushed River Valley - Pensive Vista" },
            { "GEAR_PostCard_MT_RadioTower", "Polaroid - Mountain Town - Radio Tower" },
            { "GEAR_PostCard_ML_ForestryLookout", "Polaroid - Mystery Lake - Forestry Lookout" },
            { "GEAR_PostCard_ML_LakeOverlook", "Polaroid - Mystery Lake - Lake Overlook" },
            { "GEAR_PostCard_PV_SignalHill", "Polaroid - Pleasant Valley - Pleasant Valley" },
            { "GEAR_PostCard_Tale02", "Polaroid - Tales - Faded Photograph" },
            { "GEAR_PostCard_TM_AndresPeak", "Polaroid - Timberwolf Mountain - Andre's Peak" },
            { "GEAR_PostCard_TM_TailSection", "Polaroid - Timberwolf Mountain - Summit" },
            { "GEAR_PostCard_MR_Settlement", "Polaroid - Zone of Contamination - Cliff near Boss's Settlement" },
            { "GEAR_PostCard_MR_Window", "Polaroid - Zone of Contamination - Cliff near Welkin's Window" },
            { "GEAR_PostCard_AF_Cabin", "Polaroid - Airfield - Cabin" },
            { "GEAR_PostCard_AF_Plateau", "Polaroid - Airfield - Plateau" },

            // Collectibles - Unique Recipes
            { "GEAR_RecipeCardPorridgeFruit", "Unique Recipe - Camber Flight Porridge" },
            { "GEAR_RecipeCardFishcakes", "Unique Recipe - Coastal Fishcakes" },
            { "GEAR_RecipeCardMeat", "Unique Recipe - Lily's Pancakes" },
            { "GEAR_RecipeCardPancakePeach", "Unique Recipe - Lily's Pancakes" },
            { "GEAR_RecipeCardStewMeat", "Unique Recipe - Ranger Stew" },

            // Fire Starting - Accelerant
            { "GEAR_Accelerant", "Accelerant" },
            { "GEAR_AccelerantKerosene", "Accelerant" },
            { "GEAR_AccelerantMedium", "Accelerant" },
            { "GEAR_GunpowderCan", "Can of Gunpowder" },
            { "GEAR_JerrycanRusty", "Jerry Can" },
            { "GEAR_LampFuelFull", "Lantern Fuel (0.50 kg)" },
            { "GEAR_LampFuel", "Lantern Fuel (Random amount)" },

            // Fire Starting - Fuel
            { "GEAR_BookA", "Book" },
            { "GEAR_BookB", "Book" },
            { "GEAR_BookBopen", "Book" },
            { "GEAR_BookC", "Book" },
            { "GEAR_BookD", "Book" },
            { "GEAR_BookE", "Book" },
            { "GEAR_BookEopen", "Book" },
            { "GEAR_BookF", "Book" },
            { "GEAR_BookFopen", "Book" },
            { "GEAR_BookG", "Book" },
            { "GEAR_BookH", "Book" },
            { "GEAR_BookHopen", "Book" },
            { "GEAR_BookI", "Book" },
            { "GEAR_BookLabE_01", "Book" },
            { "GEAR_BookLabE_02", "Book" },
            { "GEAR_BookLabE_03", "Book" },
            { "GEAR_BookLabE_Open_01", "Book" },
            { "GEAR_BookManual", "Book" },
            { "GEAR_Softwood", "Cedar Firewood" },
            { "GEAR_Coal", "Coal" },
            { "GEAR_Hardwood", "Fir Firewood" },
            { "GEAR_Firelog", "Firelog" },
            { "GEAR_ReclaimedWoodB", "Reclaimed Wood" },
            { "GEAR_Stick", "Stick" },

            // Fire Starting - Skillbook
            { "GEAR_BookMending", "A Sewing Primer (Mending Skill Book - Beginner)" },
            { "GEAR_BookRifleFirearmAdvanced", "Advanced Guns Guns Guns! (Rifle Firearm Skill Book - Advanced)" },
            { "GEAR_BookCarcassHarvesting", "Field Dressing Your Kill, Vol. 1 (Carcass Harvesting Skill Book - Intermediate)" },
            { "GEAR_BookRifleFirearm", "Frontier Shooting Guide (Rifle Firearm Skill Book - Beginner)" },
            { "GEAR_BookGunsmithing", "Practical Gunsmithing (Gunsmithing Skill Book - Beginner)" },
            { "GEAR_BookRevolverFirearm", "Small Arms Handbook (Revolver Firearm Skill Book - Beginner)" },
            { "GEAR_BookArchery", "Stay on Target (Archery Skill Book - Beginner)" },
            { "GEAR_BookFireStarting", "Surviving The Outdoors! (Fire Starting Skill Book - Beginner)" },
            { "GEAR_BookIceFishing", "The Frozen Angler (Ice Fishing Skill Book - Beginner)" },
            { "GEAR_BookCooking", "Wilderness Kitchen (Cooking Skill Book - Beginner)" },

            // Fire Starting - Starters
            { "GEAR_PackMatches", "Cardboard Matches (20)" },
            { "GEAR_Firestriker", "Firestriker" },
            { "GEAR_FlareA", "Flare" },
            { "GEAR_MagnifyingLens", "Magnifying Lens" },
            { "GEAR_BlueFlare", "Marine Flare" },
            { "GEAR_Torch", "Torch" },
            { "GEAR_WoodMatches", "Wood Matches (12)" },

            // Fire Starting - Tinder
            { "GEAR_BarkTinder", "Birch Bark" },
            { "GEAR_CashBundle", "Cash" },
            { "GEAR_CattailTinder", "Cat Tail Head" },
            { "GEAR_Newsprint", "Newsprint" },
            { "GEAR_NewsprintRoll", "Newsprint Roll" },
            { "GEAR_PaperStack", "Stack of Papers" },
            { "GEAR_Tinder", "Tinder Plug" },

            // First Aid
            { "GEAR_BottleAntibiotics", "Antibiotics (6)" },
            { "GEAR_BottleHydrogenPeroxide", "Antiseptic" },
            { "GEAR_HeavyBandage", "Bandage" },
            { "GEAR_Canister", "Canister" },
            { "GEAR_EmergencyStim", "Emergency Stim" },
            { "GEAR_SodaEnergy", "Go! Energy Drink" },
            { "GEAR_OldMansBeardDressing", "Old Man's Beard Wound Dressing" },
            { "GEAR_BottlePainKillers", "Painkillers (6)" },
            { "GEAR_BirchbarkPrepared", "Prepared Birch Bark" },
            { "GEAR_ReishiPrepared", "Prepared Reishi Mushrooms" },
            { "GEAR_RosehipsPrepared", "Prepared Rose Hips" },
            { "GEAR_Respirator", "Respirator" },
            { "GEAR_WaterPurificationTablets", "Water Purification Tablets (4)" },

            // Food and Drink - Carcasses
            { "GEAR_BearQuarter", "Bear Quarter (0kg, fully harvestable)" },
            { "GEAR_StagQuarter", "Deer Quarter (0kg, fully harvestable)" },
            { "GEAR_MooseQuarter", "Moose Quarter (0kg, fully harvestable)" },
            { "GEAR_PtarmiganCarcass", "Ptarmigan Carcass" },
            { "GEAR_RabbitCarcass", "Rabbit Carcass" },
            { "GEAR_WolfCarcass", "Wolf Carcass (0kg, fully harvestable)" },
            { "GEAR_TimberwolfQuarter", "Wolf Quarter (0kg, fully harvestable)" },
            { "GEAR_WolfQuarter", "Wolf Quarter (0kg, fully harvestable)" },

            // Food and Drink - Drink
            { "GEAR_BirchbarkTea", "Birch Bark Tea" },
            { "GEAR_BurdockTea", "Burdock Tea" },
            { "GEAR_AcornCoffeeCup", "Cup of Acorn Coffee" },
            { "GEAR_CoffeeCup", "Cup of Coffee" },
            { "GEAR_GreenTeaCup", "Cup of Herbal Tea" },
            { "GEAR_SodaOrange", "Orange Soda" },
            { "GEAR_ReishiTea", "Reishi Tea" },
            { "GEAR_RoseHipTea", "Rose Hip Tea" },
            { "GEAR_SodaGrape", "Stacy's Grape Soda" },
            { "GEAR_Soda", "Summit Soda" },
            { "GEAR_Water500ml", "Water (Potable) (0,5L)" },
            { "GEAR_Water1000ml", "Water (Potable) (1L)" },

            // Food and Drink - Food
            { "GEAR_CookedBannockAcorn", "Acorn Bannock (2)" },
            { "GEAR_CookedPancakeAcorn", "Acorn Pancakes" },
            { "GEAR_AirlineFoodChick", "Airline Food - Chicken" },
            { "GEAR_AirlineFoodVeg", "Airline Food - Vegetarian" },
            { "GEAR_CookedBannock", "Bannock (2)" },
            { "GEAR_RawMeatBear", "Bear Meat" },
            { "GEAR_CookedMeatBear", "Bear Meat (Cooked)" },
            { "GEAR_BeefJerky", "Beef Jerky" },
            { "GEAR_CookedPieMeat", "Breyerhouse Pie" },
            { "GEAR_Broth", "Broth" },
            { "GEAR_CookedBurbot", "Burbot (Cooked)" },
            { "GEAR_RawBurbot", "Burbot (Raw)" },
            { "GEAR_CannedCorn", "Canned Corn" },
            { "GEAR_CannedHam", "Canned Ham" },
            { "GEAR_Carrot", "Carrot" },
            { "GEAR_CattailPlant", "Cat Tail Head + Cat Tail Stalk" },
            { "GEAR_CattailStalk", "Cat Tail Stalk" },
            { "GEAR_CandyBar", "Chocolate Bar" },
            { "GEAR_CookedFishcakes", "Coastal Fishcakes (4)" },
            { "GEAR_CookedCohoSalmon", "Coho Salmon (Cooked)" },
            { "GEAR_RawCohoSalmon", "Coho Salmon (Raw)" },
            { "GEAR_CondensedMilk", "Condensed Milk" },
            { "GEAR_PotatoCooked", "Cooked Potato" },
            { "GEAR_CookedPieFishermans", "Dockworker's Pie" },
            { "GEAR_DogFood", "Dog Food" },
            { "GEAR_EnergyBar", "Energy Bar" },
            { "GEAR_GranolaBar", "Granola Bar" },
            { "GEAR_KetchupChips", "Ketchup Chips" },
            { "GEAR_CookedLakeWhiteFish", "Lake Whitefish (Cooked)" },
            { "GEAR_RawLakeWhiteFish", "Lake Whitefish (Raw)" },
            { "GEAR_CookedPancakePeach", "Lily's Pancakes" },
            { "GEAR_MapleSyrup", "Maple Syrup" },
            { "GEAR_MRE", "Military-Grade MRE" },
            { "GEAR_RawMeatMoose", "Moose Meat" },
            { "GEAR_CookedMeatMoose", "Moose Meat (Cooked)" },
            { "GEAR_CookedPancake", "Pancakes" },
            { "GEAR_CookedPiePeach", "Peach Pie (3)" },
            { "GEAR_PeanutButter", "Peanut Butter" },
            { "GEAR_PinnacleCanPeaches", "Pinnacle Peaches" },
            { "GEAR_CannedBeans", "Pork and Beans" },
            { "GEAR_Potato", "Potato" },
            { "GEAR_BurdockPrepared", "Prepared Burdock" },
            { "GEAR_CookedPieForagers", "Prepper's Pie" },
            { "GEAR_CookedMeatPtarmigan", "Ptarmigan (Cooked)" },
            { "GEAR_RawMeatPtarmigan", "Ptarmigan (Raw)" },
            { "GEAR_CookedPiePtarmigan", "Ptarmigan Pie (3)" },
            { "GEAR_CookedStewPtarmigan", "Ptarmigan Stew" },
            { "GEAR_CookedMeatRabbit", "Rabbit (Cooked)" },
            { "GEAR_RawMeatRabbit", "Rabbit (Raw)" },
            { "GEAR_CookedPieRabbit", "Rabbit Pie (3)" },
            { "GEAR_CookedStewRabbit", "Rabbit Stew" },
            { "GEAR_CookedRainbowTrout", "Rainbow Trout (Cooked)" },
            { "GEAR_RawRainbowTrout", "Rainbow Trout (Raw)" },
            { "GEAR_CookedStewMeat", "Ranger Stew" },
            { "GEAR_CookedRedIrishLord", "Red Irish Lord (Cooked)" },
            { "GEAR_RawRedIrishLord", "Red Irish Lord (Raw)" },
            { "GEAR_CookedRockfish", "Rockfish (Cooked)" },
            { "GEAR_RawRockfish", "Rockfish (Raw)" },
            { "GEAR_CookedPieRoseHip", "Rose Hip Pie (3)" },
            { "GEAR_Crackers", "Salty Crackers" },
            { "GEAR_CookedSmallMouthBass", "Smallmouth Bass (Cooked)" },
            { "GEAR_RawSmallMouthBass", "Smallmouth Bass (Raw)" },
            { "GEAR_CookedPiePredator", "Stalker's Pie" },
            { "GEAR_CookedStewVegetables", "Thomson Family Stew" },
            { "GEAR_CannedSardines", "Tin of Sardines" },
            { "Gear_TomatoSoupCan", "Tomato Soup" },
            { "GEAR_CookedStewTrout", "Trout Stew" },
            { "GEAR_RawMeatDeer", "Venison" },
            { "GEAR_CookedMeatDeer", "Venison (Cooked)" },
            { "GEAR_CookedPieVenison", "Venison Pie (3)" },
            { "GEAR_CookedStewVenison", "Venison Stew" },
            { "GEAR_CookedMeatWolf", "Wolf Meat (Cooked)" },
            { "GEAR_RawMeatWolf", "Wolf Meat (Raw)" },

            // Food and Drink - Ingredients
            { "GEAR_AcornCookedBig", "Acorns (Cooked - Large Portion)" },
            { "GEAR_AcornCooked", "Acorns (Cooked)" },
            { "GEAR_CookingOil", "Cooking Oil" },
            { "GEAR_GreenTeaPackage", "Herbal Tea (5)" },
            { "GEAR_Flour", "Old Mill Flour" },
            { "GEAR_OatsTin", "Running River Oats" },
            { "GEAR_Salt", "Salt" },
            { "GEAR_SaltBag", "Salt Bag" },
            { "GEAR_CoffeeTin", "Tin of Coffee" },

            // Materials - Animal
            { "GEAR_CrowFeather", "Crow Feather" },
            { "GEAR_BearHideDried", "Cured Black Bear Hide" },
            { "GEAR_LeatherHideDried", "Cured Deer Hide" },
            { "GEAR_GutDried", "Cured Gut" },
            { "GEAR_MooseHideDried", "Cured Moose Hide" },
            { "GEAR_RabbitPeltDried", "Cured Rabbit Pelt" },
            { "GEAR_WolfPeltDried", "Cured Wolf Pelt" },
            { "GEAR_BearHide", "Fresh Black Bear Hide" },
            { "GEAR_LeatherHide", "Fresh Deer Hide" },
            { "GEAR_Gut", "Fresh Gut" },
            { "GEAR_MooseHide", "Fresh Moose Hide" },
            { "GEAR_RabbitPelt", "Fresh Rabbit Pelt" },
            { "GEAR_WolfPelt", "Fresh Wolf Pelt" },
            { "GEAR_PtarmiganFeathers", "Ptarmigan Feathers" },

            // Materials - Archery
            { "GEAR_ArrowShaft", "Arrow Shaft" },
            { "GEAR_ArrowHead", "Arrowhead" },

            // Materials - Discontinued
            { "GEAR_Leather", "Fresh Leather" },

            // Materials - Gunsmithing
            { "GEAR_Bullet", "Bullet" },
            { "GEAR_DustingSulfur", "Dusting Sulfur" },
            { "GEAR_RevolverAmmoCasing", "Revolver Shell Casing" },
            { "GEAR_RifleAmmoCasing", "Rifle Shell Casing" },
            { "GEAR_ScrapLead", "Scrap Lead" },
            { "GEAR_StumpRemover", "Stump Remover" },

            // Materials - Other
            { "GEAR_Cloth", "Cloth" },
            { "GEAR_LeatherDried", "Cured Leather" },
            { "GEAR_ScrapMetal", "Scrap Metal" },

            // Materials - Plant
            { "GEAR_AcornGrounds", "Acorn Grounds" },
            { "GEAR_Acorn", "Acorns" },
            { "GEAR_Burdock", "Burdock Root" },
            { "GEAR_BirchSaplingDried", "Cured Birch Sapling" },
            { "GEAR_MapleSaplingDried", "Cured Maple Sapling" },
            { "GEAR_BirchSapling", "Green Birch Sapling" },
            { "GEAR_MapleSapling", "Green Maple Sapling" },
            { "GEAR_OldMansBeardHarvested", "Old Man's Beard Lichen" },
            { "GEAR_AcornShelled", "Prepared Acorns" },
            { "GEAR_AcornShelledBig", "Prepared Acorns (Large Portion)" },
            { "GEAR_ReishiMushroom", "Reishi Mushroom" },
            { "GEAR_RoseHip", "Rose Hip" },

            // Props - Prop (selected examples)
            { "GEAR_UncookedBannockAcorn", "Acorn Bannock (Prop)" },
            { "GEAR_UncookedPancakeAcorn", "Acorn Pancakes (Prop)" },
            { "GEAR_UncookedBannock", "Bannock (Prop)" },
            { "GEAR_UncookedPieMeat", "Breyerhouse Pie (Prop)" },
            { "GEAR_UncookedBroth", "Broth (Prop)" },
            { "GEAR_UncookedPorridgeFruit", "Camber Flight Porridge (Prop)" },
            { "GEAR_UncookedFishcakes", "Coastal Fishcakes (Prop)" },
            { "GEAR_CookingPotDummy", "Cooking Pot (Prop)" },
            { "GEAR_UncookedPieFishermans", "Dockworker's Pie (Prop)" },
            { "GEAR_NewsprintBootStuffing", "GAMEPLAY_NEWSPRINTINSILATION" },
            { "GEAR_NewsprintInsulation", "GAMEPLAY_NEWSPRINTINSILATION" },
            { "GEAR_AccelerantGunpowder", "Gunpowder (Prop)" },
            { "GEAR_FishingLine", "Line (Prop)" },
            { "GEAR_UncookedPancake", "Pancakes (Prop)" },
            { "GEAR_UncookedPiePeach", "Peach Pie (Prop)" },
            { "GEAR_UncookedPorridge", "Porridge (Prop)" },
            { "GEAR_UncookedPieForagers", "Prepper's Pie (Prop)" },
            { "GEAR_UncookedPiePtarmigan", "Ptarmigan Pie (Prop)" },
            { "GEAR_UncookedStewPtarmigan", "Ptarmigan Stew (Prop)" },
            { "GEAR_UncookedPieRabbit", "Rabbit Pie (Prop)" },
            { "GEAR_UncookedStewRabbit", "Rabbit Stew (Prop)" },
            { "GEAR_UncookedStewMeat", "Ranger Stew (Prop)" },
            { "GEAR_UncookedPieRoseHip", "Rose Hip Pie (Prop)" },
            { "GEAR_UncookedPiePredator", "Stalker's Pie (Prop)" },
            { "GEAR_UncookedStewVegetables", "Thomson Family Stew (Prop)" },
            { "GEAR_UncookedStewTrout", "Trout Stew (Prop)" },
            { "GEAR_UncookedPieVenison", "Venison Pie (Prop)" },
            { "GEAR_UncookedStewVenison", "Venison Stew (Prop)" },

            // Tools - Cooking
            { "GEAR_CanOpener", "Can Opener" },
            { "GEAR_CookingPot", "Cooking Pot" },
            { "GEAR_Skillet", "Cooking Skillet" },
            { "GEAR_InsulatedFlask_A", "Insulated Flask" },
            { "GEAR_RecycledCan", "Recycled Can" },

            // Tools - Hand Tools
            { "GEAR_Hacksaw", "Hacksaw" },
            { "GEAR_Hatchet", "Hatchet" },
            { "GEAR_Hammer", "Heavy Hammer" },
            { "GEAR_Knife", "Hunting Knife" },
            { "GEAR_HatchetImprovised", "Improvised Hatchet" },
            { "GEAR_KnifeImprovised", "Improvised Knife" },
            { "GEAR_Prybar", "Prybar" },

            // Tools - Ice Fishing
            { "GEAR_FishingBaitA", "Fishing Bait" },
            { "GEAR_FishingLureC", "Fishing Lure (Acorn)" },
            { "GEAR_FishingLureB", "Fishing Lure (Casing)" },
            { "GEAR_FishingLureD", "Fishing Lure (Wire)" },
            { "GEAR_HookAndLine", "Fishing Tackle" },
            { "GEAR_TipUp", "Fishing Tip-UP" },
            { "GEAR_Hook", "Hook" },
            { "GEAR_Line", "Line" },
            { "GEAR_FishingLureA", "Simple Fishing Lure" },

            // Tools - Light
            { "GEAR_KeroseneLamp_Spelunkers", "Spelunker's Lantern" },
            { "GEAR_KeroseneLampB", "Storm Lantern" },

            // Tools - Mending
            { "GEAR_RifleCleaningKit", "Firearm Cleaning Kit" },
            { "GEAR_HighQualityTools", "Quality Tools" },
            { "GEAR_SewingKit", "Sewing Kit" },
            { "GEAR_SimpleTools", "Simple Tools" },
            { "GEAR_SharpeningStone", "Whetstone" },

            // Tools - Other
            { "GEAR_BrokenArrow", "Broken Arrow" },
            { "GEAR_BrokenArrowHardened", "Broken Fire Hardened Arrow" },
            { "GEAR_Charcoal", "Charcoal" },
            { "GEAR_SurvivalElevatorCrank", "Elevator Crank" },
            { "GEAR_GoldNugget", "Gold Nugget" },
            { "GEAR_HandheldShortwave", "Handheld Shortwave Radio" },
            { "GEAR_Tale1ChiefNote1", "Handheld Shortwave Radio (Starts Tales)" },
            { "GEAR_Rope", "Mountaineering Rope" },
            { "GEAR_Snare", "Snare" },
            { "GEAR_SprayPaintCan", "Spray Paint" },
            { "GEAR_SprayPaintCanGlyphA", "Spray Paint - Glyph (Darkwalker)" },
            { "GEAR_Travois", "Travois" },

            // Tools - Sleep
            { "GEAR_BearSkinBedRoll", "Bear Skin Bedroll" },
            { "GEAR_BedRoll", "Bedroll" },
            { "GEAR_BedRoll_Down", "Improvised Down Bedroll" },

            // Tools - Transmitter Parts
            { "GEAR_CarBattery", "Car Battery" },
            { "GEAR_Fuse", "Replacement Fuse" },
            { "GEAR_WireBundle", "Wires" },

            // Tools - Weapons
            { "GEAR_Rifle_Barbs", "Barb's Rifle" },
            { "GEAR_Rifle_Curators", "Curator's Rifle" },
            { "GEAR_FlareGun", "Distress Pistol" },
            { "GEAR_ArrowHardened", "Fire Hardened Arrow" },
            { "GEAR_FlareGunAmmoSingle", "Flare Shell" },
            { "GEAR_RevolverGreen", "Forester's Revolver" },
            { "GEAR_RevolverFancy", "Hunter's Revolver" },
            { "GEAR_Rifle", "Hunting Rifle" },
            { "GEAR_NoiseMaker", "Noisemaker" },
            { "GEAR_Revolver", "Revolver" },
            { "GEAR_RevolverAmmoSingle", "Revolver Ammunition (1)" },
            { "GEAR_RevolverAmmoBox", "Revolver Ammunition (10)" },
            { "GEAR_RifleAmmoSingle", "Rifle Ammunition (1)" },
            { "GEAR_RifleAmmoBox", "Rifle Ammunition (5)" },
            { "GEAR_Arrow", "Simple Arrow" },
            { "GEAR_Stone", "Stone" },
            { "GEAR_Bow", "Survival Bow" },
            { "GEAR_Rifle_Vaughns", "Vaughn's Rifle" },
            { "GEAR_RevolverStubNosed", "Warden's Revolver" },
            { "GEAR_Bow_Woodwrights", "Woodwright's Bow" },

            // Tools - Wintermute
            { "GEAR_BearSpear", "Bear Spear" },
            { "GEAR_BearSpearBroken", "Broken Bear Spear" },
            { "GEAR_SpearHead", "Spear Head" },

            // Other items from complete list (basic necessities)
            { "GEAR_AstridBackPack_hangar", "Astrid's Backpack" },
            { "GEAR_AstridBoots", "Astrid's Boots" },
            { "GEAR_AstridGloves", "Astrid's Gloves" },
            { "GEAR_AstridJacket", "Astrid's Jacket" },
            { "GEAR_AstridJeans", "Astrid's Jeans" },
            { "GEAR_AstridSweater", "Astrid's Sweater" },
            { "GEAR_AstridToque", "Astrid's Toque" },
            { "GEAR_WillBoots", "Will's Boots" },
            { "GEAR_WillBootsStart", "Will's Boots (Start)" },
            { "GEAR_WillPants", "Will's Pants" },
            { "GEAR_WillPantsStart", "Will's Pants (Start)" },
            { "GEAR_WillParka", "Will's Parka" },
            { "GEAR_WillParkaHangar", "Will's Parka (Hangar)" },
            { "GEAR_WillParka_Table", "Will's Parka (Table)" },
            { "GEAR_WillParka_Tossed", "Will's Parka (Tossed)" },
            { "GEAR_WillShirt", "Will's Shirt" },
            { "GEAR_WillShirtStart", "Will's Shirt (Start)" },
            { "GEAR_WillSweater", "Will's Sweater" },
            { "GEAR_WillSweaterStart", "Will's Sweater (Start)" },
            { "GEAR_WillToque", "Will's Toque" },
            { "GEAR_NULL", "NULL" }
        };

        /// <summary>
        /// Gets all items grouped by category
        /// </summary>
        public static Dictionary<string, List<KeyValuePair<string, string>>> GetItemsByCategory()
        {
            Dictionary<string, List<KeyValuePair<string, string>>> categories = new Dictionary<string, List<KeyValuePair<string, string>>>
            {
                { "Clothing - Accessories", new List<KeyValuePair<string, string>>() },
                { "Clothing - Gloves", new List<KeyValuePair<string, string>>() },
                { "Clothing - Headgear", new List<KeyValuePair<string, string>>() },
                { "Clothing - Pants", new List<KeyValuePair<string, string>>() },
                { "Clothing - Shirts", new List<KeyValuePair<string, string>>() },
                { "Clothing - Shoes", new List<KeyValuePair<string, string>>() },
                { "Collectibles", new List<KeyValuePair<string, string>>() },
                { "Fire Starting", new List<KeyValuePair<string, string>>() },
                { "First Aid", new List<KeyValuePair<string, string>>() },
                { "Food and Drink", new List<KeyValuePair<string, string>>() },
                { "Materials", new List<KeyValuePair<string, string>>() },
                { "Tools", new List<KeyValuePair<string, string>>() },
                { "Weapons", new List<KeyValuePair<string, string>>() },
                { "Story Items", new List<KeyValuePair<string, string>>() },
                { "Other", new List<KeyValuePair<string, string>>() }
            };

            foreach (var item in Items)
            {
                string key = item.Key;
                string value = item.Value;

                if (key.Contains("GEAR_Clothing") || 
                    key.StartsWith("GEAR_Basic") || 
                    key.EndsWith("Boots") || 
                    key.EndsWith("Gloves") || 
                    key.EndsWith("Mittens") || 
                    key.EndsWith("Hat") || 
                    key.EndsWith("Scarf") || 
                    key.EndsWith("Pants") ||
                    key.EndsWith("Coat") ||
                    key.EndsWith("Vest") ||
                    key.EndsWith("Parka") ||
                    key.EndsWith("Sweater") ||
                    key.EndsWith("Shirt") ||
                    key.EndsWith("Socks") ||
                    key.EndsWith("Toque") ||
                    key.EndsWith("Balaclava"))
                {
                    if (key.Contains("Gloves") || key.Contains("Mittens") || key.Contains("Gauntlets"))
                    {
                        categories["Clothing - Gloves"].Add(item);
                    }
                    else if (key.Contains("Hat") || key.Contains("Toque") || key.Contains("Scarf") || key.Contains("Balaclava") || key.Contains("Cap") || key.Contains("Wrap"))
                    {
                        categories["Clothing - Headgear"].Add(item);
                    }
                    else if (key.Contains("Pants") || key.Contains("Jeans") || key.Contains("Underwear"))
                    {
                        categories["Clothing - Pants"].Add(item);
                    }
                    else if (key.Contains("Boots") || key.Contains("Shoes") || key.Contains("Socks"))
                    {
                        categories["Clothing - Shoes"].Add(item);
                    }
                    else if (key.Contains("EarMuffs") || key.Contains("Crampons") || key.Contains("ToolBelt") || key.Contains("Bag") || key.Contains("Backpack") || key.Contains("Insulation") || key.Contains("Holster") || key.Contains("Scabbard"))
                    {
                        categories["Clothing - Accessories"].Add(item);
                    }
                    else
                    {
                        categories["Clothing - Shirts"].Add(item);
                    }
                }
                else if (key.Contains("Match") || key.Contains("Flare") || key.Contains("Fire") || key.Contains("Coal") || key.Contains("Tinder") || key.Contains("Paper") || key.Contains("Book") || key.Contains("Softwood") || key.Contains("Hardwood") || key.Contains("Stick") || key.Contains("Accelerant"))
                {
                    categories["Fire Starting"].Add(item);
                }
                else if (key.Contains("Bandage") || key.Contains("Stim") || key.Contains("Antibiotics") || key.Contains("Peroxide") || key.Contains("Painkillers") || key.Contains("Prepared") || key.Contains("Pills") || key.Contains("Medical"))
                {
                    categories["First Aid"].Add(item);
                }
                else if (key.Contains("Meat") || key.Contains("Cooked") || key.Contains("Raw") || key.Contains("Carcass") || key.Contains("Food") || key.Contains("MRE") || key.Contains("Water") || key.Contains("Soda") || key.Contains("Tea") || key.Contains("Coffee") || key.Contains("Jerky") || key.Contains("Crackers") || key.Contains("Chips") || key.Contains("Beans") || key.Contains("Sardines") || key.Contains("Can") || key.Contains("Candy") || key.Contains("Bar") || key.Contains("Peaches") || key.Contains("Stew") || key.Contains("Soup") || key.Contains("Venison") || key.Contains("Quarter") || key.Contains("Trout") || key.Contains("Salmon") || key.Contains("Bass") || key.Contains("Acorn") || key.Contains("Carrot") || key.Contains("Potato"))
                {
                    categories["Food and Drink"].Add(item);
                }
                else if (key.Contains("Hide") || key.Contains("Leather") || key.Contains("Pelt") || key.Contains("Sapling") || key.Contains("Cloth") || key.Contains("Gut") || key.Contains("Metal") || key.Contains("Lead") || key.Contains("Rose") || key.Contains("Mushroom") || key.Contains("Feather") || key.Contains("Reishi") || key.Contains("Beard") || key.Contains("Lichen") || key.Contains("Burdock") || key.Contains("Cloth"))
                {
                    categories["Materials"].Add(item);
                }
                else if (key.Contains("Note") || key.Contains("Key") || key.Contains("Letter") || key.Contains("Recipe") || key.Contains("Memento") || key.Contains("Journal") || key.Contains("Code") || key.Contains("PostCard") || key.Contains("ID") || key.Contains("Diary") || key.Contains("Transcript") || key.Contains("Log") || key.Contains("Knowledge"))
                {
                    categories["Collectibles"].Add(item);
                }
                else if (key.Contains("Hacksaw") || key.Contains("Hatchet") || key.Contains("Hammer") || key.Contains("Knife") || key.Contains("Prybar") || key.Contains("Can Opener") || key.Contains("Pot") || key.Contains("Skillet") || key.Contains("Bedroll") || key.Contains("Battery") || key.Contains("Fuse") || key.Contains("Wire") || key.Contains("Tools") || key.Contains("Magnifying") || key.Contains("Lens") || key.Contains("Kit") || key.Contains("Stone") || key.Contains("Line") || key.Contains("Hook") || key.Contains("Tackle") || key.Contains("Fishing") || key.Contains("Lure") || key.Contains("Lamp") || key.Contains("Lantern") || key.Contains("Light") || key.Contains("Rope") || key.Contains("Snare") || key.Contains("Shortwave") || key.Contains("Radio") || key.Contains("Torch") || key.Contains("Spray") || key.Contains("Charcoal") || key.Contains("Elevator") || key.Contains("Crank"))
                {
                    categories["Tools"].Add(item);
                }
                else if (key.Contains("Rifle") || key.Contains("Revolver") || key.Contains("Bow") || key.Contains("Arrow") || key.Contains("Bullet") || key.Contains("Ammo") || key.Contains("Gun") || key.Contains("Spear") || key.Contains("Noise"))
                {
                    categories["Weapons"].Add(item);
                }
                else if (key.Contains("Astrid") || key.Contains("Will") || key.Contains("Jeremiah"))
                {
                    categories["Story Items"].Add(item);
                }
                else
                {
                    categories["Other"].Add(item);
                }
            }

            return categories;
        }

        /// <summary>
        /// Gets display name for item with given ID
        /// </summary>
        public static string GetItemDisplayName(string id)
        {
            if (string.IsNullOrEmpty(id))
                return id;
            
            string name;
            
            // Add special handling for items that might not exist in our dictionary
            if (id.StartsWith("GEAR_Pickup_") || id.StartsWith("GEAR_TreatmentItem_"))
            {
                string[] parts = id.Split('_');
                return string.Join(" ", parts.Skip(1));
            }
            
            if (!Items.TryGetValue(id, out name))
            {
                // For custom items or items not in the dictionary, try to generate a readable name
                if (id.StartsWith("GEAR_"))
                {
                    string rawName = id.Substring(5); // Skip "GEAR_" prefix
                    
                    // Separate camel case words by spaces
                    string formattedName = "";
                    foreach (char c in rawName)
                    {
                        if (char.IsUpper(c) && formattedName.Length > 0)
                            formattedName += " ";
                        formattedName += c;
                    }
                    
                    return formattedName;
                }
                
                return id; // Return the ID if we can't parse it
            }
            
            return name;
        }

        /// <summary>
        /// Gets the gear ID for the given display name
        /// </summary>
        public static string GetItemGearId(string displayName)
        {
            foreach (var item in Items)
            {
                if (item.Value.Equals(displayName, StringComparison.OrdinalIgnoreCase))
                {
                    return item.Key;
                }
            }
            
            return null;
        }
    }
}
