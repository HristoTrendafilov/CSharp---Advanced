using System;
using System.Collections.Generic;

namespace PeriodicTable
{
    class PeriodicTable
    {
        static void Main(string[] args)
        {
            var counter = int.Parse(Console.ReadLine());
            var set = new SortedSet<string>();

            for (int i = 0; i < counter; i++)
            {
                var compounds = Console.ReadLine().Split();
                foreach (var item in compounds)
                {
                    set.Add(item);
                }
            }
            Console.WriteLine(string.Join(" ",set));
        }
    }
}
