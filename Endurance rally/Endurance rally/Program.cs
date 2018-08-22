using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Train_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var trainData = new Dictionary<string, Dictionary<string, int>>();

            while (input!= "It's Training Men!")
            {
                string [] command = input.Split(new string[] { " -> ", " = ", ":" }, StringSplitOptions.RemoveEmptyEntries);

                string trainName = command[0];
                string wagonName = command[1];

                if (command.Length == 3)
                {
                    int wagonPower = int.Parse(command[2]);


                    if (!trainData.ContainsKey(trainName))
                    {
                        trainData.Add(trainName, new Dictionary<string, int>());
                    }

                    if (!trainData[trainName].ContainsKey(wagonName))
                    {
                        trainData[trainName].Add(wagonName, wagonPower);
                    }

                }

                else
                {
                    string otherTrainname = command[1];

                    if (input.Contains("="))
                    {
                        if (!trainData.ContainsKey(trainName))
                        {
                            trainData[trainName] = new Dictionary<string, int>();
                        }

                        foreach (var wagon in trainData[otherTrainname])
                        {
                            trainData[trainName].Add(wagon.Key, wagon.Value);
                        }
                        
                    }
                    
                    if (input.Contains("->"))
                    {
                       

                        if (!trainData.ContainsKey(trainName))
                        {
                            trainData[trainName] = new Dictionary<string, int>();

                        }

                        foreach (var item in trainData[otherTrainname])
                        {
                            trainData[trainName].Add(item.Key, item.Value);
                        }

                            trainData.Remove(otherTrainname);
                    }

                }
                
                input = Console.ReadLine();
            }


            foreach (var train in trainData.OrderByDescending(x=>x.Value.Values.Sum()).ThenBy(x=>x.Value.Values.Count()))
            {
                Console.WriteLine($"Train: {train.Key}");

                foreach (var tr in train.Value.OrderByDescending(v=>v.Value))
                {
                    Console.WriteLine("###{0}- {1}",tr.Key,tr.Value);
                }
            }


        }
            
    }
}
