using System;
using System.Collections.Generic;
using System.Text;

namespace SpeedRacing
{
    class Car
    {

        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerKilometer { get; set; }
        public double TravelledDistance { get; set; }

        public void CarMovingDistance(string carModel,int amountOfKm,List<Car> listOfCars)
        {
            for (int i = 0; i < listOfCars.Count; i++)
            {
                if (listOfCars[i].Model == carModel)
                {
                    if (listOfCars[i].FuelConsumptionPerKilometer * amountOfKm <= listOfCars[i].FuelAmount)
                    {
                        listOfCars[i].FuelAmount -= listOfCars[i].FuelConsumptionPerKilometer * amountOfKm;
                        listOfCars[i].TravelledDistance += amountOfKm;
                    }
                    else
                    {
                        Console.WriteLine("Insufficient fuel for the drive");
                    }
                }
            }
        }
    }
}
