using System;
using System.Linq;
namespace PredicateForNames
{
    class PredicateForNames
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var result = Console.ReadLine().Split().Where(x => x.Length <= number);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}
