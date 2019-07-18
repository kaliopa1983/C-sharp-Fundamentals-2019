using System;

namespace _01._Distance_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int countSteps = int.Parse(Console.ReadLine());
            double lenghtOf1step = (double.Parse(Console.ReadLine()))/100 ;
            double reduceStep = 0.0;
            int totalDistance = int.Parse(Console.ReadLine()); //m
            
            int count = 0;
            double percenage = 0.0;
            double distanceIgo = 0.0;
            for (int step = 1; step <= countSteps; step++)
            {
                if (step%5==0)
                {
                    reduceStep = (lenghtOf1step - (0.3 * lenghtOf1step)) ;
                    
                    count++;
                }
                
                
            }
            distanceIgo = (countSteps - count) * lenghtOf1step + count * reduceStep;
             percenage = ( distanceIgo/totalDistance)*100;

            Console.WriteLine($"You travelled {percenage:f2}% of the distance!");
        }
    }
}

