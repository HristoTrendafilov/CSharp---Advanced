using System;
using System.Collections.Generic;
using System.Linq;
namespace PartyReservationFilterModule
{
    class PartyReservationFilterModule
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine().Split().ToList();
            var filters = new List<string>();

            while (true)
            {
                var command = Console.ReadLine().Split(";");
                if (command[0] == "Print")
                {
                    break;
                }
                else if(command[0]== "Add filter")
                {
                    filters.Add(command[1] + ";" + command[2]);
                }
                else if (command[0] == "Remove filter")
                {
                    filters.Remove(command[1] + ";" + command[2]);
                }
            }
            foreach (var filter in filters)
            {
                var filterToText = filter.Split(";");
                if (filterToText[0] == "Print")
                {
                    break;
                }
                else if(filterToText[0]== "Starts with")
                {
                    var text = filterToText[1];
                    names.RemoveAll(x => x.StartsWith(text));
                }
                else if (filterToText[0] == "Ends with")
                {
                    var text = filterToText[1];
                    names.RemoveAll(x => x.EndsWith(text));
                }
                else if (filterToText[0] == "Length")
                {
                    var text = int.Parse(filterToText[2]);
                    names.RemoveAll(x => x.Length==text);
                }
                else if (filterToText[0] == "Contains")
                {
                    var text = filterToText[1];
                    names.RemoveAll(x => x.Contains(text));
                }
            }
            Console.WriteLine(string.Join(" ",names));
        }
    }
}
