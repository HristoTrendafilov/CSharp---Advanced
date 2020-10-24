using System;

namespace GenericBoxofString
{
    public class Program
    {
       public static void Main(string[] args)
        {
            var counter = int.Parse(Console.ReadLine());
            for (int i = 0; i < counter; i++)
            {
                var command = int.Parse(Console.ReadLine());
                var box = new Box<int>(command);
                Console.WriteLine(box);
            }
        }
    }
}
