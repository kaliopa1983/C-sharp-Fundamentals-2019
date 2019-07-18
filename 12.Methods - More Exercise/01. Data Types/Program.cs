using System;

namespace _01._Data_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstIntup = Console.ReadLine();
         
            if (firstIntup=="int")
            {    int secondInput  = int.Parse(Console.ReadLine());
               int result= DataType( secondInput);
                Console.WriteLine(result);    
            }
            else if (firstIntup=="real")
            {
                double secondInput = double.Parse(Console.ReadLine());
               double result = DataType(secondInput);
                Console.WriteLine($"{result:f2}");
            }
            else if (firstIntup=="string")
            {
                string secondInput = Console.ReadLine();
               string result= DataType(secondInput);
                Console.WriteLine(result);
            }
        }

        private static int DataType(int secondInput)
        {
           
            return secondInput * 2;

        }
        private static double DataType(double secondInput)
        {
            double result = secondInput * 1.5;
            return result;
        }
        private static string DataType(string secondInput)
        {
            string result = "$" + secondInput + "$";
            return result;
        }
            
    }
}
