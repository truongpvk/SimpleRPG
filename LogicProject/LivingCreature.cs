using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace LogicProject
{
    public class LivingCreature : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null) { PropertyChanged(this, new PropertyChangedEventArgs(name)); }
        }
        private float _currentHP;
        public float CurrentHitPoint
        {
            get { return _currentHP; }
            set
            {
                _currentHP = value;
                OnPropertyChanged($"{nameof(CurrentHitPoint)}");
            }
        }
        private float _maxHP;
        public float MaximumHitPoint
        {
            get { return _maxHP; }
            set
            {
                _maxHP = value;
                OnPropertyChanged($"{nameof(MaximumHitPoint)}");
            }
        }
        private float _maxDamage;
        public float MaximumDamage
        {
            get { return _maxDamage; }
            set
            {
                _maxDamage = value;
                OnPropertyChanged($"{nameof(MaximumDamage)}");
            }
        }
        private float _armor;
        public float MaxArmor
        {
            get { return _armor; }
            set
            {
                _armor = value;
                OnPropertyChanged($"{nameof(MaxArmor)}");
            }
        }

        public LivingCreature() { }
        public LivingCreature(float currentHitPoint, float maximumHitPoint, float max_damage, float maxArmor)
        {
            CurrentHitPoint = currentHitPoint; MaximumHitPoint = maximumHitPoint;
            MaximumDamage = max_damage; MaxArmor = maxArmor;
        }
    }
}
