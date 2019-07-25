using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Feed_the_Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = string.Empty;
            var animalsDalyLimit = new Dictionary<string, int>();
            var animalArea = new Dictionary<string, List<string>>();
            while ((command = Console.ReadLine()) != "Last Info")
            {
                string[] splittedCommand = command.Split(":");
                string currentCommand = splittedCommand[0];
                string currentNameOfAnimal = splittedCommand[1];
                int dailyLimit = int.Parse(splittedCommand[2]);
                string areaOfCurrentAnimal = splittedCommand[3];
                switch (currentCommand)
                {
                    case "Add":
                        if (animalsDalyLimit.ContainsKey(currentNameOfAnimal))
                        {
                            animalsDalyLimit[currentNameOfAnimal] += dailyLimit;
                        }
                        else
                        {
                            animalsDalyLimit.Add(currentNameOfAnimal, dailyLimit);
                        }

                        if (!animalArea.ContainsKey(areaOfCurrentAnimal))
                        {

                            animalArea.Add(areaOfCurrentAnimal, new List<string>());
                        }
                        if (!animalArea[areaOfCurrentAnimal].Contains(currentNameOfAnimal))

                        {
                            animalArea[areaOfCurrentAnimal].Add(currentNameOfAnimal);
                        }
                        break;

                    case "Feed":
                        if (animalsDalyLimit.ContainsKey(currentNameOfAnimal))
                        {
                            animalsDalyLimit[currentNameOfAnimal] -= dailyLimit;
                            if (animalsDalyLimit[currentNameOfAnimal] <= 0)
                            {
                                Console.WriteLine($"{currentNameOfAnimal} was successfully fed");
                                animalsDalyLimit.Remove(currentNameOfAnimal);
                                animalArea[areaOfCurrentAnimal].Remove(currentNameOfAnimal);

                            }
                        }
                        break;
                }
            }

            Console.WriteLine($"Animals:");
            foreach (var limit in animalsDalyLimit.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {

                Console.WriteLine($"{limit.Key} -> {limit.Value}g");
            }

            Console.WriteLine("Areas with hungry animals:");
            foreach (var areas in animalArea.Where(x => x.Value.Count > 0).OrderByDescending(x => x.Value.Count()))
            {

                Console.WriteLine($"{areas.Key} : {areas.Value.Count()}");
            }

        }
    }
}
        
    

