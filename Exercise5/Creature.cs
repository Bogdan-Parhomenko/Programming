using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    public abstract class Creature
    {
        protected int _hitPoints;

        protected int _quantity;

        public void SetQuantity(int quantity)
        {
            _quantity = quantity;
        }

        public int GetQuantity()
        {
            return _quantity;
        }

        public void SetHitPoints(int hitPoints)
        {
            _hitPoints = hitPoints;
        }

        public int GetHitPoints()
        {
            return _hitPoints;
        }

        public abstract int CalculateDamage();
    }
}
