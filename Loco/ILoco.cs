using ConsoleApp3.Loco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    interface ILoco<out T> : IRollingStock where T: V8DieselEngine
    {
        T GetLocoEngine();
    }
}
