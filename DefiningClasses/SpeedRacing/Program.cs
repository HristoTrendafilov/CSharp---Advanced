using System;
using System.Collections.Generic;

namespace SpeedRacing
{
    class Program
    {
        static void Main(string[] args)
        {
            var listOfCars = new List<Car>();
            var counter = int.Parse(Console.ReadLine());

            for (int i = 0; i < counter; i++)
            {
                var command = Console.ReadLine().Split();
                var model = command[0];
                var fuelAmount = double.Parse(command[1]);
                var fuelConsumptionFor1km = double.Parse(command[2]);

                var currentCar = new Car();
                currentCar.FuelAmount = fuelAmount;
                currentCar.FuelConsumptionPerKilometer = fuelConsumptionFor1km;
                currentCar.Model = model;
                currentCar.TravelledDistance = 0;
                listOfCars.Add(currentCar);
            }
            var car = new Car();
            while (true)
            {
                var command = Console.ReadLine().Split();

                if (command[0] == "End")
                {
                    break;
                }

                var carModel = command[1];
                var amountOfKm = int.Parse(command[2]);
                car.CarMovingDistance(carModel, amountOfKm,listOfCars);
            }
            for (int i = 0; i < listOfCars.Count; i++)
            {
                Console.WriteLine($"{listOfCars[i].Model} {listOfCars[i].FuelAmount:f2} {listOfCars[i].TravelledDistance}");
            }
        }
    }
}
