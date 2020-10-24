using System;
using System.Linq;
namespace ActionPrint
{
    class ActionPrint
    {
        static void Main(string[] args)
        {
            Action<string> print = x => Console.WriteLine(x);

            Console.ReadLine()
                .Split()
                .ToList()
                .ForEach(print);
        }
    }
}
