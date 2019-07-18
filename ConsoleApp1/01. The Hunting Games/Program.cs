using System;

namespace _01._The_Hunting_Games
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysOftheAdventure = int.Parse(Console.ReadLine());
            int countOfPlayers = int.Parse(Console.ReadLine());
            double groupsEnergy = double.Parse(Console.ReadLine());
            double waterPerDayPerPerson = double.Parse(Console.ReadLine());
            double foodPerDayPerPerson = double.Parse(Console.ReadLine());
            double totalWater = daysOftheAdventure * countOfPlayers * waterPerDayPerPerson;
            double totalFood = daysOftheAdventure * countOfPlayers * foodPerDayPerPerson;
            bool Isbreaked = false;
            for (int day = 1; day <= daysOftheAdventure; day++)
            {
                double AmountOfEnergyLoss = double.Parse(Console.ReadLine());
                groupsEnergy -= AmountOfEnergyLoss;
                if (groupsEnergy <= 0)
                {
                    Isbreaked = true;
                    break;
                }
                if (day % 2 == 0)
                {

                    groupsEnergy = groupsEnergy + groupsEnergy * 0.05;

                    totalWater -= 0.3 *totalWater;
                }
                if (day % 3 == 0)
                {
                    totalFood -=(totalFood/countOfPlayers);
                    groupsEnergy += 0.1 * groupsEnergy;

                }



            }
            if (Isbreaked)
            {
                Console.WriteLine($"You will run out of energy. You will be left with {totalFood:f2} food and {totalWater:f2} water.");
            }
            else
            {Console.WriteLine($"You are ready for the quest. You will be left with - {groupsEnergy:f2} energy!");

            }       
                
             
              
           
        }
    }
}
