using System;

namespace _01._Spring_Vacation_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            decimal totalBudget = decimal.Parse(Console.ReadLine());
            int people = int.Parse(Console.ReadLine());
            decimal fuelPerKm = decimal.Parse(Console.ReadLine());
            decimal foodPerPerson = decimal.Parse(Console.ReadLine());
            decimal hotelPrice1p1n = decimal.Parse(Console.ReadLine());
           

            if (people > 10)
            {
                hotelPrice1p1n -= (0.25M * hotelPrice1p1n);
            }
            decimal totalExpence = people * days * (foodPerPerson + hotelPrice1p1n);

            for (int day = 1; day <= days; day++)
            {
                decimal travelledDistanse = decimal.Parse(Console.ReadLine());
              

                totalExpence += (fuelPerKm * travelledDistanse);




                if (day % 3 == 0 || day % 5 == 0)
                {
                    totalExpence += (0.40M * totalExpence);
                }


                if (day % 7 == 0)
                {
                    totalExpence -= (totalExpence / people);
                }

                if (totalExpence > totalBudget)
                {

                    Console.WriteLine($"Not enough money to continue the trip." +
                        $" You need {(totalExpence - totalBudget):f2}$ more.");
                    return;
                }
               


            }
                       Console.WriteLine($"You have reached the destination." +
                          $" You have {(totalBudget - totalExpence):f2}$ budget left.");



        }
    }
}

                
                
           
