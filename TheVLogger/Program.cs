using System;
using System.Collections.Generic;
using System.Linq;

namespace TheVLogger
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var vloggersData = new Dictionary<string, Dictionary<string, SortedSet<string>>>();
           // var vloggersSet = new HashSet<string>();

            while (input!="Statistics")
            {
                var commands = input.Split();

                string name = commands[0];
                string activity = commands[1];
                string targetName = commands[2];


                if (activity == "joined")
                {
                    if (!vloggersData.ContainsKey(name))
                    {
                        vloggersData.Add(name, new Dictionary<string, SortedSet<string>>());
                        vloggersData[name].Add("following", new SortedSet<string>());
                        vloggersData[name].Add("followers", new SortedSet<string>());
                    }
                }


                else if (activity == "followed")
                {
                    bool IsEqualName = name == targetName;

                    if (vloggersData.ContainsKey(name) && vloggersData.ContainsKey(targetName) && !IsEqualName)
                    {
                        vloggersData[name]["following"].Add(targetName);
                        vloggersData[targetName]["followers"].Add(name);
                    }

                    
                }
                

                input = Console.ReadLine();
            }



            Console.WriteLine($"The V-Logger has a total of {vloggersData.Count} vloggers in its logs.");

            var sortedVloggers = vloggersData.OrderByDescending(x => x.Value["followers"].Count).
                ThenBy(c => c.Value["following"].Count);
            int counter = 0;
            foreach (var item in sortedVloggers)
            {
                Console.WriteLine($"{++counter}. {item.Key} : {item.Value["followers"].Count} followers," +
                    $" {item.Value["following"].Count} following");

                if (counter == 1)
                {
                    foreach (var follower in item.Value["followers"])
                    {
                        Console.WriteLine($"*  {follower}");
                    }
                }
            }
        }
    }
}
