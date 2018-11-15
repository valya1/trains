using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Loco.Engines
{
    class V8DieselEngine : Loco.V8DieselEngine
    {
        public int GetPower()
        {
            return 12000;
        }
    }
}
