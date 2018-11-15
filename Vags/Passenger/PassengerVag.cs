using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class PassengerVag : IRollingStock
    {
        private int totalSeatsCount;

        public int FreeSeatsCount
        {
            get
            {
                return totalSeatsCount - occupiedSeats;
            }
        }

        private int occupiedSeats;

        int OccupiedSeats { get; set; } = 0;

        public PassengerVag(int seatsCount)
        {
            totalSeatsCount = seatsCount;
        }

        public int GetMaxSpeed()
        {
            return 120;
        }

        public float GetWeight()
        {
            return 1.2f + occupiedSeats * 0.08f;
        }
    }
}
