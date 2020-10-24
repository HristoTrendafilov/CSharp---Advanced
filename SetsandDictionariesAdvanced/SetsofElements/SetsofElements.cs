using System;
using System.Collections.Generic;
using System.Linq;
namespace SetsofElements
{
    class SetsofElements
    {
        static void Main(string[] args)
        {
            var number = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var firstSet = new HashSet<string>();
            var secondSet = new HashSet<string>();

            for (int i = 0; i < number[0]; i++)
            {
                var command = Console.ReadLine();
                firstSet.Add(command);
            }
            for (int i = 0; i < number[1]; i++)
            {
                var command = Console.ReadLine();
                secondSet.Add(command);
            }
            foreach (var set in firstSet)
            {
                if (secondSet.Contains(set))
                {
                    Console.Write($"{set} ");
                }
            }
        }
    }
}
