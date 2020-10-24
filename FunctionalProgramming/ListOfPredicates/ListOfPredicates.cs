using System;
using System.Linq;
namespace ListOfPredicates
{
    class ListOfPredicates
    {
        static void Main(string[] args)
        {
            var endOfRange = int.Parse(Console.ReadLine());
            var sequence = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var result = new System.Collections.Generic.List<int>();

            for (int i = 1; i <= endOfRange; i++)
            {
                var isDevisible = false;
                for (int j = 0; j < sequence.Length; j++)
                {
                    if (i%sequence[j] == 0)
                    {
                        isDevisible = true;
                    }
                    else
                    {
                        isDevisible = false;
                        continue;
                    }
                }
                if (isDevisible)
                {
                    result.Add(i);
                }
            }
            Console.WriteLine(string.Join(" ",result));
        }
    }
}
