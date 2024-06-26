﻿using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace LogicProject
{
    public static class World
    {
        public static List<Location> Locations = new List<Location>();
        public static List<Item> Items = new List<Item>();
        public static List<Monster> Monsters = new List<Monster>();
        public static List<Quest> Quests = new List<Quest>();
        public static List<QuestType> QuestTypes;
        public static List<Skill> Skills = new List<Skill>();
        public static List<SkillType> skillTypes;
        //
        //Location ID
        //
        public const int LOCATION_ID_HOME = 1;
        public const int LOCATION_ID_HEROES_VILLAGE = 2;
        public const int LOCATION_ID_GOLDEN_LEAP_FOREST = 3;
        public const int LOCATION_ID_PINE_FOREST = 4;
        public const int LOCATION_ID_SCREAM_FOREST = 5;
        public const int LOCATION_ID_DRAGON_GRAVE = 6;
        public const int LOCATION_ID_WOLF_PLACE = 7;
        public const int LOCATION_ID_AURORA_HILL = 8;
        public const int LOCATION_ID_RUINS_OF_THE_ARCANE_CITY = 9;
        public const int LOCATION_ID_MEMORIAL_STELE = 10;
        public const int LOCATION_ID_MILLENIMUM_MOUNTAIN = 11;
        public const int LOCATION_ID_CHAOS_GATE = 12;
        public const int LOCATION_ID_KAIJU_CITY = 13;
        public const int LOCATION_ID_WAVE_OCEAN = 14;
        public const int LOCATION_ID_FOREST_OF_FOG = 15;
        public const int LOCATION_ID_TWILIGHT_HILL = 16;
        public const int LOCATION_ID_DEMON_CASTLE = 17;
        public const int LOCATION_ID_PURGATORY_MOUTAIN = 18;
        public const int LOCATION_ID_TOWER_OF_DARKNESS = 19;
        //
        //Item ID
        //
        public const int ITEM_ID_SNAKE_POISON = 1;
        public const int ITEM_ID_SNAKE_LEATHER = 2;
        public const int ITEM_ID_UNDEAD_EYE = 3;
        public const int ITEM_ID_GHOST_TEAR = 4;
        public const int ITEM_ID_GHOST_SCREAM = 5;
        public const int ITEM_ID_SKELETON_BONE = 6;
        public const int ITEM_ID_SPIDER_EYE = 7;
        public const int ITEM_ID_SPIDER_SILK = 8;
        public const int ITEM_ID_WOLF_FANG = 9;
        public const int ITEM_ID_WOLF_FUR = 10;
        public const int ITEM_ID_WOLF_FLESH = 11;
        public const int ITEM_ID_TIGER_LEATHER = 12;
        public const int ITEM_ID_TIGER_FANG = 13;
        public const int ITEM_ID_LION_FUR = 14;
        public const int ITEM_ID_LION_FANG = 15;
        public const int ITEM_ID_BROKEN_ARMOR = 16;
        public const int ITEM_ID_BROKEN_SWORD = 17;
        public const int ITEM_ID_KNIGHT_CERTIFICATION = 18;
        public const int ITEM_ID_TORN_ROBE = 19;
        public const int ITEM_ID_ROTTEN_WOODEN_WAND = 20;
        public const int ITEM_ID_DRAGON_BONE = 21;
        public const int ITEM_ID_DRAGON_FANG = 22;
        public const int ITEM_ID_DRAZARD_LEATHER = 23;
        public const int ITEM_ID_DRAZARD_EYE = 24;
        public const int ITEM_ID_PHANTOM_WING = 25;
        public const int ITEM_ID_DEATH_FRAGMENT = 26;
        public const int ITEM_ID_GIANT_BONE = 27;
        public const int ITEM_ID_GIANT_ESSENCE = 28;
        public const int ITEM_ID_FLAME_DRAGON_EYE = 29;
        public const int ITEM_ID_SIREN_SCALE = 30;
        public const int ITEM_ID_MERMAID_VOICE = 31;
        public const int ITEM_ID_VOID_FRAGMENT = 32;
        public const int ITEM_ID_TWILIGHT_FEATHER = 33;
        public const int ITEM_ID_TWILIGHT_WING = 34;
        public const int ITEM_ID_DEMON_HORN = 35;
        public const int ITEM_ID_ANGEL_WING = 36;
        public const int ITEM_ID_ANGEL_EYE = 37;
        public const int ITEM_ID_REAPER_SCYTHE = 38;
        public const int ITEM_ID_DEMON_KING_CROWN = 39;
        //Weapon ID
        public const int ITEM_ID_WEAPON_IRON_SWORD = 40;
        public const int ITEM_ID_WEAPON_STEEL_SWORD = 41;
        public const int ITEM_ID_WEAPON_WOOD_BOW = 42;
        public const int ITEM_ID_WEAPON_IRON_BOW = 43;
        public const int ITEM_ID_WEAPON_FLAME_BLADE = 44;
        public const int ITEM_ID_WEAPON_ICE_BLADE = 45;
        public const int ITEM_ID_WEAPON_FIRECROSS_BLADE = 46;
        public const int ITEM_ID_WEAPON_SAINT_SPEAR = 47;
        public const int ITEM_ID_WEAPON_ANGEL_SPEAR = 48;
        public const int ITEM_ID_WEAPON_DARK_HARVEST = 49;
        public const int ITEM_ID_WEAPON_MAGIC_RUBY_SWORD = 50;
        public const int ITEM_ID_WEAPON_MAGIC_FLAMINUM_SWORD = 51;
        public const int ITEM_ID_WEAPON_MAGIC_SAINIUM_SWORD = 52;
        public const int ITEM_ID_WEAPON_DEATH_DECIDENT = 53;
        public const int ITEM_ID_WEAPON_DRAGON_CLAW = 54;
        public const int ITEM_ID_WEAPON_LEGEND_WAND = 55;
        public const int ITEM_ID_WEAPON_DEMON_DAGGER = 56;
        public const int ITEM_ID_WEAPON_KING_GREAT_SWORD = 57;
        public const int ITEM_ID_WEAPON_LAST_HOPE = 58;
        //Potion ID
        public const int ITEM_ID_POTION_TINY_HEALING = 59;
        public const int ITEM_ID_POTION_TINY_MANA = 60;
        public const int ITEM_ID_POTION_TINY_POTION = 61;
        public const int ITEM_ID_POTION_SMALL_HEALING = 62;
        public const int ITEM_ID_POTION_SMALL_MANA = 63;
        public const int ITEM_ID_POTION_SMALL_POTION = 64;
        public const int ITEM_ID_POTION_MEDIUM_HEALING = 65;
        public const int ITEM_ID_POTION_MEDIUM_MANA = 66;
        public const int ITEM_ID_POTION_MEDIUM_POTION = 67;
        public const int ITEM_ID_POTION_BIG_HEALING = 68;
        public const int ITEM_ID_POTION_BIG_MANA = 69;
        public const int ITEM_ID_POTION_BIG_POTION = 70;
        public const int ITEM_ID_POTION_GREAT_HEALING = 71;
        public const int ITEM_ID_POTION_GREAT_MANA = 72;
        public const int ITEM_ID_POTION_GREAT_POTION = 73;
        public const int ITEM_ID_POTION_MAGIC_POTION = 74;
        //
        //Monster ID
        //
        public const int MONSTER_ID_SNAKE = 1;
        public const int MONSTER_ID_SPIDER = 2;
        public const int MONSTER_ID_UNDEAD = 3;
        public const int MONSTER_ID_GHOST = 4;
        public const int MONSTER_ID_SKELETON = 5;
        public const int MONSTER_ID_WOLF = 6;
        public const int MONSTER_ID_TIGER = 7;
        public const int MONSTER_ID_LION = 8;
        public const int MONSTER_ID_BONE_DRAGON = 9;
        public const int MONSTER_ID_UNDEAD_KNIGHT = 10;
        public const int MONSTER_ID_UNDEAD_MAGICIAN = 11;
        public const int MONSTER_ID_DRAZARD = 12;
        public const int MONSTER_ID_PHANTOM = 13;
        public const int MONSTER_ID_GREAT_DRAZARD = 14;
        public const int MONSTER_ID_DEATH_DRAZARD = 15;
        public const int MONSTER_ID_GIANT = 16;
        public const int MONSTER_ID_FLAME_DRAGON = 17;
        public const int MONSTER_ID_SIREN = 18;
        public const int MONSTER_ID_DARK_MERMAID = 19;
        public const int MONSTER_ID_VOID_GHOST = 20;
        public const int MONSTER_ID_TWILIGHT_TALON = 21;
        public const int MONSTER_ID_DEMON = 22;
        public const int MONSTER_ID_GREAT_DEMON = 23;
        public const int MONSTER_ID_FALLEN_ANGEL = 24;
        public const int MONSTER_ID_KILLER_REAPER = 25;
        public const int MONSTER_ID_DEMON_KING = 26;
        //
        //Quest ID
        //
        //Type 1
        public const int QUEST_ID_ADVENTURE_GO_TO_VILLAGE = 1;
        public const int QUEST_ID_ADVENTURE_GO_TO_STELE = 2;
        public const int QUEST_ID_ADVENTURE_DO_YOU_SEE_WOLF = 8;
        public const int QUEST_ID_ADVENTURE_THE_CAVE = 15;
        public const int QUEST_ID_ADVENTURE_GO_TO_WAVE = 19;
        public const int QUEST_ID_ADVENTURE_GO_TO_VOLCANO = 22;
        public const int QUEST_ID_ADVENTURE_THE_TOWER = 25;
        //Type 2
        public const int QUEST_ID_BATTLE_KILL_SNAKE = 3;
        public const int QUEST_ID_BATTLE_KILL_GHOST = 4;
        public const int QUEST_ID_BATTLE_TALK_TO_WOLF = 9;
        public const int QUEST_ID_BATTLE_LION_ROAR = 10;
        public const int QUEST_ID_BATTLE_KNIGHT_NOT_DIED = 12;
        public const int QUEST_ID_BATTLE_IT_IS_DRAGON = 14;
        public const int QUEST_ID_BATTLE_NEW_CHALLENGE = 21;
        public const int QUEST_ID_BATTLE_DEMON_SUPER = 23;
        public const int QUEST_ID_BATTLE_REAPER_IS_HERE = 24;
        //Type 3
        public const int QUEST_ID_COLLECT_UNDEAD_EYE = 5;
        public const int QUEST_ID_COLLECT_SPIDER_SILK = 6;
        public const int QUEST_ID_COLLECT_LEATHER_AND_SILK = 7;
        public const int QUEST_ID_COLLECT_KNIGHT_AND_MAGICIAN = 11;
        public const int QUEST_ID_COLLECT_I_AM_KNIGHT = 13;
        public const int QUEST_ID_COLLECT_WING_AND_ESSENCE = 16;
        public const int QUEST_ID_COLLECT_DRAGON_AGAIN = 17;
        public const int QUEST_ID_COLLECT_FLAME_EYE = 18;
        public const int QUEST_ID_COLLECT_DEEP_OCEAN = 20;
        //
        //Skill ID
        //
        //Type 1
        public const int SKILL_ID_ATTACK_QUA_CAU_LUA = 1;
        public const int SKILL_ID_ATTACK_THANH_THUONG = 2;
        public const int SKILL_ID_ATTACK_COT_LUA = 3;
        public const int SKILL_ID_ATTACK_LUYEN_NGUC = 4;
        //Type 2
        public const int SKILL_ID_DEFENSE_PHONG_HO_TUYET_DOI = 5;
        public const int SKILL_ID_DEFENSE_GIAO_AO = 6;
        //Type 3
        public const int SKILL_ID_BUFF_CUONG_HOA_SAT_THUONG = 7;
        public const int SKILL_ID_BUFF_SIEU_CUONG_HOA = 8;
        public const int SKILL_ID_BUFF_CUONG_HOA_MP = 9;
        //Type 4
        public const int SKILL_ID_HEAL_TRI_LIEU = 10;
        public const int SKILL_ID_HEAL_HOI_NANG_LUONG = 11;
        public const int SKILL_ID_HEAL_HOI_PHUC_NHANH = 12;
        public const int SKILL_ID_HEAL_SIEU_CAP_HOI_PHUC = 13;
        //Type 5
        public const int SKILL_ID_DEBUFF_NGUYEN_RUA = 14;
        public const int SKILL_ID_DEBUFF_NGUYEN_RUA_NANG_CAO = 15;
        public const int SKILL_ID_DEBUFF_NGUYEN_RUA_SIEU_CAP = 16;
        //
        static World()
        {
            PopulateTypeQuest();
            PopulateTypeSkill();
            PopulateItem();
            PopulateSkill();
            PopulateMonster();
            PopulateQuest();
            PopulateLocation();
        }

        static void PopulateTypeQuest()
        {
            QuestTypes = new List<QuestType>()
            {
                new QuestType(1, "Adventure"),
                new QuestType(2, "Battle"),
                new QuestType(3, "Collection")
            };
        }
        static void PopulateTypeSkill()
        {
            skillTypes = new List<SkillType>()
            {
                new SkillType(1, "Attack"),
                new SkillType(2, "Defense"),
                new SkillType(3, "Buff"),
                new SkillType(4, "Healing"),
                new SkillType(5, "Debuff")
            };
        }
        static void PopulateLocation()
        {
            /*
             * new Location(..)
             * Quest, Monster, Treasure
             * East, ....
             */
            AddNewLocation(
                new Location(LOCATION_ID_HOME, "Home", "Where you begin your journey!"),
                new List<Quest>
                {
                    QuestByID(QUEST_ID_ADVENTURE_GO_TO_VILLAGE)
                },
                null,
                new List<Treasure>
                {
                    CreateTreasure(
                        new Treasure(0),
                        new List<TreasureItem>
                        {
                            new TreasureItem(ItemByID(ITEM_ID_WEAPON_IRON_SWORD), 1),
                            new TreasureItem(ItemByID(ITEM_ID_POTION_TINY_HEALING), 10),
                            new TreasureItem(ItemByID(ITEM_ID_POTION_TINY_MANA), 10),
                            new TreasureItem(ItemByID(ITEM_ID_POTION_TINY_POTION), 3)
                        }
                    )
                }
            );
            AddNewLocation(
                new Location(LOCATION_ID_PINE_FOREST, "Pine Forest", "Pine Forest"),
                new List<Quest>
                {
                    QuestByID(QUEST_ID_ADVENTURE_DO_YOU_SEE_WOLF),
                    QuestByID(QUEST_ID_COLLECT_LEATHER_AND_SILK)
                },
                new List<MonsterSpawn>
                {
                    new MonsterSpawn(MonsterByID(MONSTER_ID_SNAKE), 3),
                    new MonsterSpawn(MonsterByID(MONSTER_ID_SPIDER), 4)
                },
                new List<Treasure>
                {
                    CreateTreasure(
                        new Treasure(50),
                        new List<TreasureItem>
                        {
                            new TreasureItem(ItemByID(ITEM_ID_POTION_TINY_HEALING), 10),
                            new TreasureItem(ItemByID(ITEM_ID_POTION_TINY_MANA), 10),
                            new TreasureItem(ItemByID(ITEM_ID_POTION_TINY_POTION), 5)
                        }
                    )
                }
            );
            AddNewLocation(
                new Location(LOCATION_ID_HEROES_VILLAGE, "Heroes Village", "The village of legends!", 1),
                new List<Quest>
                {
                    QuestByID(QUEST_ID_ADVENTURE_GO_TO_STELE),
                    QuestByID(QUEST_ID_BATTLE_KILL_SNAKE),
                    QuestByID(QUEST_ID_BATTLE_KILL_GHOST),
                    QuestByID(QUEST_ID_COLLECT_UNDEAD_EYE),
                    QuestByID(QUEST_ID_COLLECT_SPIDER_SILK),
                },
                null,
                null
            );
            AddNewLocation(
                new Location(LOCATION_ID_GOLDEN_LEAP_FOREST, "Golden Leap Forest", "Gold but not gold!", 1),
                null,
                new List<MonsterSpawn>
                {
                    new MonsterSpawn(MonsterByID(MONSTER_ID_SNAKE), 2),
                    new MonsterSpawn(MonsterByID(MONSTER_ID_UNDEAD), 1)
                },
                new List<Treasure>
                {
                    CreateTreasure(
                        new Treasure(50),
                        new List<TreasureItem>
                        {
                            new TreasureItem(ItemByID(ITEM_ID_POTION_TINY_HEALING), 10),
                            new TreasureItem(ItemByID(ITEM_ID_POTION_TINY_MANA), 10),
                            new TreasureItem(ItemByID(ITEM_ID_POTION_TINY_POTION), 5)
                        }
                    )
                }
            );
            AddNewLocation(
                new Location(LOCATION_ID_SCREAM_FOREST, "Scream Forest", "Do you hear that?", 15),
                null,
                new List<MonsterSpawn>
                {
                    new MonsterSpawn(MonsterByID(MONSTER_ID_GHOST), 4),
                    new MonsterSpawn(MonsterByID(MONSTER_ID_SKELETON), 2)
                },
                new List<Treasure>
                {
                    CreateTreasure(
                        new Treasure(80),
                        new List<TreasureItem>
                        {
                            new TreasureItem(ItemByID(ITEM_ID_WEAPON_WOOD_BOW), 1),
                            new TreasureItem(ItemByID(ITEM_ID_POTION_TINY_HEALING), 20),
                            new TreasureItem(ItemByID(ITEM_ID_POTION_TINY_MANA), 20),
                            new TreasureItem(ItemByID(ITEM_ID_POTION_TINY_POTION), 10)
                        }
                    ),
                    CreateTreasure(
                        new Treasure(80),
                        new List<TreasureItem>
                        {
                            new TreasureItem(ItemByID(ITEM_ID_WEAPON_STEEL_SWORD), 1),
                            new TreasureItem(ItemByID(ITEM_ID_POTION_SMALL_HEALING), 5)
                        }
                    )
                }
            );
            AddNewLocation(
                new Location(LOCATION_ID_DRAGON_GRAVE, "Dragon Grave", "Have you already known about the dragon? The last time of me was a long time ago.", 50),
                new List<Quest>
                {
                    QuestByID(QUEST_ID_BATTLE_IT_IS_DRAGON)
                },
                new List<MonsterSpawn>
                {
                    new MonsterSpawn(MonsterByID(MONSTER_ID_BONE_DRAGON), 3)
                },
                new List<Treasure>
                {
                    CreateTreasure(
                        new Treasure(300),
                        new List<TreasureItem>
                        {
                            new TreasureItem(ItemByID(ITEM_ID_WEAPON_ICE_BLADE),1),
                            new TreasureItem(ItemByID(ITEM_ID_POTION_MEDIUM_HEALING),10),
                            new TreasureItem(ItemByID(ITEM_ID_POTION_MEDIUM_MANA),10),
                            new TreasureItem(ItemByID(ITEM_ID_POTION_MEDIUM_POTION),5)
                        }
                    ),
                    CreateTreasure(
                        new Treasure(300),
                        new List<TreasureItem>
                        {
                            new TreasureItem(ItemByID(ITEM_ID_POTION_MEDIUM_HEALING),20),
                            new TreasureItem(ItemByID(ITEM_ID_WEAPON_FLAME_BLADE),1)
                        }
                    ),
                    CreateTreasure(
                        new Treasure(300),
                        new List<TreasureItem>
                        {
                            new TreasureItem(ItemByID(ITEM_ID_POTION_BIG_HEALING),5)
                        }
                    )
                }
            );
            AddNewLocation(
                new Location(LOCATION_ID_WOLF_PLACE, "Wolf Place", "Wolf, a dog or a wild beast", 15),
                new List<Quest>
                {
                    QuestByID(QUEST_ID_BATTLE_TALK_TO_WOLF)
                },
                new List<MonsterSpawn>
                {
                    new MonsterSpawn(MonsterByID(MONSTER_ID_WOLF), 4)
                },
                new List<Treasure>
                {
                    CreateTreasure(
                        new Treasure(80),
                        new List<TreasureItem>
                        {
                            new TreasureItem(ItemByID(ITEM_ID_WEAPON_IRON_SWORD),1),
                            new TreasureItem(ItemByID(ITEM_ID_POTION_SMALL_HEALING),5),
                            new TreasureItem(ItemByID(ITEM_ID_POTION_SMALL_MANA),5)
                        }
                    ),
                    CreateTreasure(
                        new Treasure(80),
                        new List<TreasureItem>
                        {
                            new TreasureItem(ItemByID(ITEM_ID_WEAPON_STEEL_SWORD),1),
                            new TreasureItem(ItemByID(ITEM_ID_POTION_SMALL_POTION),5)
                        }
                    )
                }
            );
            AddNewLocation(
                new Location(LOCATION_ID_AURORA_HILL, "Aurora Hill", "Beautiful scene at night, but danger in the daytime", 25),
                new List<Quest>
                {
                    QuestByID(QUEST_ID_BATTLE_LION_ROAR)
                },
                new List<MonsterSpawn>
                {
                    new MonsterSpawn(MonsterByID(MONSTER_ID_LION), 4),
                    new MonsterSpawn(MonsterByID(MONSTER_ID_TIGER), 5),
                },
                new List<Treasure>
                {
                    CreateTreasure(
                        new Treasure(100),
                        new List<TreasureItem>
                        {
                            new TreasureItem(ItemByID(ITEM_ID_WEAPON_IRON_BOW),1)
                        }
                    ),
                    CreateTreasure(
                        new Treasure(100),
                        new List<TreasureItem>
                        {
                            new TreasureItem(ItemByID(ITEM_ID_POTION_SMALL_HEALING),10),
                            new TreasureItem(ItemByID(ITEM_ID_POTION_TINY_MANA),10),
                        }
                    ),
                    CreateTreasure(
                        new Treasure(100),
                        new List<TreasureItem>
                        {
                            new TreasureItem(ItemByID(ITEM_ID_WEAPON_STEEL_SWORD),1),
                            new TreasureItem(ItemByID(ITEM_ID_POTION_SMALL_POTION),5),
                        }
                    )
                }
            );
            AddNewLocation(
                new Location(LOCATION_ID_RUINS_OF_THE_ARCANE_CITY, "Ruins of the Arcane city", "A legend is never died!", 35),
                new List<Quest>
                {
                    QuestByID(QUEST_ID_BATTLE_KNIGHT_NOT_DIED),
                    QuestByID(QUEST_ID_COLLECT_KNIGHT_AND_MAGICIAN),
                    QuestByID(QUEST_ID_COLLECT_I_AM_KNIGHT)
                },
                new List<MonsterSpawn>
                {
                    new MonsterSpawn(MonsterByID(MONSTER_ID_UNDEAD_KNIGHT), 6),
                    new MonsterSpawn(MonsterByID(MONSTER_ID_UNDEAD_MAGICIAN), 3)
                },
                new List<Treasure>
                {
                    CreateTreasure(
                        new Treasure(150),
                        new List<TreasureItem>
                        {
                            new TreasureItem(ItemByID(ITEM_ID_WEAPON_FLAME_BLADE),1),
                        }
                    ),
                    CreateTreasure(
                        new Treasure(150),
                        new List<TreasureItem>
                        {
                            new TreasureItem(ItemByID(ITEM_ID_POTION_SMALL_HEALING),20),
                            new TreasureItem(ItemByID(ITEM_ID_POTION_SMALL_MANA),20),
                        }
                    ),
                    CreateTreasure(
                        new Treasure(150),
                        new List<TreasureItem>
                        {
                            new TreasureItem(ItemByID(ITEM_ID_POTION_SMALL_MANA),50),
                        }
                    ),
                    CreateTreasure(
                        new Treasure(150),
                        new List<TreasureItem>
                        {
                            new TreasureItem(ItemByID(ITEM_ID_KNIGHT_CERTIFICATION),5),
                            new TreasureItem(ItemByID(ITEM_ID_ROTTEN_WOODEN_WAND),3),
                        }
                    ),
                    CreateTreasure(
                        new Treasure(150),
                        new List<TreasureItem>
                        {
                            new TreasureItem(ItemByID(ITEM_ID_POTION_MEDIUM_HEALING),5),
                            new TreasureItem(ItemByID(ITEM_ID_POTION_SMALL_POTION),10),
                        }
                    ),
                }
            );
            AddNewLocation(
                new Location(LOCATION_ID_MEMORIAL_STELE, "Memorial stele", "They will be immortal as long as we remember them.", 35),
                new List<Quest>
                {
                    QuestByID(QUEST_ID_ADVENTURE_THE_CAVE),
                    QuestByID(QUEST_ID_COLLECT_WING_AND_ESSENCE)
                },
                null,
                new List<Treasure>
                {
                    CreateTreasure(
                        new Treasure(500),
                        new List<TreasureItem>
                        {
                            new TreasureItem(ItemByID(ITEM_ID_POTION_BIG_HEALING),10),      
                            new TreasureItem(ItemByID(ITEM_ID_WEAPON_SAINT_SPEAR),1),
                        }
                    ),
                    CreateTreasure(
                        new Treasure(500),
                        new List<TreasureItem>
                        {
                            new TreasureItem(ItemByID(ITEM_ID_POTION_BIG_HEALING),20),
                        }
                    ),
                    CreateTreasure(
                        new Treasure(500),
                        new List<TreasureItem>
                        {
                            new TreasureItem(ItemByID(ITEM_ID_POTION_BIG_POTION),10),
                        }
                    ),
                }
            );
            AddNewLocation(
                new Location(LOCATION_ID_MILLENIMUM_MOUNTAIN, "Millenimum Mountain", "The moutain exists during a million year or more!", 50),
                null,
                new List<MonsterSpawn>
                {
                    new MonsterSpawn(MonsterByID(MONSTER_ID_DRAZARD), 5),
                    new MonsterSpawn(MonsterByID(MONSTER_ID_PHANTOM), 4),
                },
                new List<Treasure>
                {
                    CreateTreasure(
                        new Treasure(700),
                        new List<TreasureItem>
                        {
                            new TreasureItem(ItemByID(ITEM_ID_WEAPON_FLAME_BLADE),1),       
                            new TreasureItem(ItemByID(ITEM_ID_POTION_MEDIUM_HEALING),50),       
                            new TreasureItem(ItemByID(ITEM_ID_POTION_MEDIUM_MANA),50),
                        }
                    ),
                    CreateTreasure(
                        new Treasure(700),
                        new List<TreasureItem>
                        {
                            new TreasureItem(ItemByID(ITEM_ID_WEAPON_ICE_BLADE),1),     
                            new TreasureItem(ItemByID(ITEM_ID_POTION_MEDIUM_POTION),30),
                        }
                    ),
                    CreateTreasure(
                        new Treasure(700),
                        new List<TreasureItem>
                        {
                            new TreasureItem(ItemByID(ITEM_ID_POTION_BIG_HEALING),70),      
                            new TreasureItem(ItemByID(ITEM_ID_POTION_MEDIUM_POTION),70),
                        }
                    ),
                    CreateTreasure(
                        new Treasure(700),
                        new List<TreasureItem>
                        {
                            new TreasureItem(ItemByID(ITEM_ID_POTION_BIG_MANA),70),
                        }
                    ),
                }
            );
            AddNewLocation(
                new Location(LOCATION_ID_CHAOS_GATE, "Chaos Gate", "Mystery place, be careful, traveller!", 75),
                new List<Quest>
                {
                    QuestByID(QUEST_ID_COLLECT_DRAGON_AGAIN)
                },
                new List<MonsterSpawn>
                {
                    new MonsterSpawn(MonsterByID(MONSTER_ID_GREAT_DRAZARD), 2),
                    new MonsterSpawn(MonsterByID(MONSTER_ID_DEATH_DRAZARD), 1)
                },
                new List<Treasure>
                {
                    CreateTreasure(
                        new Treasure(1000),
                        new List<TreasureItem>
                        {
                            new TreasureItem(ItemByID(ITEM_ID_WEAPON_ANGEL_SPEAR),1),       
                            new TreasureItem(ItemByID(ITEM_ID_POTION_BIG_HEALING),50),      
                            new TreasureItem(ItemByID(ITEM_ID_POTION_BIG_MANA),50),
                        }
                    )
                }
            );
            AddNewLocation(
                new Location(LOCATION_ID_KAIJU_CITY, "Kaiju City", "Danger for human, everyone say that. But it's true!", 90),
                new List<Quest>
                {
                    QuestByID(QUEST_ID_COLLECT_FLAME_EYE)
                },
                new List<MonsterSpawn>
                {
                    new MonsterSpawn(MonsterByID(MONSTER_ID_GIANT), 3),
                    new MonsterSpawn(MonsterByID(MONSTER_ID_FLAME_DRAGON), 2)
                },
                new List<Treasure>
                {
                    CreateTreasure(
                        new Treasure(800),
                        new List<TreasureItem>
                        {
                            new TreasureItem(ItemByID(ITEM_ID_WEAPON_DARK_HARVEST),1),      
                            new TreasureItem(ItemByID(ITEM_ID_POTION_BIG_HEALING),80),      
                            new TreasureItem(ItemByID(ITEM_ID_POTION_BIG_MANA),80),     
                            new TreasureItem(ItemByID(ITEM_ID_POTION_BIG_POTION),60),
                        }
                    ),
                    CreateTreasure(
                        new Treasure(800),
                        new List<TreasureItem>
                        {
                            new TreasureItem(ItemByID(ITEM_ID_POTION_BIG_HEALING),80),      
                            new TreasureItem(ItemByID(ITEM_ID_POTION_BIG_MANA),80),
                        }
                    ),
                    CreateTreasure(
                        new Treasure(800),
                        new List<TreasureItem>
                        {
                            new TreasureItem(ItemByID(ITEM_ID_POTION_GREAT_HEALING),50),
                        }
                    )
                }
            );
            AddNewLocation(
                new Location(LOCATION_ID_WAVE_OCEAN, "Wave Ocean", "Do you want to know what poetry is? Come here!", 90),
                null,
                new List<MonsterSpawn>
                {
                    new MonsterSpawn(MonsterByID(MONSTER_ID_SIREN), 5),
                    new MonsterSpawn(MonsterByID(MONSTER_ID_DARK_MERMAID), 4)
                },
                new List<Treasure>
                {
                    CreateTreasure(
                        new Treasure(1500),
                        new List<TreasureItem>
                        {
                            new TreasureItem(ItemByID(ITEM_ID_WEAPON_MAGIC_RUBY_SWORD),1),      
                            new TreasureItem(ItemByID(ITEM_ID_POTION_BIG_HEALING),100),
                        }
                    ),
                    CreateTreasure(
                        new Treasure(1500),
                        new List<TreasureItem>
                        {
                            new TreasureItem(ItemByID(ITEM_ID_POTION_BIG_MANA),100),        
                            new TreasureItem(ItemByID(ITEM_ID_POTION_GREAT_HEALING),50),
                        }
                    ),
                    CreateTreasure(
                        new Treasure(1500),
                        new List<TreasureItem>
                        {
                            new TreasureItem(ItemByID(ITEM_ID_POTION_GREAT_MANA),50),
                        }
                    ),
                    CreateTreasure(
                        new Treasure(1500),
                        new List<TreasureItem>
                        {
                            new TreasureItem(ItemByID(ITEM_ID_POTION_GREAT_POTION),25),
                        }
                    ),
                }
            );
            AddNewLocation(
                new Location(LOCATION_ID_FOREST_OF_FOG, "Forest of Fog", "The more dangerous Scream Forest!", 100),
                new List<Quest>
                {
                    QuestByID(QUEST_ID_ADVENTURE_GO_TO_WAVE),
                    QuestByID(QUEST_ID_COLLECT_DEEP_OCEAN)
                },
                new List<MonsterSpawn>
                {
                    new MonsterSpawn(MonsterByID(MONSTER_ID_VOID_GHOST), 6)
                },
                new List<Treasure>
                {
                    CreateTreasure(
                        new Treasure(2000),
                        new List<TreasureItem>
                        {
                            new TreasureItem(ItemByID(ITEM_ID_WEAPON_MAGIC_RUBY_SWORD),1),      
                            new TreasureItem(ItemByID(ITEM_ID_POTION_GREAT_HEALING),75),
                        }
                    ),
                    CreateTreasure(
                        new Treasure(2000),
                        new List<TreasureItem>
                        {
                            new TreasureItem(ItemByID(ITEM_ID_POTION_GREAT_MANA),75),       
                            new TreasureItem(ItemByID(ITEM_ID_POTION_GREAT_POTION),50),
                        }
                    ),
                }
            );
            AddNewLocation(
                new Location(LOCATION_ID_TWILIGHT_HILL, "Twilight Hill", "A new challenge for you!", 200),
                new List<Quest>
                {
                    QuestByID(QUEST_ID_BATTLE_NEW_CHALLENGE)
                },
                new List<MonsterSpawn>
                {
                    new MonsterSpawn(MonsterByID(MONSTER_ID_TWILIGHT_TALON), 1)
                },
                new List<Treasure>
                {
                    CreateTreasure(
                        new Treasure(5000),
                        new List<TreasureItem>
                        {
                            new TreasureItem(ItemByID(ITEM_ID_WEAPON_DRAGON_CLAW),1),       
                            new TreasureItem(ItemByID(ITEM_ID_POTION_GREAT_POTION),60),
                        }
                    )
                }
            );
            AddNewLocation(
                new Location(LOCATION_ID_DEMON_CASTLE, "Demon Castle", "The journey has come to the end, let's continue!", 250),
                new List<Quest>
                {
                    QuestByID(QUEST_ID_ADVENTURE_GO_TO_VOLCANO)
                },
                new List<MonsterSpawn>
                {
                    new MonsterSpawn(MonsterByID(MONSTER_ID_DEMON), 7),
                    new MonsterSpawn(MonsterByID(MONSTER_ID_GREAT_DEMON), 2)
                },
                new List<Treasure>
                {
                    CreateTreasure(
                        new Treasure(4000),
                        new List<TreasureItem>
                        {
                            new TreasureItem(ItemByID(ITEM_ID_WEAPON_DEMON_DAGGER),1),      
                            new TreasureItem(ItemByID(ITEM_ID_POTION_GREAT_HEALING),90),        
                            new TreasureItem(ItemByID(ITEM_ID_POTION_GREAT_MANA),90),
                        }
                    ),
                    CreateTreasure(
                        new Treasure(4000),
                        new List<TreasureItem>
                        {
                            new TreasureItem(ItemByID(ITEM_ID_POTION_GREAT_POTION),75),     
                            new TreasureItem(ItemByID(ITEM_ID_POTION_GREAT_POTION),15),
                        }
                    ),
                    CreateTreasure(
                        new Treasure(4000),
                        new List<TreasureItem>
                        {
                            new TreasureItem(ItemByID(ITEM_ID_POTION_GREAT_HEALING),120),
                        }
                    ),
                }
            );
            AddNewLocation(
                new Location(LOCATION_ID_PURGATORY_MOUTAIN, "Purgatory Moutain", "Up until now, no matter what warnings you have, you still won't give up, right? I'm still by your side, keep going!", 400),
                new List<Quest>
                {
                    QuestByID(QUEST_ID_ADVENTURE_THE_TOWER),
                    QuestByID(QUEST_ID_BATTLE_DEMON_SUPER),
                    QuestByID(QUEST_ID_BATTLE_REAPER_IS_HERE)
                },
                new List<MonsterSpawn>
                {
                    new MonsterSpawn(MonsterByID(MONSTER_ID_GREAT_DEMON), 4),
                    new MonsterSpawn(MonsterByID(MONSTER_ID_FALLEN_ANGEL), 3),
                    new MonsterSpawn(MonsterByID(MONSTER_ID_KILLER_REAPER), 3)
                },
                new List<Treasure>
                {
                    CreateTreasure(
                        new Treasure(7000),
                        new List<TreasureItem>
                        {
                            new TreasureItem(ItemByID(ITEM_ID_WEAPON_KING_GREAT_SWORD),1),      
                            new TreasureItem(ItemByID(ITEM_ID_POTION_GREAT_HEALING),150),       
                            new TreasureItem(ItemByID(ITEM_ID_POTION_GREAT_MANA),150),
                        }
                    ),
                    CreateTreasure(
                        new Treasure(7000),
                        new List<TreasureItem>
                        {
                            new TreasureItem(ItemByID(ITEM_ID_WEAPON_DEMON_DAGGER),1),
                        }
                    ),
                    CreateTreasure(
                        new Treasure(7000),
                        new List<TreasureItem>
                        {
                            new TreasureItem(ItemByID(ITEM_ID_POTION_GREAT_POTION),200),
                        }
                    ),
                }
            );
            AddNewLocation(
                new Location(LOCATION_ID_TOWER_OF_DARKNESS, "Tower of Darkness", "Your last challenge! I will be at home waiting for you, must come back!", 800),
                null,
                new List<MonsterSpawn> { new MonsterSpawn(MonsterByID(MONSTER_ID_DEMON_KING), 1) },
                new List<Treasure>
                {
                    CreateTreasure(
                        new Treasure(10000),
                        new List<TreasureItem>
                        {
                            new TreasureItem(ItemByID(ITEM_ID_WEAPON_LEGEND_WAND),1),       
                            new TreasureItem(ItemByID(ITEM_ID_POTION_GREAT_HEALING),1000),      
                            new TreasureItem(ItemByID(ITEM_ID_POTION_GREAT_MANA),1000),     
                            new TreasureItem(ItemByID(ITEM_ID_POTION_GREAT_POTION),1000),
                        }
                    )
                }
            );

        }
        static void PopulateItem()
        {
            AddItem(ITEM_ID_SNAKE_POISON, "Snake Poison");
            AddItem(ITEM_ID_SNAKE_LEATHER, "Snake Leather");
            AddItem(ITEM_ID_UNDEAD_EYE, "Undead Eye");
            AddItem(ITEM_ID_GHOST_TEAR, "Ghost Tear");
            AddItem(ITEM_ID_GHOST_SCREAM, "Ghost Scream");
            AddItem(ITEM_ID_SKELETON_BONE, "Skeleton Bone");
            AddItem(ITEM_ID_SPIDER_EYE, "Spider Eye");
            AddItem(ITEM_ID_SPIDER_SILK, "Spider Silk");
            AddItem(ITEM_ID_WOLF_FANG, "Wolf Fang");
            AddItem(ITEM_ID_WOLF_FUR, "Wolf Fur");
            AddItem(ITEM_ID_WOLF_FLESH, "Wolf Flesh");
            AddItem(ITEM_ID_TIGER_LEATHER, "Tiger Leather");
            AddItem(ITEM_ID_TIGER_FANG, "Tiger Fang");
            AddItem(ITEM_ID_LION_FUR, "Lion Fur");
            AddItem(ITEM_ID_LION_FANG, "Lion Fang");
            AddItem(ITEM_ID_BROKEN_ARMOR, "Broken Armor");
            AddItem(ITEM_ID_BROKEN_SWORD, "Broken Sword");
            AddItem(ITEM_ID_KNIGHT_CERTIFICATION, "Knight Certification");
            AddItem(ITEM_ID_TORN_ROBE, "Torn Robe");
            AddItem(ITEM_ID_ROTTEN_WOODEN_WAND, "Rotten Wooden Wand");
            AddItem(ITEM_ID_DRAGON_BONE, "Dragon Bone");
            AddItem(ITEM_ID_DRAGON_FANG, "Dragon Fang");
            AddItem(ITEM_ID_DRAZARD_LEATHER, "Drazard Leather");
            AddItem(ITEM_ID_DRAZARD_EYE, "Drazard Eye");
            AddItem(ITEM_ID_PHANTOM_WING, "Phantom Wing");
            AddItem(ITEM_ID_DEATH_FRAGMENT, "Death Fragment");
            AddItem(ITEM_ID_GIANT_BONE, "Giant Bone");
            AddItem(ITEM_ID_GIANT_ESSENCE, "Giant Essence");
            AddItem(ITEM_ID_FLAME_DRAGON_EYE, "Flame Dragon Eye");
            AddItem(ITEM_ID_SIREN_SCALE, "Siren Scale");
            AddItem(ITEM_ID_MERMAID_VOICE, "Mermaid Voice");
            AddItem(ITEM_ID_VOID_FRAGMENT, "Void Fragment");
            AddItem(ITEM_ID_TWILIGHT_FEATHER, "Twilight Feather");
            AddItem(ITEM_ID_TWILIGHT_WING, "Twilight Wing");
            AddItem(ITEM_ID_DEMON_HORN, "Demon Horn");
            AddItem(ITEM_ID_ANGEL_WING, "Angel Wing");
            AddItem(ITEM_ID_ANGEL_EYE, "Angel Eye");
            AddItem(ITEM_ID_REAPER_SCYTHE, "Reaper Scythe");
            AddItem(ITEM_ID_DEMON_KING_CROWN, "Demon King Crown");
            //Add Weapon
            AddWeaponItem(ITEM_ID_WEAPON_IRON_SWORD, "Iron Sword", 10);
            AddWeaponItem(ITEM_ID_WEAPON_STEEL_SWORD, "Steel Sword", 15);
            AddWeaponItem(ITEM_ID_WEAPON_WOOD_BOW, "Wood Bow", 15);
            AddWeaponItem(ITEM_ID_WEAPON_IRON_BOW, "Iron Bow", 20);
            AddWeaponItem(ITEM_ID_WEAPON_FLAME_BLADE, "Flame Blade", 30);
            AddWeaponItem(ITEM_ID_WEAPON_ICE_BLADE, "Ice Blade", 30);
            AddWeaponItem(ITEM_ID_WEAPON_FIRECROSS_BLADE, "Firecross Blade", 45);
            AddWeaponItem(ITEM_ID_WEAPON_SAINT_SPEAR, "Saint Spear", 65);
            AddWeaponItem(ITEM_ID_WEAPON_ANGEL_SPEAR, "Angel Spear", 100);
            AddWeaponItem(ITEM_ID_WEAPON_DARK_HARVEST, "Dark Harvest", 150);
            AddWeaponItem(ITEM_ID_WEAPON_MAGIC_RUBY_SWORD, "Magic Ruby Sword", 175);
            AddWeaponItem(ITEM_ID_WEAPON_MAGIC_FLAMINUM_SWORD, "Magic Flaminum Sword", 200);
            AddWeaponItem(ITEM_ID_WEAPON_MAGIC_SAINIUM_SWORD, "Magic Sainium Sword", 275);
            AddWeaponItem(ITEM_ID_WEAPON_DEATH_DECIDENT, "Death Decident", 500);
            AddWeaponItem(ITEM_ID_WEAPON_DRAGON_CLAW, "Dragon Claw", 685);
            AddWeaponItem(ITEM_ID_WEAPON_LEGEND_WAND, "Legend Wand", 755);
            AddWeaponItem(ITEM_ID_WEAPON_DEMON_DAGGER, "Demon Dagger", 765);
            AddWeaponItem(ITEM_ID_WEAPON_KING_GREAT_SWORD, "King Great Sword", 850);
            AddWeaponItem(ITEM_ID_WEAPON_LAST_HOPE, "Last Hope", 1000);
            //Add Potion
            AddPotionItem(ITEM_ID_POTION_TINY_HEALING, "Tiny Healing", 30, 0);
            AddPotionItem(ITEM_ID_POTION_TINY_MANA, "Tiny Mana", 0, 30);
            AddPotionItem(ITEM_ID_POTION_TINY_POTION, "Tiny Potion", 25, 25);
            AddPotionItem(ITEM_ID_POTION_SMALL_HEALING, "Small Healing", 50, 0);
            AddPotionItem(ITEM_ID_POTION_SMALL_MANA, "Small Mana", 0, 50);
            AddPotionItem(ITEM_ID_POTION_SMALL_POTION, "Small Potion", 40, 40);
            AddPotionItem(ITEM_ID_POTION_MEDIUM_HEALING, "Medium Healing", 100, 0);
            AddPotionItem(ITEM_ID_POTION_MEDIUM_MANA, "Medium Mana", 0, 100);
            AddPotionItem(ITEM_ID_POTION_MEDIUM_POTION, "Medium Potion", 80, 80);
            AddPotionItem(ITEM_ID_POTION_BIG_HEALING, "Big Healing", 200, 0);
            AddPotionItem(ITEM_ID_POTION_BIG_MANA, "Big Mana", 0, 200);
            AddPotionItem(ITEM_ID_POTION_BIG_POTION, "Big Potion", 150, 150);
            AddPotionItem(ITEM_ID_POTION_GREAT_HEALING, "Great Healing", 500, 0);
            AddPotionItem(ITEM_ID_POTION_GREAT_MANA, "Great Mana", 0, 500);
            AddPotionItem(ITEM_ID_POTION_GREAT_POTION, "Great Potion", 550, 550);
            AddPotionItem(ITEM_ID_POTION_MAGIC_POTION, "Magic Potion", 0, 0);

        }
        static void PopulateMonster()
        {
            Monster snake = AddMonster(MONSTER_ID_SNAKE, "Snake", 100, 100, 10, 0, 20);
            Monster undead = AddMonster(MONSTER_ID_UNDEAD, "Undead", 100, 100, 10, 0, 20);
            Monster spider = AddMonster(MONSTER_ID_SPIDER, "Spider", 120, 120, 20, 5, 30);
            Monster ghost = AddMonster(MONSTER_ID_GHOST, "Ghost", 150, 150, 30, 10, 30);
            Monster skeleton = AddMonster(MONSTER_ID_SKELETON, "Skeleton", 120, 120, 35, 5, 30);
            Monster wolf = AddMonster(MONSTER_ID_WOLF, "Wolf", 200, 200, 40, 10, 40);
            Monster tiger = AddMonster(MONSTER_ID_TIGER, "Tiger", 400, 400, 50, 20, 50);
            Monster lion = AddMonster(MONSTER_ID_LION, "Lion", 450, 450, 50, 15, 50);
            Monster bone_dragon = AddMonster(MONSTER_ID_BONE_DRAGON, "Bone Dragon", 1000, 1000, 100, 30, 300);
            Monster undead_knight = AddMonster(MONSTER_ID_UNDEAD_KNIGHT, "Undead Knight", 500, 500, 60, 20, 70);
            Monster undead_magician = AddMonster(MONSTER_ID_UNDEAD_MAGICIAN, "Undead Magician", 400, 400, 80, 10, 70);
            Monster drazard = AddMonster(MONSTER_ID_DRAZARD, "Drazard", 650, 650, 85, 35, 100);
            Monster phantom = AddMonster(MONSTER_ID_PHANTOM, "Phantom", 580, 580, 90, 20, 100);
            Monster great_drazard = AddMonster(MONSTER_ID_GREAT_DRAZARD, "Great Drazard", 900, 900, 90, 40, 150);
            Monster death_drazard = AddMonster(MONSTER_ID_DEATH_DRAZARD, "Death Drazard", 1200, 1200, 100, 50, 200);
            Monster giant = AddMonster(MONSTER_ID_GIANT, "Giant", 2000, 2000, 250, 70, 400);
            Monster flame_dragon = AddMonster(MONSTER_ID_FLAME_DRAGON, "Flame Dragon", 1800, 1800, 300, 60, 500);
            Monster siren = AddMonster(MONSTER_ID_SIREN, "Siren", 1750, 1750, 250, 60, 300);
            Monster dark_mermaid = AddMonster(MONSTER_ID_DARK_MERMAID, "Dark Mermaid", 1900, 1900, 300, 65, 400);
            Monster void_ghost = AddMonster(MONSTER_ID_VOID_GHOST, "Void Ghost", 2100, 2100, 500, 150, 500);
            Monster twilight_talon = AddMonster(MONSTER_ID_TWILIGHT_TALON, "Twilight Talon", 6000, 6000, 1000, 500, 1500);
            Monster demon = AddMonster(MONSTER_ID_DEMON, "Demon", 3000, 3000, 650, 200, 600);
            Monster great_demon = AddMonster(MONSTER_ID_GREAT_DEMON, "Great Demon", 4000, 4000, 800, 250, 800);
            Monster fallen_angel = AddMonster(MONSTER_ID_FALLEN_ANGEL, "Fallen Angel", 6000, 6000, 950, 400, 1000);
            Monster killer_reaper = AddMonster(MONSTER_ID_KILLER_REAPER, "Killer Reaper", 6500, 6500, 1050, 650, 1000);
            Monster demon_king = AddMonster(MONSTER_ID_DEMON_KING, "Demon King", 50000, 50000, 5000, 1000, 100000);

            Monsters.Add(snake);
            Monsters.Add(undead);
            Monsters.Add(spider);
            Monsters.Add(ghost);
            Monsters.Add(skeleton);
            Monsters.Add(wolf);
            Monsters.Add(tiger);
            Monsters.Add(lion);
            Monsters.Add(bone_dragon);
            Monsters.Add(undead_knight);
            Monsters.Add(undead_magician);
            Monsters.Add(drazard);
            Monsters.Add(phantom);
            Monsters.Add(great_drazard);
            Monsters.Add(death_drazard);
            Monsters.Add(giant);
            Monsters.Add(flame_dragon);
            Monsters.Add(siren);
            Monsters.Add(dark_mermaid);
            Monsters.Add(void_ghost);
            Monsters.Add(twilight_talon);
            Monsters.Add(demon);
            Monsters.Add(great_demon);
            Monsters.Add(fallen_angel);
            Monsters.Add(killer_reaper);
            Monsters.Add(demon_king);

            AddMonsterLootTable(snake, ItemByID(ITEM_ID_SNAKE_LEATHER), 1, 5, 50);
            AddMonsterLootTable(snake, ItemByID(ITEM_ID_SNAKE_POISON), 1, 3, 50);
            AddMonsterLootTable(snake, ItemByID(ITEM_ID_POTION_TINY_HEALING), 1, 1, 35);
            AddMonsterLootTable(snake, ItemByID(ITEM_ID_POTION_TINY_MANA), 1, 1, 35);

            AddMonsterLootTable(undead, ItemByID(ITEM_ID_UNDEAD_EYE), 1, 5, 50);
            AddMonsterLootTable(undead, ItemByID(ITEM_ID_POTION_TINY_HEALING), 1, 1, 40);
            AddMonsterLootTable(undead, ItemByID(ITEM_ID_POTION_TINY_POTION), 1, 1, 15);

            AddMonsterLootTable(spider, ItemByID(ITEM_ID_SPIDER_SILK), 1, 5, 50);
            AddMonsterLootTable(spider, ItemByID(ITEM_ID_SPIDER_EYE), 1, 3, 50);

            AddMonsterLootTable(ghost, ItemByID(ITEM_ID_WEAPON_IRON_SWORD), 1, 1, 25);
            AddMonsterLootTable(ghost, ItemByID(ITEM_ID_POTION_TINY_HEALING), 1, 2, 50);
            AddMonsterLootTable(ghost, ItemByID(ITEM_ID_POTION_TINY_MANA), 1, 2, 45);

            AddMonsterLootTable(skeleton, ItemByID(ITEM_ID_WEAPON_WOOD_BOW), 1, 2, 25);
            AddMonsterLootTable(skeleton, ItemByID(ITEM_ID_POTION_TINY_HEALING), 1, 2, 50);
            AddMonsterLootTable(skeleton, ItemByID(ITEM_ID_POTION_TINY_MANA), 1, 2, 45);

            AddMonsterLootTable(wolf, ItemByID(ITEM_ID_WOLF_FANG), 1, 2, 75);
            AddMonsterLootTable(wolf, ItemByID(ITEM_ID_WOLF_FUR), 2, 8, 50);
            AddMonsterLootTable(wolf, ItemByID(ITEM_ID_WOLF_FLESH), 1, 9, 100);
            AddMonsterLootTable(wolf, ItemByID(ITEM_ID_POTION_TINY_HEALING), 1, 2, 50);
            AddMonsterLootTable(wolf, ItemByID(ITEM_ID_POTION_TINY_MANA), 1, 2, 45);
            AddMonsterLootTable(wolf, ItemByID(ITEM_ID_POTION_TINY_POTION), 1, 1, 40);
            AddMonsterLootTable(wolf, ItemByID(ITEM_ID_WEAPON_STEEL_SWORD), 1, 1, 25);

            AddMonsterLootTable(tiger, ItemByID(ITEM_ID_TIGER_LEATHER), 1, 4, 75);
            AddMonsterLootTable(tiger, ItemByID(ITEM_ID_TIGER_FANG), 1, 2, 50);
            AddMonsterLootTable(tiger, ItemByID(ITEM_ID_POTION_TINY_POTION), 1, 1, 40);
            AddMonsterLootTable(tiger, ItemByID(ITEM_ID_POTION_SMALL_HEALING), 1, 2, 50);
            AddMonsterLootTable(tiger, ItemByID(ITEM_ID_POTION_SMALL_MANA), 1, 2, 45);
            AddMonsterLootTable(tiger, ItemByID(ITEM_ID_WEAPON_STEEL_SWORD), 1, 1, 25);

            AddMonsterLootTable(lion, ItemByID(ITEM_ID_LION_FANG), 1, 2, 75);
            AddMonsterLootTable(lion, ItemByID(ITEM_ID_LION_FUR), 1, 3, 50);
            AddMonsterLootTable(lion, ItemByID(ITEM_ID_POTION_TINY_POTION), 1, 1, 40);
            AddMonsterLootTable(lion, ItemByID(ITEM_ID_POTION_SMALL_HEALING), 1, 2, 50);
            AddMonsterLootTable(lion, ItemByID(ITEM_ID_POTION_SMALL_MANA), 1, 2, 45);
            AddMonsterLootTable(lion, ItemByID(ITEM_ID_WEAPON_STEEL_SWORD), 1, 1, 25);
            AddMonsterLootTable(lion, ItemByID(ITEM_ID_WEAPON_IRON_BOW), 1, 1, 10);

            AddMonsterLootTable(bone_dragon, ItemByID(ITEM_ID_DRAGON_BONE), 4, 15, 100);
            AddMonsterLootTable(bone_dragon, ItemByID(ITEM_ID_DRAGON_FANG), 1, 4, 100);
            AddMonsterLootTable(bone_dragon, ItemByID(ITEM_ID_WEAPON_FLAME_BLADE), 1, 1, 25);
            AddMonsterLootTable(bone_dragon, ItemByID(ITEM_ID_WEAPON_ICE_BLADE), 1, 1, 25);
            AddMonsterLootTable(bone_dragon, ItemByID(ITEM_ID_WEAPON_FIRECROSS_BLADE), 1, 1, 5);

            AddMonsterLootTable(undead_knight, ItemByID(ITEM_ID_BROKEN_ARMOR), 1, 4, 75);
            AddMonsterLootTable(undead_knight, ItemByID(ITEM_ID_BROKEN_SWORD), 1, 2, 75);
            AddMonsterLootTable(undead_knight, ItemByID(ITEM_ID_KNIGHT_CERTIFICATION), 1, 1, 25);
            AddMonsterLootTable(undead_knight, ItemByID(ITEM_ID_POTION_SMALL_HEALING), 1, 2, 50);
            AddMonsterLootTable(undead_knight, ItemByID(ITEM_ID_POTION_SMALL_MANA), 1, 2, 45);
            AddMonsterLootTable(undead_knight, ItemByID(ITEM_ID_POTION_TINY_POTION), 1, 1, 40);
            AddMonsterLootTable(undead_knight, ItemByID(ITEM_ID_WEAPON_STEEL_SWORD), 1, 1, 40);
            AddMonsterLootTable(undead_knight, ItemByID(ITEM_ID_WEAPON_IRON_BOW), 1, 1, 25);

            AddMonsterLootTable(undead_magician, ItemByID(ITEM_ID_TORN_ROBE), 1, 2, 50);
            AddMonsterLootTable(undead_magician, ItemByID(ITEM_ID_ROTTEN_WOODEN_WAND), 1, 3, 50);
            AddMonsterLootTable(undead_magician, ItemByID(ITEM_ID_POTION_SMALL_HEALING), 1, 2, 50);
            AddMonsterLootTable(undead_magician, ItemByID(ITEM_ID_POTION_SMALL_MANA), 1, 2, 45);
            AddMonsterLootTable(undead_magician, ItemByID(ITEM_ID_POTION_TINY_POTION), 1, 1, 40);
            AddMonsterLootTable(undead_magician, ItemByID(ITEM_ID_WEAPON_FLAME_BLADE), 1, 1, 2);

            AddMonsterLootTable(drazard, ItemByID(ITEM_ID_DRAZARD_LEATHER), 2, 5, 75);
            AddMonsterLootTable(drazard, ItemByID(ITEM_ID_DRAZARD_EYE), 1, 2, 50);
            AddMonsterLootTable(drazard, ItemByID(ITEM_ID_POTION_SMALL_POTION), 1, 1, 40);
            AddMonsterLootTable(drazard, ItemByID(ITEM_ID_POTION_MEDIUM_HEALING), 1, 2, 50);
            AddMonsterLootTable(drazard, ItemByID(ITEM_ID_POTION_MEDIUM_MANA), 1, 2, 45);

            AddMonsterLootTable(phantom, ItemByID(ITEM_ID_PHANTOM_WING), 1, 2, 75);
            AddMonsterLootTable(phantom, ItemByID(ITEM_ID_POTION_SMALL_POTION), 1, 1, 40);
            AddMonsterLootTable(phantom, ItemByID(ITEM_ID_POTION_MEDIUM_HEALING), 1, 2, 50);
            AddMonsterLootTable(phantom, ItemByID(ITEM_ID_POTION_MEDIUM_MANA), 1, 2, 45);

            AddMonsterLootTable(great_drazard, ItemByID(ITEM_ID_DRAZARD_LEATHER), 3, 7, 85);
            AddMonsterLootTable(great_drazard, ItemByID(ITEM_ID_DRAZARD_EYE), 1, 2, 75);
            AddMonsterLootTable(great_drazard, ItemByID(ITEM_ID_POTION_MEDIUM_HEALING), 1, 2, 50);
            AddMonsterLootTable(great_drazard, ItemByID(ITEM_ID_POTION_MEDIUM_MANA), 1, 2, 45);
            AddMonsterLootTable(great_drazard, ItemByID(ITEM_ID_WEAPON_SAINT_SPEAR), 1, 1, 25);

            AddMonsterLootTable(death_drazard, ItemByID(ITEM_ID_DRAZARD_LEATHER), 3, 7, 85);
            AddMonsterLootTable(death_drazard, ItemByID(ITEM_ID_DRAZARD_EYE), 1, 2, 75);
            AddMonsterLootTable(death_drazard, ItemByID(ITEM_ID_DEATH_FRAGMENT), 3, 7, 40);
            AddMonsterLootTable(death_drazard, ItemByID(ITEM_ID_POTION_MEDIUM_HEALING), 1, 2, 50);
            AddMonsterLootTable(death_drazard, ItemByID(ITEM_ID_POTION_MEDIUM_MANA), 1, 2, 45);
            AddMonsterLootTable(death_drazard, ItemByID(ITEM_ID_POTION_MEDIUM_POTION), 1, 1, 40);
            AddMonsterLootTable(death_drazard, ItemByID(ITEM_ID_WEAPON_ANGEL_SPEAR), 1, 1, 25);

            AddMonsterLootTable(giant, ItemByID(ITEM_ID_GIANT_BONE), 5, 20, 90);
            AddMonsterLootTable(giant, ItemByID(ITEM_ID_GIANT_ESSENCE), 3, 7, 25);
            AddMonsterLootTable(giant, ItemByID(ITEM_ID_POTION_MEDIUM_HEALING), 1, 2, 50);
            AddMonsterLootTable(giant, ItemByID(ITEM_ID_POTION_MEDIUM_MANA), 1, 2, 45);
            AddMonsterLootTable(giant, ItemByID(ITEM_ID_POTION_MEDIUM_POTION), 1, 1, 40);
            AddMonsterLootTable(giant, ItemByID(ITEM_ID_WEAPON_FIRECROSS_BLADE), 1, 1, 25);

            AddMonsterLootTable(flame_dragon, ItemByID(ITEM_ID_DRAGON_BONE), 4, 15, 100);
            AddMonsterLootTable(flame_dragon, ItemByID(ITEM_ID_DRAGON_FANG), 1, 4, 100);
            AddMonsterLootTable(flame_dragon, ItemByID(ITEM_ID_FLAME_DRAGON_EYE), 1, 2, 25);
            AddMonsterLootTable(flame_dragon, ItemByID(ITEM_ID_POTION_MEDIUM_HEALING), 1, 2, 50);
            AddMonsterLootTable(flame_dragon, ItemByID(ITEM_ID_POTION_MEDIUM_MANA), 1, 2, 45);
            AddMonsterLootTable(flame_dragon, ItemByID(ITEM_ID_POTION_MEDIUM_POTION), 1, 1, 40);
            AddMonsterLootTable(flame_dragon, ItemByID(ITEM_ID_WEAPON_FLAME_BLADE), 1, 1, 15);

            AddMonsterLootTable(siren, ItemByID(ITEM_ID_SIREN_SCALE), 5, 20, 90);
            AddMonsterLootTable(siren, ItemByID(ITEM_ID_POTION_MEDIUM_HEALING), 1, 2, 50);
            AddMonsterLootTable(siren, ItemByID(ITEM_ID_POTION_MEDIUM_MANA), 1, 2, 45);
            AddMonsterLootTable(siren, ItemByID(ITEM_ID_POTION_BIG_POTION), 1, 1, 40);

            AddMonsterLootTable(dark_mermaid, ItemByID(ITEM_ID_MERMAID_VOICE), 1, 3, 40);
            AddMonsterLootTable(dark_mermaid, ItemByID(ITEM_ID_POTION_MEDIUM_HEALING), 1, 2, 50);
            AddMonsterLootTable(dark_mermaid, ItemByID(ITEM_ID_POTION_MEDIUM_MANA), 1, 2, 45);

            AddMonsterLootTable(void_ghost, ItemByID(ITEM_ID_VOID_FRAGMENT), 3, 8, 30);
            AddMonsterLootTable(void_ghost, ItemByID(ITEM_ID_POTION_BIG_HEALING), 1, 2, 50);
            AddMonsterLootTable(void_ghost, ItemByID(ITEM_ID_POTION_BIG_MANA), 1, 2, 45);
            AddMonsterLootTable(void_ghost, ItemByID(ITEM_ID_POTION_BIG_POTION), 1, 1, 40);

            AddMonsterLootTable(twilight_talon, ItemByID(ITEM_ID_TWILIGHT_FEATHER), 5, 20, 100);
            AddMonsterLootTable(twilight_talon, ItemByID(ITEM_ID_TWILIGHT_WING), 1, 2, 80);
            AddMonsterLootTable(twilight_talon, ItemByID(ITEM_ID_WEAPON_DARK_HARVEST), 1, 1, 70);
            AddMonsterLootTable(twilight_talon, ItemByID(ITEM_ID_WEAPON_MAGIC_FLAMINUM_SWORD), 1, 1, 5);

            AddMonsterLootTable(demon, ItemByID(ITEM_ID_DEMON_HORN), 1, 8, 70);
            AddMonsterLootTable(demon, ItemByID(ITEM_ID_POTION_BIG_HEALING), 1, 2, 50);
            AddMonsterLootTable(demon, ItemByID(ITEM_ID_POTION_BIG_MANA), 1, 2, 45);
            AddMonsterLootTable(demon, ItemByID(ITEM_ID_POTION_BIG_POTION), 1, 1, 40);

            AddMonsterLootTable(great_demon, ItemByID(ITEM_ID_DEMON_HORN), 1, 12, 50);
            AddMonsterLootTable(great_demon, ItemByID(ITEM_ID_POTION_BIG_HEALING), 1, 2, 50);
            AddMonsterLootTable(great_demon, ItemByID(ITEM_ID_POTION_BIG_MANA), 1, 2, 45);
            AddMonsterLootTable(great_demon, ItemByID(ITEM_ID_POTION_GREAT_POTION), 1, 1, 40);
            AddMonsterLootTable(great_demon, ItemByID(ITEM_ID_WEAPON_DEMON_DAGGER), 1, 1, 10);

            AddMonsterLootTable(fallen_angel, ItemByID(ITEM_ID_ANGEL_WING), 1, 4, 80);
            AddMonsterLootTable(fallen_angel, ItemByID(ITEM_ID_ANGEL_EYE), 1, 2, 40);
            AddMonsterLootTable(fallen_angel, ItemByID(ITEM_ID_POTION_GREAT_HEALING), 1, 2, 50);
            AddMonsterLootTable(fallen_angel, ItemByID(ITEM_ID_POTION_GREAT_MANA), 1, 2, 45);
            AddMonsterLootTable(fallen_angel, ItemByID(ITEM_ID_POTION_GREAT_POTION), 1, 1, 40);
            AddMonsterLootTable(fallen_angel, ItemByID(ITEM_ID_WEAPON_MAGIC_RUBY_SWORD), 1, 1, 25);

            AddMonsterLootTable(killer_reaper, ItemByID(ITEM_ID_REAPER_SCYTHE), 1, 4, 80);
            AddMonsterLootTable(killer_reaper, ItemByID(ITEM_ID_POTION_GREAT_HEALING), 1, 2, 50);
            AddMonsterLootTable(killer_reaper, ItemByID(ITEM_ID_POTION_GREAT_MANA), 1, 2, 45);
            AddMonsterLootTable(killer_reaper, ItemByID(ITEM_ID_POTION_GREAT_POTION), 1, 1, 40);

            AddMonsterLootTable(demon_king, ItemByID(ITEM_ID_DEMON_KING_CROWN), 1, 1, 100);
            AddMonsterLootTable(demon_king, ItemByID(ITEM_ID_WEAPON_KING_GREAT_SWORD), 1, 1, 100);
        }
        static void PopulateQuest()
        {
            //
            //Type 1: Adventure
            //
            AddQuestTypeAdventure(new QuestTypeAdventure(QUEST_ID_ADVENTURE_GO_TO_VILLAGE, "Đi tới Làng Anh Hùng", LocationByID(LOCATION_ID_HEROES_VILLAGE), 50));
            AddQuestTypeAdventure(new QuestTypeAdventure(QUEST_ID_ADVENTURE_GO_TO_STELE, "Đi tới Bia Tưởng Niệm", LocationByID(LOCATION_ID_MEMORIAL_STELE), 200));
            AddQuestTypeAdventure(new QuestTypeAdventure(QUEST_ID_ADVENTURE_DO_YOU_SEE_WOLF, "Đi tới Wolf Place", LocationByID(LOCATION_ID_WOLF_PLACE), 300));
            AddQuestTypeAdventure(new QuestTypeAdventure(QUEST_ID_ADVENTURE_THE_CAVE, "Đi đến Chaos Gate", LocationByID(LOCATION_ID_CHAOS_GATE), 3500));
            AddQuestTypeAdventure(new QuestTypeAdventure(QUEST_ID_ADVENTURE_GO_TO_WAVE, "Đi đến Wave Ocean", LocationByID(LOCATION_ID_WAVE_OCEAN), 6500));
            AddQuestTypeAdventure(new QuestTypeAdventure(QUEST_ID_ADVENTURE_GO_TO_VOLCANO, "Đi đến Purgatory Moutain", LocationByID(LOCATION_ID_PURGATORY_MOUTAIN), 7800));
            AddQuestTypeAdventure(new QuestTypeAdventure(QUEST_ID_ADVENTURE_THE_TOWER, "Đi đến Tower of Darkness", LocationByID(LOCATION_ID_TOWER_OF_DARKNESS), 20000));
            //
            //Type 2: Battle
            //
            AddQuestTypeBattle(new QuestTypeBattle(QUEST_ID_BATTLE_KILL_SNAKE, "Tiêu diệt 20 Snake", MonsterByID(MONSTER_ID_SNAKE), 20, 150));
            AddQuestTypeBattle(new QuestTypeBattle(QUEST_ID_BATTLE_KILL_GHOST, "Tiêu diệt 50 Ghost", MonsterByID(MONSTER_ID_GHOST), 50, 300));
            AddQuestTypeBattle(new QuestTypeBattle(QUEST_ID_BATTLE_TALK_TO_WOLF, "Tiêu diệt 100 con sói", MonsterByID(MONSTER_ID_WOLF), 100, 1000));
            AddQuestTypeBattle(new QuestTypeBattle(QUEST_ID_BATTLE_LION_ROAR, "Tiêu diệt 100 con sư tử", MonsterByID(MONSTER_ID_LION), 100, 1500));
            AddQuestTypeBattle(new QuestTypeBattle(QUEST_ID_BATTLE_KNIGHT_NOT_DIED, "Tiêu diệt 200 Undead Knight", MonsterByID(MONSTER_ID_UNDEAD_KNIGHT), 200, 3000));
            AddQuestTypeBattle(new QuestTypeBattle(QUEST_ID_BATTLE_IT_IS_DRAGON, "Tiêu diệt 30 con Bone Dragon", MonsterByID(MONSTER_ID_BONE_DRAGON), 30, 5000));
            AddQuestTypeBattle(new QuestTypeBattle(QUEST_ID_BATTLE_NEW_CHALLENGE, "Đánh bại Twilight Talon", MonsterByID(MONSTER_ID_TWILIGHT_TALON), 1, 12000));
            AddQuestTypeBattle(new QuestTypeBattle(QUEST_ID_BATTLE_DEMON_SUPER, "Tiêu diệt 500 Great Demon", MonsterByID(MONSTER_ID_GREAT_DEMON), 500, 13000));
            AddQuestTypeBattle(new QuestTypeBattle(QUEST_ID_BATTLE_REAPER_IS_HERE, "Tiêu diệt 700 Killer Reaper", MonsterByID(MONSTER_ID_KILLER_REAPER), 700, 14000));
            //
            //Type 3: Collection
            //
            AddQuestTypeCollection(new QuestTypeCollection(QUEST_ID_COLLECT_UNDEAD_EYE, "Thu thập 10 Undead Eye", 100, CreateQuestItem(ItemByID(ITEM_ID_SPIDER_EYE), 10), null, null));
            AddQuestTypeCollection(new QuestTypeCollection(QUEST_ID_COLLECT_SPIDER_SILK, "Thu thập 50 Spider Silks", 250, CreateQuestItem(ItemByID(ITEM_ID_SPIDER_SILK), 50), null, null));
            AddQuestTypeCollection(new QuestTypeCollection(QUEST_ID_COLLECT_LEATHER_AND_SILK, "Thu thập 50 Snake Leathers và 50 Spider Silks", 500, CreateQuestItem(ItemByID(ITEM_ID_SNAKE_LEATHER), 50), CreateQuestItem(ItemByID(ITEM_ID_SPIDER_EYE), 50), null));
            AddQuestTypeCollection(new QuestTypeCollection(QUEST_ID_COLLECT_KNIGHT_AND_MAGICIAN, "Thu thập 100 chứng nhận kỵ sĩ và 100 gậy phép mục nát", 4000, CreateQuestItem(ItemByID(ITEM_ID_KNIGHT_CERTIFICATION), 100), CreateQuestItem(ItemByID(ITEM_ID_ROTTEN_WOODEN_WAND), 100), null));
            AddQuestTypeCollection(new QuestTypeCollection(QUEST_ID_COLLECT_I_AM_KNIGHT, "Thu thập 50 kiếm gãy và 50 giáp vỡ", 2500, CreateQuestItem(ItemByID(ITEM_ID_BROKEN_ARMOR), 50), CreateQuestItem(ItemByID(ITEM_ID_BROKEN_SWORD), 50), null));
            AddQuestTypeCollection(new QuestTypeCollection(QUEST_ID_COLLECT_WING_AND_ESSENCE, "Thu thập Phantom Wing, Giant Essence và Death Fragment", 5000, CreateQuestItem(ItemByID(ITEM_ID_PHANTOM_WING), 300), CreateQuestItem(ItemByID(ITEM_ID_GIANT_ESSENCE), 50), CreateQuestItem(ItemByID(ITEM_ID_DEATH_FRAGMENT), 150)));
            AddQuestTypeCollection(new QuestTypeCollection(QUEST_ID_COLLECT_DRAGON_AGAIN, "Thu thập Drazard Eye và Leather", 6000, CreateQuestItem(ItemByID(ITEM_ID_DRAZARD_EYE), 100), CreateQuestItem(ItemByID(ITEM_ID_DRAZARD_LEATHER), 100), null));
            AddQuestTypeCollection(new QuestTypeCollection(QUEST_ID_COLLECT_FLAME_EYE, "Thu thập Dragon Fang và Flame Dragon Eye", 7000, CreateQuestItem(ItemByID(ITEM_ID_DRAGON_FANG), 150), CreateQuestItem(ItemByID(ITEM_ID_FLAME_DRAGON_EYE), 50), null));
            AddQuestTypeCollection(new QuestTypeCollection(QUEST_ID_COLLECT_DEEP_OCEAN, "Thu thập Siren Scale, Mermaid Voice và Void Fragment", 8000, CreateQuestItem(ItemByID(ITEM_ID_SIREN_SCALE), 200), CreateQuestItem(ItemByID(ITEM_ID_MERMAID_VOICE), 200), CreateQuestItem(ItemByID(ITEM_ID_VOID_FRAGMENT), 50)));
        }
        static void PopulateSkill()
        {
            //Type 1
            AddSkillAttack(SKILL_ID_ATTACK_QUA_CAU_LUA, "Quả cầu lửa", 10, 0, 5, 25, 0.2f);
            AddSkillAttack(SKILL_ID_ATTACK_THANH_THUONG, "Thánh Thương", 20, 0, 7, 40, 0.1f);
            AddSkillAttack(SKILL_ID_ATTACK_COT_LUA, "Cột lửa", 40, 0, 10, 80, 0.5f);
            AddSkillAttack(SKILL_ID_ATTACK_LUYEN_NGUC, "Luyện Ngục", 100, 0, 40, 150, 1.5f);
            //Type 2
            AddSkillDefense(SKILL_ID_DEFENSE_GIAO_AO, "Giáp ảo", 20, 0, 10, 50);
            AddSkillDefense(SKILL_ID_DEFENSE_PHONG_HO_TUYET_DOI, "Phòng hộ tuyệt đối", 0, 15, 60, 0);
            //Type 3
            AddSkillBuff(SKILL_ID_BUFF_CUONG_HOA_SAT_THUONG, "Cường hoá sát thương", 20, 0, 10, 0.5f);
            AddSkillBuff(SKILL_ID_BUFF_CUONG_HOA_MP, "Cường hoá Mana", 20, 0, 10, 0, 0, 0.5f);
            AddSkillBuff(SKILL_ID_BUFF_SIEU_CUONG_HOA, "Siêu cường hoá", 50, 0, 30, 1f, 1f, 1f, 1f);
            //Type 4
            AddSkillHeal(SKILL_ID_HEAL_TRI_LIEU, "Trị liệu", 10, 0, 10, 20, 0.4f);
            AddSkillHeal(SKILL_ID_HEAL_HOI_NANG_LUONG, "Hồi năng lượng", 0, 5, 10, 0, 0, 20, 0.4f);
            AddSkillHeal(SKILL_ID_HEAL_HOI_PHUC_NHANH, "Hồi phục nhanh", 30, 0, 20, 50, 0.5f, 50, 0.5f);
            AddSkillHeal(SKILL_ID_HEAL_SIEU_CAP_HOI_PHUC, "Siêu cấp hồi phục", 60, 0, 60, 150, 1.6f, 150, 1.6f);
            //Type 5
            AddSkillDebuff(SKILL_ID_DEBUFF_NGUYEN_RUA, "Nguyền rủa", 15, 0, 20, 0.2f, 0.2f, 0.1f, 0.2f);
            AddSkillDebuff(SKILL_ID_DEBUFF_NGUYEN_RUA_NANG_CAO, "Nguyền rủa nâng cao", 50, 10, 30, 0.3f, 0.3f, 0.3f, 0.3f);
            AddSkillDebuff(SKILL_ID_DEBUFF_NGUYEN_RUA_SIEU_CAP, "Nguyền rủa siêu cấp", 100, 20, 120, 0.5f, 0.5f, 0.5f, 0.5f);

        }
        //
        //Add Item
        //
        private static void AddItem(int id, string name)
        {
            Items.Add(new Item(id, name));
        }
        private static void AddWeaponItem(int id, string name, float damage)
        {
            Items.Add(new Weapon(id, name, damage));
        }
        private static void AddPotionItem(int id, string name, float hp = 0, float mp = 0)
        {
            Items.Add(new Potion(id, name, hp, mp));
        }
        //
        //Create Monster
        //
        private static Monster AddMonster(int id, string name, float hp, float HP, float damage, float armor, int exp)
        {
            return new Monster(id, name, hp, HP, damage, armor, exp);
        }
        private static void AddMonsterLootTable(Monster monster, Item item, int min_quantity, int max_quantity, float rate)
        {
            monster.LootTable.Add(new LootItem(item, min_quantity, max_quantity, rate));
        }
        //
        //Create Skill
        //
        private static void AddSkillAttack(int id, string name, float mp, float hp, int time, float based, float scale)
        {
            Skills.Add(new SkillAttack(id, name, based, scale, mp, hp, time));
        }
        private static void AddSkillDefense(int id, string name, float mp, float hp, int time, float decrease_damage)
        {
            Skills.Add(new SkillDefense(id, name, decrease_damage, mp, hp, time));
        }
        private static void AddSkillBuff(int id, string name, float mp, float hp, int time, float damage = 0, float HP = 0, float MP = 0, float armor = 0)
        {
            Skills.Add(new SkillBuff(id, name, mp, hp, time, damage, HP, MP, armor));
        }
        private static void AddSkillHeal(int id, string name, float mp, float hp, int time, float heal = 0, float h_scale = 0, float reduce = 0, float r_scale = 0)
        {
            Skills.Add(new SkillHealing(id, name, mp, hp, time, heal, h_scale, reduce, r_scale));
        }
        private static void AddSkillDebuff(int id, string name, float mp, float hp, int time, float HP = 0, float MP = 0, float damage = 0, float armor = 0)
        {
            Skills.Add(new SkillDebuff(id, name, mp, hp, time, HP, MP, damage, armor));
        }
        //
        //Create Quest
        //
        private static void AddQuestTypeAdventure(QuestTypeAdventure newQuest)
        {
            Quests.Add(newQuest);
        }
        private static void AddQuestTypeBattle(QuestTypeBattle newQuest)
        {
            Quests.Add(newQuest);
        }
        private static void AddQuestTypeCollection(QuestTypeCollection newQuest)
        {
            Quests.Add(newQuest);
        }
        private static QuestItem CreateQuestItem(Item detail, int quantity)
        {
            QuestItem newQuestItem = new QuestItem(detail, quantity);
            return newQuestItem;
        }
        //
        //Create Location
        //
        private static void AddNewLocation(Location newLocation, List<Quest> quests, List<MonsterSpawn> monster, List<Treasure> item)
        {
            newLocation.QuestAvailables = quests;
            newLocation.MonsterAvailables = monster;
            newLocation.TreasureAvailables = item;
            Locations.Add(newLocation);
        }
        private static Treasure CreateTreasure(Treasure treasure, List<TreasureItem> reward)
        {
            treasure.TreasureReward = reward;
            return treasure;
        }
        private static void AddMap(ref Location current, List<Location> map)
        {
            current.East(map[0]);
            current.West(map[1]);
            current.South(map[2]);
            current.North(map[3]);
        }
        //
        //Search in Collection
        //
        public static Location LocationByID(int id)
        {
            return Locations.Where(location => location.ID == id).FirstOrDefault();
        }
        public static Item ItemByID(int id)
        {
            return Items.Where(item => item.ID == id).FirstOrDefault();
        }
        public static Monster MonsterByID(int id)
        {
            return Monsters.Where(monster => monster.ID == id).FirstOrDefault();
        }
        public static Quest QuestByID(int id)
        {
            return Quests.Where(quest => quest.ID == id).FirstOrDefault();
        }
        public static Skill SkillByID(int id)
        {
            return Skills.Where(skill => skill.ID == id).FirstOrDefault();
        }
    }
}
