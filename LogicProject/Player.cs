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
        private float _currentMana;
        public float CurrentManaPoints
        {
            get { return _currentMana; }
            set
            {
                _currentMana = value;
                OnPropertyChanged($"{nameof(CurrentManaPoints)}");
            }
        }
        private float _maxMana;
        public float MaximumManaPoints
        {
            get { return _maxMana; }
            set
            {
                _maxMana = value;
                OnPropertyChanged($"{nameof(MaximumManaPoints)}");
            }
        }
        private int _exp;
        public int ExpPoints
        {
            get { return _exp; }
            set
            {
                _exp = value;
                OnPropertyChanged($"{nameof(ExpPoints)}");
                OnPropertyChanged($"{nameof(Level)}");
                ChangedStatusByLevel(Level);
            }
        }
        public int Level { get { return (ExpPoints / 100) + 1; } }
        public List<PlayerSkill> PlayerSkills { get; set; }
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
            PlayerSkills = new List<PlayerSkill>();
        }

        public static Player CreateDefaultPlayer()
        {
            Player newPlayer = new Player(100, 100, 10, 1, 100, 100, 0);
            return newPlayer;
        }

        public void ChangedStatusByLevel(int level)
        {
            MaximumHitPoint = 100 * (float)Math.Pow(1.1, level - 1);
            MaximumManaPoints = 100 * (float)Math.Pow(1.1, level - 1);
            MaximumDamage = 10 * (float)Math.Pow(1.2, level - 1);
            MaxArmor = 1 + 2 * level - 1;
        }
    }
}
