using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Vags.Cargo
{
    class HopperVag : CargoVag
    {
        public override CarriageType GetCargoType()
        {
            return CarriageType.HOPPER;
        }

        public override float GetWeight()
        {
            return 1.1f; 
        }
    }
}
