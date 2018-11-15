using System;
using System.Collections.Generic;
using System.Collections;
using ConsoleApp3.Carriage;
using ConsoleApp3.Vags.Cargo;
using ConsoleApp3.Loco;
using ConsoleApp3.Loco.Engines;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            PassengerBlock passengerVags = new PassengerBlock( 
                new PassengerVag(120), new PassengerVag(100), new PassengerVag(50)
             );

            ILoco<Loco.V8DieselEngine> loco = new DieselLocomotiveV1();

            Console.WriteLine(loco.GetLocoEngine().GetPower());

            ILoco<Loco.V8DieselEngine> loco2 = new ElectricLocomotiveV1();
            Console.WriteLine(loco2.GetLocoEngine().GetPower());

            Train<PassengerVag> passengerTrain = new PassengerTrain(loco, passengerVags);



            //Console.WriteLine("Passenger train Before Hook: {0}", passengerTrain.CarriageCount);
            //passengerTrain.Hook(new PassengerBlock(new PassengerVag(10), new PassengerVag(11)));
            //Console.WriteLine("Passenger train After Hook 2 vags: {0}", passengerTrain.CarriageCount);

            //passengerTrain.Unhook(1);
            //Console.WriteLine("Passenger train After UnHook All Vags after first: {0}", passengerTrain.CarriageCount);



            //CargoTrain cargoTrain = new CargoTrain(loco, new CargoBlock(new HopperVag()));

            //Console.WriteLine("Cargo train Before Hook:{0}", cargoTrain.CarriageCount);
            //cargoTrain.Hook(new CargoBlock(new HopperVag()));
            //Console.WriteLine("Cargo train After Hook:{0}", cargoTrain.CarriageCount);





        }
    }
}
