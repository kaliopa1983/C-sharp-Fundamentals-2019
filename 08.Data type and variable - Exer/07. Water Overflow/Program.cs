using System;

namespace _07._Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            int capacityOtwatertank = 255;
            int sumOfwater = 0;
           
            for (int i = 0; i < n; i++)
            {   
                int quantitiOfwater=int.Parse(Console.ReadLine());
                
                if (sumOfwater+ quantitiOfwater<=capacityOtwatertank)
                {
                   sumOfwater += quantitiOfwater;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                

                
            }
            Console.WriteLine(sumOfwater);

        }
    }
}
