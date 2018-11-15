using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Carriage
{
    class PassengerBlock : CarriageBlock<PassengerVag>
    {
        public PassengerBlock(List<PassengerVag> carriages)
            : base(new LinkedList<PassengerVag>(carriages)) { }

        public PassengerBlock(params PassengerVag[] vags)
            : base(new LinkedList<PassengerVag>(new List<PassengerVag>(vags))) { }
    }
}
