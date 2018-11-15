using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Vags.Cargo
{
    abstract class CargoVag : IRollingStock
    {
        public int GetMaxSpeed()
        {
            switch (GetCargoType())
            {
                case CarriageType.HOPPER:
                case CarriageType.TANK:
                    return 80;
                case CarriageType.FRIDGE:
                    return 100;
                case CarriageType.GONDOLA:
                    return 90;
                default:
                    return 120;
            }
        }

        /// <returns>
        /// Вес вагона в тоннах
        /// </returns>
        public abstract float GetWeight();

        /// <returns>
        /// Тип груза
        /// </returns>
        public abstract CarriageType GetCargoType();
    }
}
