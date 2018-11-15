using ConsoleApp3.Carriage;
using ConsoleApp3.Loco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class PassengerTrain : Train<PassengerVag>
    {
        private int freeSeats = -1;

        public PassengerTrain(ILoco<V8DieselEngine> locomotive, PassengerBlock carriageBlock)
            : base(locomotive, carriageBlock) { }

        int FreeSeats
        {
            get
            {
                if (freeSeats != -1)
                    return freeSeats;
                freeSeats = 0;
                foreach (PassengerVag carriage in carriages)
                {
                    freeSeats += carriage.FreeSeatsCount;
                }
                return freeSeats;
            }
        }
    }
}
