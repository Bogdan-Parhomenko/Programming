using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    public class EarthElemental : Creature
    {
        private int _physicalDamage;

        private int _elementalDamage;

        public void SetDamage(int physicalDamage, int elementalDamage)
        {
            _elementalDamage = elementalDamage;
            _physicalDamage = physicalDamage;
        }

        public int GetDamage(bool isPhysicalDamage)
        {
            if (isPhysicalDamage)
            {
                return _physicalDamage;
            }
            else
            {
                return _elementalDamage;
            }
        }

        public override int CalculateDamage()
        {
            return GetQuantity() * GetDamage(true) + GetDamage(false);
        }

        public EarthElemental(int hitPoints, int quantity, int physicalDamage, int elementalDamage)
        {
            _hitPoints = hitPoints;
            _quantity = quantity;
            _physicalDamage = physicalDamage;
            _elementalDamage = elementalDamage;
        }
    }
}
