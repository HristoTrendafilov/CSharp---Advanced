using System;
using System.Collections.Generic;
using System.Linq;
namespace TheV_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            var vloggers = new Dictionary<string, Vloggers>();
            var vloggersCount = 0;

            while (true)
            {
                var command = Console.ReadLine().Split();
                if (command[0] == "Statistics")
                {
                    break;
                }
                else if(command[1]=="joined" && !vloggers.ContainsKey(command[0]))
                {
                    var vloggerStats = new Vloggers();
                    vloggerStats.Followers = new List<string>();
                    vloggerStats.Followings = new List<string>();
                    vloggers.Add(command[0], vloggerStats);
                    vloggersCount++;
                }
                else if(command[1]== "followed" && vloggers.ContainsKey(command[0]) && vloggers.ContainsKey(command[2]))
                {
                    if (vloggers[command[0]] != vloggers[command[2]] && !vloggers[command[0]].Followings.Contains(command[2]))
                    {
                        vloggers[command[0]].Followings.Add(command[2]);
                        vloggers[command[2]].Followers.Add(command[0]);
                    }
                }
            }
            Console.WriteLine($"The V-Logger has a total of {vloggersCount} vloggers in its logs.");
            var mostPopularVloggerCount = int.MinValue;
            var mostPopularVlogger = string.Empty;

            foreach (var vlogger in vloggers)
            {
                if (vlogger.Value.Followers.Count == mostPopularVloggerCount)
                {
                    if(vlogger.Value.Followings.Count< vloggers[mostPopularVlogger].Followings.Count)
                    {
                        mostPopularVlogger = vlogger.Key;
                    }
                }
                if (vlogger.Value.Followers.Count>mostPopularVloggerCount)
                {
                    var currentCount = vlogger.Value.Followers.Count;
                    mostPopularVloggerCount = currentCount;
                    mostPopularVlogger = vlogger.Key;
                }
            }
            Console.WriteLine($"1. {mostPopularVlogger} : {vloggers[mostPopularVlogger].Followers.Count} followers, {vloggers[mostPopularVlogger].Followings.Count} following");


            foreach (var vlogger in vloggers[mostPopularVlogger].Followers.OrderBy(x=>x))
            {
                Console.WriteLine($"*  {vlogger}");
            }
            var count = 2;
            foreach (var vlogger in vloggers.OrderByDescending(x=>x.Value.Followers.Count).ThenBy(x=>x.Value.Followings.Count))
            {
                if (vlogger.Key != mostPopularVlogger)
                {
                    Console.WriteLine($"{count}. {vlogger.Key} : {vlogger.Value.Followers.Count} followers, {vlogger.Value.Followings.Count} following");
                    count++;
                }
            }
        }
    }
    class Vloggers
    {
        public List<string> Followers { get; set; }
        public List<string> Followings { get; set; }

    }
}
