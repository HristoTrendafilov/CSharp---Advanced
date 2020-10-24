using System;
using System.Collections.Generic;

namespace CountSymbols
{
    class CountSymbols
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            var charsAndCount = new SortedDictionary<char, int>();

            for (int i = 0; i < text.Length; i++)
            {
                var @char =(text[i]);
                if (!charsAndCount.ContainsKey(@char))
                {
                    charsAndCount.Add(@char, 0);
                }
                charsAndCount[@char]++;
            }
            foreach (var character in charsAndCount)
            {
                Console.WriteLine($"{character.Key}: {character.Value} time/s");
            }
        }
    }
}
