using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAIN_EXAM_FINAL
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var forceData = new Dictionary<string, List<string>>();
            while (input != "Lumpawaroo")
            {
                if (input.Contains("|"))
                {
                    string[] command = input.Split(new[] { " ", "|" }, StringSplitOptions.RemoveEmptyEntries);
                    string forceSide = command[0];
                    string forceUser = command[1];

                    if (!forceData.ContainsKey(forceSide))
                    {
                        forceData.Add(forceSide, new List<string>());
                    }

                    if (!forceData[forceSide].Contains(forceUser))
                    {
                        List<string> force = new List<string>();
                        force.Add(forceUser);
                        forceData[forceSide] = force;
                    }
                }

                else if (input.Contains("->"))
                {
                    string[] command = input.Split(new[] { " ", "->" }, StringSplitOptions.RemoveEmptyEntries);
                    string forceUser = command[0];
                    string forceSide = command[1];

                    if (!forceData.ContainsKey(forceSide))
                    {
                        forceData.Add(forceUser, new List<string>());
                    }

                    if (forceData.Values.Any(c => c.Contains(forceUser)))
                    {
                        foreach (var item in forceData)
                        {
                            if (item.Value.Contains(forceUser))
                            {
                               item.Value.Remove(forceUser);
                            }
                        }
                    }
                    forceData[forceSide].Add(forceUser);
                    Console.WriteLine($"{forceUser} joins the {forceSide} side!");

                }

                input = Console.ReadLine();
            }

            foreach (var item in forceData.OrderByDescending(x=>x.Value.Count).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"Side: {item.Key}, Members: {item.Value.Count}");
                foreach (var i in item.Value)
                {
                    Console.WriteLine("! " + i);
                }
            }

        }    
    }
}
