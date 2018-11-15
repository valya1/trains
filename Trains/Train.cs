using ConsoleApp3.Carriage;
using ConsoleApp3.Loco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    abstract class Train<T> : IRollingStock where T: IRollingStock
    {
        protected ILoco<V8DieselEngine> locomotive;
        protected CarriageBlock<T> carriages;

        private int maxSpeed = -1;
        private float weight = -1;

        public int CarriageCount { get { return carriages.Count; } }

        public Train(ILoco<V8DieselEngine> locomotive, CarriageBlock<T> carriageBlock)
        {
            this.locomotive = locomotive;
            this.carriages = carriageBlock;
        }

        public int GetMaxSpeed()
        {
            if (maxSpeed != -1)
                return maxSpeed;

            maxSpeed = 500;
            foreach (IRollingStock carriage in carriages)
            {
               if(carriage.GetMaxSpeed() < maxSpeed)
                {
                    maxSpeed = carriage.GetMaxSpeed();
                }
            }
            return maxSpeed;
        }

        public float GetWeight()
        {
            if (weight != -1)
                return weight + locomotive.GetWeight();

            weight = 0;
            foreach(IRollingStock carriage in carriages)
            {
                weight += carriage.GetWeight();
            }
            return weight + locomotive.GetWeight();
        }


        public Train<T> Hook(CarriageBlock<T> block)
        {
            carriages = carriages.Hook(block);
            return this;
        }

        public Train<T> Unhook(int positionFrom)
        {
            carriages = carriages.Unhook(positionFrom);
            return this;
        }
    }
}
