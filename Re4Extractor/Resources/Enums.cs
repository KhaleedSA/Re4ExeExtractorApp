﻿namespace Re4ExeEditor.Resources
{
    public class Enums
    {
        public enum HealingEffects
        {
            MixedHerb = 0x305881,               // Green + Red + Yellow
            Unk0 = 0x30589C,
            WhiteEgg = 0x3058AA,
            BrownEgg = 0x3058C3,
            GoldenEgg_G3_FishL = 0x3058DC,      // Golden Egg, Green x3, Fish(L)
            FirstAid_GR = 0x3058E8,             // First aid spray, Green+Red
            FishS = 0x3058EF,
            Green = 0x3058F6,
            Green2 = 0x3058FD
        }

        /// <summary>
        /// S: Story Mode  ||  M: The Mercenaries Mode  ||  SM: Both Mode.
        /// </summary>
        public enum PlayerHp
        {
            S_Leon = 0x3614D8,
            M_Leon_Wesker = 0x361500,
            Unk1 = 0x361507,
            SM_Ada = 0x36150E,          // AssignMent  
            S_Ada = 0x361536,           // Seprater ways
            Unk2 = 0x361556,
            M_Hunk = 0x361572,
            M_Krauser = 0x361579
        }
        public enum UsefulLocations
        {
            GameVersion = 0x7212FC,
            PlayerHealth = 0x3614D8,
            WeapStats = 0x721A58,
            WeapMaxLvl = 0x721E10,
            ItemsToCombine = 0x721EC8,
            WeapFirePower = 0x7FE518,
            WeapUpgradePrice = 0x8116A8,
            WeapAvailableUp = 0x811950,
            ItemsInStock = 0x811C98,
            ItemsPrice_Leon = 0x812080,
            ItemsPrice_Ada = 0x812398
        }
        public enum ItemID
        {
            Magnum_Ammo,
            Hand_Grenade,
            Incendiary_Grenade,
            Matilda,
            Handgun_Ammo,
            First_Aid_Spray,
            Green_Herb,
            Rifle_Ammo,
            White_Egg,
            Brown_Egg,
            Golden_Egg,
            Aaa1,            // !!!
            Plage_Sample,
            Krauser_Knife,
            Flash_Grenade,
            Salazar_Family_Insignia,
            BowGun,
            BowGun_Bolts,
            Green_HerbX2,
            Green_HerbX3,
            Mixed_Herbs_GR,
            Mixed_Herbs_GRY,
            Mixed_Herbs_GY,
            Rocket_Launcher_SP,
            Shotgun_Ammo,
            Red_Herb,
            HndCannon_Ammo,
            HourGlass_W_GoldDecor,
            Yellow_Herb,
            Stone_Tablet,
            Lion_Ornament,
            Goat_Ornament,
            TMP_Ammo,
            Punisher,
            Punisher_W_Silencer,
            HandGun,
            HandGun_W_Silencer,
            Red9,
            Red9_W_Stock,
            BlackTail,
            BlackTail_W_Silencer,
            Broken_Butterfly,
            Killer7,
            Killer7_W_Silencer,
            ShotGun,
            Striker,
            Rifle,
            Rifle_SemiAuto,
            TMP,
            Activation_Key_Blue,
            TMP_W_Stock,
            Activation_Key_Red,
            Chicago_Typewriter_Inf,
            Rocket_Launcher,
            Mine_Thrower,
            HandCannon,
            Combat_Knife,
            Serpent_Ornament,
            MoonStone_RightHalf,
            Insignia_Key,
            Round_Insignia,
            False_Eye,
            Custom_TMP,
            Silencer_HndGun,
            Silencer_Unknown,
            PRL_412,
            Stock_Red9,
            Stock_TMP,
            Scope_Rifle,
            Scope_SemiAuto,
            Mine_Ammo,
            ShotGun_Unknown,
            Capture_Luis_Sera,
            Target_Practice,
            Luis_Memo1,
            Castellan_Memo,
            Female_instruder,
            Butler_Memo,
            Sample_Retrieved,
            Ritual_Preparation,
            Luis_Memo2,
            Rifle_SemiAuto_W_InfraredScope,
            Krauser_Bow,
            Chicago_TypeWriter_Regular,
            Treasuer_Map_Castle,
            Treasuer_Map_Island,
            Velvet_Blue,
            Spinel,
            Pearl_Pendant,
            Brass_Pocket_Watch,
            Elegant_Headdress,
            Antigue_Pipe,
            Gold_Bangle_W_Pearls,
            Amber_Ring,
            Beerstein,
            Green_CatsEye1,
            Red_CatsEye,
            Yellow_CatsEye,
            Beerstein_G,
            Beerstein_,
            Beerstein_Y,
            Beerstein_GR,
            Beerstein_GY,
            Beerstein_RY,
            Beerstein_GRY,
            Moonstone_LeftHalf,
            Chicago_TypeWriter_Ammo,
            Rifle_Scope,
            Rifle_SemiAuto_Scope,
            Infinite_Launcher,
            King_Grail,
            Queen_Grail,
            Staff_Of_Royalty,
            Gold_Bars,
            Arrows,
            Bonus_Time,
            Emergency_Lock_KeyCard,
            Bonus_Points,
            Green_CatsEye2,
            Ruby,
            Treasure_Box_S,
            Treasure_Box_L,
            Blue_Moonstone,
            Mine_Key,
            Attache_CaseS,
            Attache_CaseM,
            Attache_CaseL,
            Attache_CaseXL,
            Golden_Sword,
            Iron_Key,
            Stone_Of_Scrifice,
            Storage_Room_KeyCard,
            Freezer_Room_KeyCard,
            Item_Panther,
            Item_Serpent,
            Item_Eagle,
            Jet_Ski_Key,
            Dirty_Pearl_Pendant,
            Dirty_Brass_PocketWatch,
            OldKey,
            CampKey,
            Dynamite,
            LiftKey,
            Gold_Bangle,
            Elegant_Perfume_Bottle,
            Mirror_W_PearleRubies,
            Waste_Disposal_KeyCard,
            Elegant_Chessboard,
            RiotGun,
            Black_Bass,
            Hourglass_W_GoldDecor,
            BlackBass_L,
            Illuminados_Pendant,
            Rifle_Infrared_Scope,
            Crown,
            Crown_Jewel,
            Royal_Insignia,
            Crown_Insignia,
            Crown_WithInsignia,
            Salazar_Family_Crown,
            Rifle_Ammo_Infrared,
            Emerald,
            BottleCaps,
            GalleryKey,
            Emblem_RightHalf,
            Emblem_LeftHalf,
            Hexagonal_Emblem,
            Castle_GateKey,
            Mixed_Herb_RY,
            TreasureMap_Village,
            Scope_MineThrower,
            MineThrower_WithScope,
            Playing_Minual1,
            Ashley_Info,
            Playing_Minual2,
            Alert_Order,
            Blue_Medallions_Info,
            Chief_Note,
            Closure_Church,
            Anonymous_Letter,
            Playing_Manual3,
            Third_Party,
            Two_Routes,
            Village_LastDefense,
            ButterflyLamp,
            Green_Eye,
            Red_Eye,
            Blue_Eye,
            ButterflyLamb_G,
            ButterflyLamb_r,
            ButterflyLamb_b,
            ButterflyLamb_GR,
            ButterflyLamb_GB,
            ButterflyLamb_RB,
            ButterflyLamb_RGB,
            PrisonKey,
            PlatinumSword,
            Infrared_Scope,
            Elegant_Mask,
            Green_Gem,
            Red_Gem,
            Purple_Gem,
            Elegant_Mask_G,
            Elegant_Mask_R,
            Elegant_Mask_B,
            Elegant_Mask_GR,
            Elegant_Mask_GB,
            Elegant_Mask_RB,
            Elegant_Mask_GRB,
            Golden_Lynx,
            Green_Stone_OfJudgement,
            Red_Ston_OfFaith,
            Blue_Ston_OfTreason,
            Golden_Lynx_G,
            Golden_Lynx_R,
            Golden_Lynx_B,
            Golden_Lynx_GR,
            Golden_Lynx_GB,
            Golden_Lynx_RB,
            Golden_Lynx_GRB,
            Leon_W_Rocket_Launcher,
            Leon_W_ShotGun,
            Leon_W_HandGun,
            Ashley_Graham,
            Luis_Sera,
            Don_Jose,
            Don_Diego,
            Don_Esteban,
            Don_Manuel,
            Dr_Salvador,
            Merchant,
            Sealot_W_Scythe,
            Sealot_W_Shield,
            Sealot_W_BowGun,
            Leader_Zealot,
            Soldier_W_Dynamite,
            Soldier_W_StunRod,
            Soldier_W_Hammer,
            Isable,
            Maria,
            Ada_Wong,
            Bellla_Sisters,
            Don_Pedro,
            J_J,
            Ada_Letter,
            Luis_Memo3,
            Paper_AirPlane,
            Our_Plan,
            Luis_Memo4,
            Krauser_Note,
            Luis_Memo5,
            Our_Mission,
            Aaa2,               // !!!
            Aaa3,               // !!!
            Tactical_Vest,
            Aaa4,
            Punisher_Unknown2,
            HandGun_Unknown2,
            ShotGun_Unknown2,
            Mine_Thrower_Unknown,
            HandCannon_Unknown,
            MineThrower_WithScope_Unknown,
            Mission_Directives1,
            Mission_Directives2,
            Mission_Directives3,
            Mission_Directives4,
            Mission_Directives5,
            Mission_Treasure_Map1,
            Mission_Treasure_Map2,
            Mission_Treasure_Map3,
            Mission_Treasure_Map4,
            Mission_Treasure_Map5,
            DummyID = 65535
        }
        public enum AmmoID
        {
            Magnum = 0x00,
            HandGun = 0x04,
            Rifle = 0x07,
            BowGun = 0x11,
            ShotGun = 0x18,
            HandCannon = 0x1A,
            TMP = 0x20,
            Mine = 0x46,
            Chicago = 0x6A,
            Krauser_Bow = 0x72,
            Null = 0xFF
        }
        public enum WeaponID
        {
            Hand_Grenade = 0x01,
            Incendiary_Grenade = 0x02,
            Matilda = 0x03,
            White_Egg = 0x08,
            Brown_Egg = 0x09,
            Golden_Egg = 0x0A,
            Flash_Grenade = 0x0E,
            BowGun = 0x10,
            Rocket_Launcher_SP = 0x17,
            Punisher = 0x21,
            HandGun = 0x23,
            HandGun_W_Silencer = 0x24,
            Red9 = 0x25,
            Red9_W_Stock = 0x26,
            BlackTail = 0x27,
            BlackTail_W_Silencer = 0x28,
            Broken_Butterfly = 0x29,
            Killer7 = 0x2A,
            ShotGun = 0x2C,
            Striker = 0x2D,
            Rifle = 0x2E,
            Rifle_SemiAuto = 0x2F,
            TMP = 0x30,
            TMP_W_Stock = 0x32,
            Chicago_Typewriter_Inf = 0x34,
            Rocket_Launcher = 0x35,
            Mine_Thrower = 0x36,
            HandCannon = 0x37,
            Combat_Knife = 0x38,
            Custom_TMP = 0x3E,
            Silencer_Unknown = 0x40,
            PRL_412 = 0x41,
            ShotGun_Unknown = 0x47,
            Rifle_SemiAuto_W_InfraredScope = 0x51,
            Krauser_Bow = 0x52,
            Chicago_TypeWriter_Regular = 0x53,
            Rifle_Scope = 0x6B,
            Rifle_SemiAuto_Scope = 0x6C,
            Infinite_Launcher = 0x6D,
            RiotGun = 0x94,
            Rifle_Infrared_Scope = 0x99,
            MineThrower_WithScope = 0xAB,
            Unknown = 2048
        }
        public enum CustomFPLocation
        {
            Punisher = 0x7FE534,
            HandGun = 0x7FE550,
            Red9 = 0x7FE56C,
            BlackTail = 0x7FE588,
            Broken_Butterfly = 0x7FE5A4,
            Killer7 = 0x7FE5C0,
            ShotGun = 0x7FE5DC,
            Striker = 0x7FE5F8,
            Rifle = 0x7FE614,
            Rifle_SemiAuto = 0x7FE630,
            TMP = 0x7FE64C,
            Chicago_TypeWriter = 0x7FE668,
            HandCannon = 0x7FE6BC,
            Knife = 0x7FE6D8,
            Matilda = 0x7FE6F4,
            Krauser_Bow = 0x7FE828,
            RiotGun = 0x7FE8B4,
            BowGun = 0x7FEA58,
        }
        public enum AmmoStackLocation
        {
            Unknown0 = 0x3041D8,
            AllExplosives = 0x3041E4,
            HandGun = 0x3041F0,
            Magnum = 0x30421C,
            ShotGun = 0x304264,
            Rifle = 0x3042B2,
            Chicago = 0x3042DB,
            TMP = 0x304307,
            HandCannon = 0x304333,
            Mine = 0x30437B,
            BowGun = 0x3043A3,
            Arrows = 0x3043CF,
            AllHealing = 0x304407,
            Unknown1 = 0x30442B,
            Unknown2 = 0x30444F,
            Unknown3 = 0x30445B,
            Unknown4 = 0x304467,
            Unknown5 = 0x304473,
            Unknown6 = 0x30447F
        }
    }
}
