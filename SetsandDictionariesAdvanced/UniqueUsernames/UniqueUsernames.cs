using System;
using System.Collections.Generic;

namespace UniqueUsernames
{
    class UniqueUsernames
    {
        static void Main(string[] args)
        {
            var counter = int.Parse(Console.ReadLine());
            var userNames = new List<string>();

            for (int i = 0; i < counter; i++)
            {
                var name = Console.ReadLine();
                if (!userNames.Contains(name))
                {
                    userNames.Add(name);
                }
            }
            foreach (var name in userNames)
            {
                Console.WriteLine(name);
            }

        }
    }
}
