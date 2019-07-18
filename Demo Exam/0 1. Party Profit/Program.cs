using System;
using System.Collections.Generic;
namespace _0_1._Party_Profit
{
   public class Program
    {
        static void Main(string[] args)
        {
            int partySize = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

           int earnCouns = 50 * days;
              


            for (int day = 1; day <= days; day++)
            {

               if (day % 10 == 0)
                {
                    partySize -= 2;

                }


                if (day % 15 == 0)
                {
                    partySize += 5;

                }
                if (day % 3 == 0)
                {
                    earnCouns-= (3 * partySize);
                }

                if (day % 5 == 0)
                {
                    earnCouns += (20 * partySize);
                    if (day % 3 == 0)
                    {
                        earnCouns -= (2 * partySize);
                    }
                }

                earnCouns -= partySize * 2;
            }

            int profitPerPerson = (earnCouns ) / partySize;

            Console.WriteLine($"{partySize} companions received {profitPerPerson} coins each.");
            }
        
        }
    }



