using ConsoleApp3.Loco;
using ConsoleApp3.Loco.Engines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class DieselLocomotiveV1 : ILoco<Loco.V8DieselEngine>
    {
        public float DieselConsumingPer100Km
        {
            get
            {
                return 35.2f;
            }
        }

        public V8DieselEngine GetLocoEngine()
        {
            return new Loco.Engines.V8DieselEngine();
        }

        public int GetMaxSpeed()
        {
            return 90;
        }

        public float GetPower()
        {
            return 6000;
        }

        public float GetWeight()
        {
            return 1.5f;
        }
    }
}
