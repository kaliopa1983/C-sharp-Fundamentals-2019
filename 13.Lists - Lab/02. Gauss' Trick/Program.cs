using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Gauss__Trick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                  .Split(" ")
                  .Select(int.Parse)
                  .ToList();
            if (numbers.Count%2==0)
            {
               for (int i = 0; i <= numbers.Count/2; i++)
            {

                    numbers[i] += numbers[numbers.Count - 1];
                    numbers.RemoveAt(numbers.Count -1 );

               
            }
                 Console.WriteLine(string.Join(" ", numbers));
            }
            if(numbers.Count%2!=0)
            {
                for (int i = 0; i < (numbers.Count+1)/2; i++)
                {
                    numbers[i] += numbers[numbers.Count-1 ];

                  

                    numbers.RemoveAt(numbers.Count-1);
                    if (i<0)
                    {
                        i = 0;
                    }


                    
                }
                    Console.WriteLine(string.Join(" ", numbers));
            }
           
        }
    }
}
