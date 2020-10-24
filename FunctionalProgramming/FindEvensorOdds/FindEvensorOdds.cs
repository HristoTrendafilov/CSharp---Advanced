using System;
using System.Linq;
namespace FindEvensorOdds
{
    class FindEvensorOdds
    {
        static void Main(string[] args)
        {
            var range = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var command = Console.ReadLine();

            if (command == "odd")
            {
                for (int i = range[0]; i <= range[1]; i++)
                {
                    if (i % 2 == 1)
                    {
                        Console.Write($"{i} ");
                    }
                }
            }
            else
            {
                for (int i = range[0]; i <= range[1]; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write($"{i} ");
                    }
                }
            }
        }
    }
}
