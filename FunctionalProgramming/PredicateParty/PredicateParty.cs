using System;
using System.Linq;
namespace PredicateParty
{
    class PredicateParty
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine().Split().ToList();

            while (true)
            {
                var command = Console.ReadLine().Split();
                if(command[0]== "Party!")
                {
                    break;
                }
                else if (command[0] == "Remove" && command[1]== "StartsWith")
                {
                    var text = command[2];
                    names.RemoveAll(x => x.StartsWith(text));
                }
                else if (command[0] == "Remove" && command[1] == "EndsWith")
                {
                    var text = command[2];
                    names.RemoveAll(x => x.EndsWith(text));
                }
                else if(command[0]== "Double" && command[1]== "StartsWith")
                {
                    var text = command[2];
                    var count = 0;
                    var name = string.Empty;
                    for (int i = 0; i < names.Count; i++)
                    {
                        if (names[i].StartsWith(text))
                        {
                            count++;
                            name = names[i];
                        }
                    }
                    for (int i = 0; i < count; i++)
                    {
                        names.Add(name);
                    }
                }
                else if (command[0] == "Double" && command[1] == "EndsWith")
                {
                    var text = command[2];
                    var count = 0;
                    var name = string.Empty;
                    for (int i = 0; i < names.Count; i++)
                    {
                        if (names[i].EndsWith(text))
                        {
                            count++;
                            name = names[i];
                        }
                    }
                    for (int i = 0; i < count; i++)
                    {
                        names.Add(name);
                    }
                }
                else if(command[0]=="Double" && command[1] == "Length")
                {
                    int lenght = int.Parse(command[2]);
                    var count = 0;
                    var name = string.Empty;
                    for (int i = 0; i < names.Count; i++)
                    {
                        if (names[i].Length==lenght)
                        {
                            count++;
                            name = names[i];
                        }
                    }
                    for (int i = 0; i < count; i++)
                    {
                        names.Add(name);
                    }
                }
            }
            var sortedNames = names.OrderBy(x => x);
            if (names.Count > 0)
            {
                Console.WriteLine(string.Join(", ",sortedNames)+ " are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }
    }
}
