using System;
using System.Collections.Generic;

namespace RawData
{
    class Program
    {
        static void Main(string[] args)
        {
            var counter = int.Parse(Console.ReadLine());
            var allCars = new List<Car>();

            for (int i = 0; i < counter; i++)
            {
                var command = Console.ReadLine().Split();
                var model = command[0];
                var engineSpeed = double.Parse(command[1]);
                var enginePower = double.Parse(command[2]);
                var cargoWeight = double.Parse(command[3]);
                string cargoType = command[4];
                var tire1Pressure = double.Parse(command[5]);
                var tire1Age = double.Parse(command[6]);
                var tire2Pressure = double.Parse(command[7]);
                var tire2Age = double.Parse(command[8]);
                var tire3Pressure = double.Parse(command[9]);
                var tire3Age = double.Parse(command[10]);
                var tire4Pressure = double.Parse(command[11]);
                var tire4Age = double.Parse(command[12]);

                var engine = new Engine(engineSpeed, enginePower);
                var cargo = new Cargo(cargoWeight, cargoType);
                var tire = new Tire(tire1Pressure, tire1Age, tire2Pressure, tire2Age, tire3Pressure, tire3Age, tire4Pressure, tire4Age);
                var car = new Car(model, engine, cargo, tire);
                allCars.Add(car);
            }
            var command2 = Console.ReadLine();
            if (command2 == "fragile")
            {
                for (int i = 0; i < allCars.Count; i++)
                {
                    if(allCars[i].Cargo.CargoType=="fragile" && allCars[i].Tire.Tire1Pressure<1 || allCars[i].Tire.Tire2Pressure<1 || allCars[i].Tire.Tire3Pressure<1 || allCars[i].Tire.Tire4Pressure < 1)
                    {
                        Console.WriteLine(allCars[i].Model);
                    }
                }
            }
            else if (command2 == "flamable")
            {
                for (int i = 0; i < allCars.Count; i++)
                {
                    if(allCars[i].Cargo.CargoType=="flamable" && allCars[i].Engine.EnginePower > 250)
                    {
                        Console.WriteLine(allCars[i].Model);
                    }
                }
            }
        }
    }
}
