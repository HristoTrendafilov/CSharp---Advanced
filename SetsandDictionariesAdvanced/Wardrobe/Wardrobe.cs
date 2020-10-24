using System;
using System.Collections.Generic;

namespace Wardrobe
{
    class Wardrobe
    {
        static void Main(string[] args)
        {
            var counter = int.Parse(Console.ReadLine());
            var colorAndClothes = new Dictionary<string, Dictionary<string,int>>();

            for (int i = 0; i < counter; i++)
            {
                var colorOfClothes = Console.ReadLine().Split(" -> ");
                var color = colorOfClothes[0];

                if (!colorAndClothes.ContainsKey(color))
                {
                    colorAndClothes.Add(color, new Dictionary<string, int>());
                    var clothes = colorOfClothes[1].Split(',');

                    foreach (var cloth in clothes)
                    {
                        if (colorAndClothes[color].ContainsKey(cloth))
                        {
                            colorAndClothes[color][cloth]++;
                        }
                        else
                        {
                            colorAndClothes[color].Add(cloth, 1);
                        }
                    }
                }
                else if (colorAndClothes.ContainsKey(color))
                {
                    var clothes = colorOfClothes[1].Split(',');
                  
                    foreach (var cloth in clothes)
                    {
                        if (colorAndClothes[color].ContainsKey(cloth))
                        {
                            colorAndClothes[color][cloth]++;
                        }
                        else
                        {
                            colorAndClothes[color].Add(cloth, 1);
                        }
                    }
                }
            }
            var dressNeeded = Console.ReadLine().Split();

            foreach (var item in colorAndClothes)
            {
                Console.WriteLine($"{item.Key} clothes:");

                foreach (var cloth in item.Value)
                {
                    if (item.Key == dressNeeded[0] && cloth.Key == dressNeeded[1])
                    {
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value}");
                    }

                }

            }
        }
    }
}
