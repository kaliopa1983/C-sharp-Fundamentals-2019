using System;

namespace _03._Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfpersons = int.Parse(Console.ReadLine());
            int capacityOfelevator = int.Parse(Console.ReadLine());
            int coursesOfelevator = numberOfpersons / capacityOfelevator;
            if ((coursesOfelevator*capacityOfelevator)<numberOfpersons)
            {
                int personLeft = numberOfpersons - (coursesOfelevator * capacityOfelevator);
                if ((personLeft<=capacityOfelevator))
                {
                    coursesOfelevator += 1;
                }
            }
            Console.WriteLine(coursesOfelevator);


        }
    }
}
