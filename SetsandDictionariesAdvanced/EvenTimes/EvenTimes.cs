using System;
using System.Collections.Generic;

namespace EvenTimes
{
    class EvenTimes
    {
        static void Main(string[] args)
        {
            var counter = int.Parse(Console.ReadLine());
            var numberCount = new Dictionary<int, int>();

            for (int i = 0; i < counter; i++)
            {
                var number = int.Parse(Console.ReadLine());

                if (!numberCount.ContainsKey(number))
                {
                    numberCount.Add(number, 0);
                }
                numberCount[number]++;
            }
            foreach (var item in numberCount)
            {
                if (item.Value % 2 == 0)
                {
                    Console.WriteLine(item.Key);
                }
            }
        }
    }
}
