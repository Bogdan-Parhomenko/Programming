using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    public class Crossbowman : Creature
    {
        private int _rangedDamage;

        public void SetDamage(int rangedDamage)
        {
            _rangedDamage = rangedDamage;
        }

        public int GetDamage()
        {
            return _rangedDamage;
        }

        public override int CalculateDamage()
        {
            return GetQuantity() * GetDamage();
        }

        public Crossbowman(int hitPoints, int quantity, int rangedDamage)
        {
            _hitPoints = hitPoints;
            _quantity = quantity;
            _rangedDamage = rangedDamage;
        }
    }
}
