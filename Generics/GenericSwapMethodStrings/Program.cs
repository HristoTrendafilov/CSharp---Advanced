using System;
using System.Collections.Generic;

namespace GenericSwapMethodStrings
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var counter = int.Parse(Console.ReadLine());
            var box = new Box<int>();
            for (int i = 0; i < counter; i++)
            {
                var command = int.Parse(Console.ReadLine());
                box.AddElements(command);
            }
            var command2 = Console.ReadLine().Split();
            var firstIndex = int.Parse(command2[0]);
            var secondIndex = int.Parse(command2[1]);
            box.SwapElements(firstIndex, secondIndex);
            Console.WriteLine(box.ToString());

        }

    }
}
