using ConsoleApp3.Loco;
using ConsoleApp3.Loco.Engines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class ElectricLocomotiveV1 : ILoco<Loco.V8DieselEngine>
    {
        public V8DieselEngine GetLocoEngine()
        {
            return new ElectricEngineV1();
        }

        public int GetMaxSpeed()
        {
            return 140;
        }

        public float GetPower()
        {
            return 8040;
        }

        public float GetWeight()
        {
            return 1.0f;
        }
    }
}
