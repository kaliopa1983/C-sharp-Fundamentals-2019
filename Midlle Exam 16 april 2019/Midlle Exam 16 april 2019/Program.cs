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
            decimal price1cozonac = 0M;
            while (budget>0)
            {
                price1cozonac += price1KgFloor + price1PackEggs + ((250 * price1LMilk) / 1000);
            }
            int countCozonac = ((int) budget /(int) price1cozonac);
            int colorEggsCount = 0;
            for (int cozonac = 1; cozonac < countCozonac; cozonac++)
            {
                colorEggsCount +=cozonac * 3;
                if (cozonac%3==0)
                {
                    int losedEgges = cozonac - 2;
                    colorEggsCount -= losedEgges;
                }
            }
            decimal moneyLeft = budget - (price1cozonac * countCozonac);
            Console.WriteLine($"You made {countCozonac} cozonacs!" +
                $" Now you have {colorEggsCount} eggs and {moneyLeft:f2}BGN left.");

        }
    }
}
