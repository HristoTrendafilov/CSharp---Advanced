using System;
using System.Linq;
namespace CustomMinFunction
{
    class CustomMinFunction
    {
        static void Main(string[] args)
        {
            var number = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var result = number.Min();
            Console.WriteLine(result);

        }
  
        
    }
}
