using System;

namespace TriFunction
{
    class TriFunction
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var names = Console.ReadLine().Split();

            var correnctName = string.Empty;
            for (int i = 0; i < names.Length; i++)
            {
                var nameToChar = names[i].ToCharArray();
                var currenctSum = 0;
                foreach (var item in nameToChar)
                {
                    currenctSum += item;
                }
                if (currenctSum >= number)
                {
                    Console.WriteLine(names[i]);
                    break;
                }
            }
        }
    }
}
