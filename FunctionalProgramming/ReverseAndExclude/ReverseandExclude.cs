using System;
using System.Linq;
namespace ReverseAndExclude
{
    class ReverseandExclude
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var devisibleNumber = int.Parse(Console.ReadLine());

            var result = numbers.Where(x => x%devisibleNumber!=0).Reverse().ToArray();

            Console.WriteLine(string.Join(" ",result));
        }
    }
}
