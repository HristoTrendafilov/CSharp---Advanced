using System;
using System.Linq;
namespace AppliedArithmetics
{
    class AppliedArithmetics
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            while (true)
            {
                var command = Console.ReadLine();
                if (command == "end")
                {
                    break;
                }
                else if (command== "add")
                {
                    numbers = numbers.Select(x => x + 1).ToArray();
                }
                else if(command== "multiply")
                {
                    numbers = numbers.Select(x => x * 2).ToArray();
                }
                else if(command== "subtract")
                {
                    numbers = numbers.Select(x => x - 1).ToArray();
                }
                else if(command== "print")
                {
                    Console.WriteLine(string.Join(" ",numbers));
                }
            }
        }
    }
}
