using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicProject
{
    static class World
    {
        public static readonly List<Location> Locations = new List<Location>();
        public static readonly List<Item> Items = new List<Item>();
        public static readonly List<Monster> Monsters = new List<Monster>();
        public static readonly List<Quest> Quests = new List<Quest>();
        public static List<QuestType> QuestTypes;
        public static readonly List<Skill> Skills = new List<Skill>();
        public static List<SkillType> skillTypes;

        //Location ID

        //Item ID

            //Weapon ID
            //Potion ID

        //Monster ID

        //Quest ID
            //Type 1
            //Type 2
            //Type 3
        //Skill ID
            //Type 1
            //Type 2
            //Type 3
            //Type 4
            //Type 5

        static World()
        {
            PopulateTypeQuest();
            PopulateTypeSkill();
            PopulateLocation();
            PopulateMonster();
            PopulateQuest();
            PopulateSkill();
            PopulateItem();
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

        }
        static void PopulateItem()
        {

        }
        static void PopulateMonster()
        {

        }
        static void PopulateQuest()
        {

        }
        static void PopulateSkill()
        {

        }

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
            return Monsters.Where(monster  => monster.ID == id).FirstOrDefault();
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
