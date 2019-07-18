using System;
using System.Linq;

namespace _02._From_Left_to_The_Right
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
           
           
            long leftDigitsSum = 0;
            long rightDigitsSum = 0;
            for (int i = 0; i < lines; i++)
            {
                   string[] numbersAsString = Console.ReadLine().Split(" ").ToArray();
                 long leftNumber = long.Parse(numbersAsString[0]);
                 long rightNumber = long.Parse(numbersAsString[1]);
                if ((leftNumber >= rightNumber))
                {
                    while (leftNumber > 0)
                    {
                        long leftDigit = leftNumber % 10;
                        leftDigitsSum += leftDigit;

                        leftNumber = leftNumber / 10;
                    } 

                   
                }
                else if(leftNumber <=rightNumber)
                {
                    while (rightNumber > 0)
                    {
                        long rightDigit = rightNumber % 10;
                        rightNumber = rightNumber / 10;
                        rightDigitsSum += rightDigit;
                    }
                    
                }
            }
                       Console.WriteLine(Math.Abs(leftDigitsSum));
                       Console.WriteLine(Math.Abs(rightDigitsSum));
        }
            
                 
            
    }
}
    

