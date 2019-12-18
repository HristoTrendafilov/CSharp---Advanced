using System;
using System.Collections.Generic;
using System.Linq;
namespace DatingApp
{
    class DatingApp
    {
        static void Main(string[] args)
        {
            var males = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            var female = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            
            var matches = 0;

            while (males.Count>0 && female.Count>0)
            {
                if (males.Peek() <= 0)
                {
                    males.Pop();
                    continue;
                }
                if (female.Peek() <= 0)
                {
                    female.Dequeue();
                    continue;
                }
                if (males.Peek() % 25 == 0)
                {
                    males.Pop();
                    males.Pop();
                    continue;
                }
                if (female.Peek() % 25 == 0)
                {
                    female.Dequeue();
                    female.Dequeue();
                    continue;
                }
                
                var currMale = males.Pop();
                var currFemale = female.Dequeue();
                
                if (currFemale != currMale)
                {
                    males.Push(currMale - 2);
                }
                else
                {
                    matches++;
                }
            }
            
            Console.WriteLine($"Matches: {matches}");
            
            if (males.Count > 0)
            {
                Console.WriteLine($"Males left: {string.Join(", ",males)}");
            }
            else
            {
                Console.WriteLine("Males left: none");
            }
            if (female.Count > 0)
            {
                Console.WriteLine($"Females left: {string.Join(", ",female)}");
            }
            else
            {
                Console.WriteLine("Females left: none");
            }
        }
    }
}
