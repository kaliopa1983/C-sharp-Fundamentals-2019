using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Concert
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int totalTime = 0;
            string commands = string.Empty;
            Dictionary<string, List<string>> bands = new Dictionary<string, List<string>>();
            Dictionary<string, int> times = new Dictionary<string, int>();
            while (( commands=Console.ReadLine()) != "start of concert")
            {
              
                string[] input = commands.Split("; ");
                if (input[0] == "Add")
                {
                    string bandName = input[1];

                    List<string> members = input[2].Split(", ").ToList();



                    if (!bands.ContainsKey(bandName))
                    {
                        bands[bandName] = new List<string>();
                    }
                    for (int i = 0; i < members.Count; i++)
                    {
                        if (!bands[bandName].Contains(members[i]))
                        {
                            bands[bandName].Add(members[i]);
                        }
                    }

                }
                else if (input[0] == "Play")

                {
                    string bandName = input[1];
                    int time = int.Parse(input[2]);
                    totalTime += time;


                    if (!times.ContainsKey(bandName))
                    {
                        times[bandName] = time;
                    }
                    else
                    {
                        times[bandName] += time; ;
                    }


                }
            }
            string bandName1 = Console.ReadLine();


            Console.WriteLine($"Total time: {totalTime}");

            Dictionary<string, int> sortedDic = times
                .OrderByDescending(pair => pair.Value)
                .ThenBy(pair => pair.Key)
                .ToDictionary(pair => pair.Key,
                pair => pair.Value);
            foreach (var kvp in sortedDic)

            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
            
            foreach (var kvp in bands)
            {
                if (kvp.Key == bandName1)
                {
                    Console.WriteLine($"{kvp.Key}");

                    foreach (var item in kvp.Value)
                    {
                        Console.WriteLine($"=> {item}");
                    }



                }
            }
        }
    }
}
