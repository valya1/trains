using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Loco.Engines
{
    class ElectricEngineV1 : Loco.V8DieselEngine
    {
        public int GetPower()
        {
            return 20000;
        }
    }
}
