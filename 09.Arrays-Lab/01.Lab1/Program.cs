using System;

namespace _01.Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
          
            string[] daysName ={ "Monday", "Tuesday", "Wednesday", "Thursday",
                "Friday", "Saturday", "Sunday"};
            int daysNumber = int.Parse(Console.ReadLine());

            if (daysNumber>=1 && daysNumber<=7)
            {
                Console.WriteLine(daysName[daysNumber-1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
           
                
            
               
            
        }
    }
  

}
