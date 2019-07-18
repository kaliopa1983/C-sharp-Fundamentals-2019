using System;


namespace Midlle_Exam_16_april_2019
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            decimal price1KgFloor = decimal.Parse(Console.ReadLine());
            decimal price1PackEggs = (0.75M) * price1KgFloor;
            decimal price1LMilk = (0.25M * price1KgFloor) + price1KgFloor;

            int countCozonac = 0;
            int colorEggsCount = 0;

            decimal price1cozonac = price1KgFloor + price1PackEggs + ((250 * price1LMilk) / 1000);


            //countCozonac = ((int)budget / (int)price1cozonac);
            while (true)
            {
                budget -= (price1cozonac);

                countCozonac++;
                

                if (budget<=price1cozonac)
                {
                    break;


                }
            }
            for (int cozonac = 1;  cozonac <= countCozonac;cozonac++)
            {
                colorEggsCount += 3;

                if (cozonac%3==0)
            {
                    
       int losedeggs=(cozonac - 2);
                    colorEggsCount -= losedeggs;
            }
            }
           

            Console.WriteLine($"You made {countCozonac} cozonacs!" +
       $" Now you have {colorEggsCount} eggs and {budget:f2}BGN left.");
        }

                                                     



    }
}
    




           
           


    
