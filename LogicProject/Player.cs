using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace LogicProject
{
    public class Player : LivingCreature
    {
        public float CurrentManaPoints { get; set; }
        public float MaximumManaPoints { get; set; }
        public int ExpPoints { get; set; }
        public int Level { get { return (ExpPoints / 100) + 1; } }
        public List<Skill> PlayerSkill { get; set; }
        public Skill FirstSkill { get; set; }
        public Skill SecondSkill { get; set; }
        public Skill ThirdSkill { get; set; }
        public List<InventoryItem> Inventory { get; set; }
        public List<PlayerQuest> playerQuest { get; set; }
        public Player() { }

        public Player(float current_hp, float max_hp, float max_damage, float armor, 
            float current_mana, float max_mana, int exp) : base(current_hp, max_hp, max_damage, armor) 
        {
            CurrentManaPoints = current_mana; MaximumManaPoints = max_mana;
            ExpPoints = exp;
            Inventory = new List<InventoryItem>();
            playerQuest = new List<PlayerQuest>();
            PlayerSkill = new List<Skill>();
        }

        public static Player CreateDefaultPlayer()
        {
            Player newPlayer = new Player(100, 100, 10, 1, 100, 100, 0);
            return newPlayer;
        }
    }
}
