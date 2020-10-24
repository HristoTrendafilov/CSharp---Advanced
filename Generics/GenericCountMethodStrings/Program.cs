using System;

namespace GenericCountMethodStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            var box = new Box<double>();
            var counter = int.Parse(Console.ReadLine());

            for (int i = 0; i < counter; i++)
            {
                var command = double.Parse(Console.ReadLine());
                box.AddElements(command);
            }
            var command2 = double.Parse(Console.ReadLine());
            Console.WriteLine(box.CountOfElements(command2));
        }
    }
}
