using ConsoleApp3.Loco;
using ConsoleApp3.Vags.Cargo;

namespace ConsoleApp3
{
    class CargoTrain : Train<CargoVag>
    {
        public CargoTrain(ILoco<V8DieselEngine> locomotive, CarriageBlock<CargoVag> carriageBlock) 
            : base(locomotive, carriageBlock){ }
    }
}
