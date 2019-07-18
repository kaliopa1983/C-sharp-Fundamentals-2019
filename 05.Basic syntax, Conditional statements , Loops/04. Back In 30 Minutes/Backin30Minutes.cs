using System;

namespace _04._Back_In_30_Minutes
{
    class Backin30Minutes
    {
        static void Main(string[] args)
        {
            int initialHours = int.Parse(Console.ReadLine());
            int initialMinutes = int.Parse(Console.ReadLine())+30;

            
            if (initialMinutes> 59)
            {
                initialHours += 1;
                initialMinutes -= 60;

            }
            
            if (initialHours>23)
            {
                initialHours=0;
                
            }
            Console.WriteLine("{0}:{1:D2}", initialHours, initialMinutes);

        }
    }
    

}
