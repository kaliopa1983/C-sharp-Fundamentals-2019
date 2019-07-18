using System;

namespace _11._Math_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            string operatorSight = Console.ReadLine();
            int secondNumber = int.Parse(Console.ReadLine());
            double result = MathOperations( firstNumber, operatorSight,  secondNumber);
            Console.WriteLine(result);
        }

        static double MathOperations(int firstNumber,string operatorSight, int secondNumber)
        {
            double result = 0.0;
            switch (operatorSight)
            {
                case "/":
                    result = (firstNumber / secondNumber);
                    break;
                   
                case "*":
                     result = (firstNumber * secondNumber);
                    break;
                case "+":
                    result= (firstNumber + secondNumber);
                    break;
                case "-":
                    result= (firstNumber - secondNumber);
                    break;

                default:
                    break;

                  
            }
            return result;
        }
    }
}
