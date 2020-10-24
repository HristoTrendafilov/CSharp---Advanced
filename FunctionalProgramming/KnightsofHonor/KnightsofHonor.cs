using System;
using System.Linq;
namespace KnightsofHonor
{
    class KnightsofHonor
    {
        static void Main(string[] args)
        {
            Action<string> print = x => Console.WriteLine($"Sir {x}");

            Console.ReadLine()
                .Split()
                .ToList()
                .ForEach(print);
        }
    }
}
