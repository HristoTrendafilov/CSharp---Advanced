using System;
using System.Linq;
namespace CustomComparator
{
    class CustomComparator
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var evenNumbers = numbers.Where(x => x % 2 == 0).ToArray();
            var oddNumbers = numbers.Where(x => Math.Abs(x) % 2 == 1).ToArray();
            Array.Sort(evenNumbers);
            Array.Sort(oddNumbers);
            foreach (var item in evenNumbers)
            {
                Console.Write($"{item} ");
            }
            foreach (var item in oddNumbers)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
