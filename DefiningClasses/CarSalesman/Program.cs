using System;
using System.Collections.Generic;
using System.Linq;
namespace CarSalesman
{
    class Program
    {
        static void Main(string[] args)
        {
            var counter = int.Parse(Console.ReadLine());
            var engineList = new List<Engine>();
            var carList = new List<Car>();

            for (int i = 0; i < counter; i++)
            {
                var command = Console.ReadLine().Split();
                var model = "n/a";
                var power = "n/a";
                var displacement = "n/a";
                var efficiency = "n/a";
                for (int j   = 0; j < command.Length; j++)
                {
                    if (j == 0)
                    {
                        model = command[j];
                    }
                    else if (j == 1)
                    {
                        power = command[j];
                    }
                    else if (j == 2)
                    {
                        if (command[j].All(char.IsDigit))
                        {
                            displacement = command[j];
                        }
                        else
                        {
                            efficiency = command[j];
                        }
                    }
                    else if (j == 3)
                    {
                        if (command[j].All(char.IsDigit))
                        {
                            displacement = command[j];
                        }
                        else 
                        {
                            efficiency = command[j];
                        }
                    }
                }

                var currentEngine = new Engine(model,power,displacement,efficiency); 
                engineList.Add(currentEngine);
            }
            var counter2 = int.Parse(Console.ReadLine());

            for (int i = 0; i < counter2; i++)
            {
                var command = Console.ReadLine().Split();
                var model = "n/a";
                var engine = command[1];
                var weight = "n/a";
                var color = "n/a";

                for (int j = 0; j < command.Length; j++)
                {
                    if (command[j]=="")
                    {
                        continue;
                    }
                    if (j == 0)
                    {
                        model = command[j];
                    }
                    else if (j == 2)
                    {
                        if (command[j].All(char.IsDigit))
                        {
                            weight = command[j];
                        }
                        else
                        {
                            color = command[j];
                        }
                    }
                    else if (j == 3)
                    {
                        if (command[j].All(char.IsDigit))
                        {
                            weight = command[j];
                        }
                        else
                        {
                            color = command[j];
                        }
                    }
                }
                Engine engineCar = engineList.FirstOrDefault(x => x.Model==engine);
                var currentCar = new Car(model, weight, color, engineCar);
                carList.Add(currentCar);
            }
            for (int i = 0; i < carList.Count; i++)
            {
                var currentCar = carList[i];
                Console.WriteLine($"{currentCar.Model}:");
                Console.WriteLine($"  {currentCar.Engine.Model}:");
                Console.WriteLine($"    Power: {currentCar.Engine.Power}");
                Console.WriteLine($"    Displacement: {currentCar.Engine.Displacement}");
                Console.WriteLine($"    Efficiency: {currentCar.Engine.Efficiency}");
                Console.WriteLine($"  Weight: {currentCar.Weight}");
                Console.WriteLine($"  Color: {currentCar.Color}");
            }
        }
    }
}
