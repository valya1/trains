using ConsoleApp3.Vags.Cargo;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Carriage
{
    class CargoBlock : CarriageBlock<CargoVag>
    {
        public CargoBlock(List<CargoVag> carriages) : base(new LinkedList<CargoVag>(carriages)){} 

        public CargoBlock(params CargoVag[] vags)
            : base(new LinkedList<CargoVag>(new List<CargoVag>(vags))) { }
    }
}
