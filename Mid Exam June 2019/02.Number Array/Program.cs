using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Number_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();
            string input;
            while ((input = Console.ReadLine())!="End")
            {
                 
               
                string[] commands = input.Split().ToArray();

                if (commands[0] == "Switch")
                {
                    int index = int.Parse(commands[1]);



                    if (index >= 0 && index < numbers.Count)
                    {
                        int number = numbers[index];
                        number *= -1;
                        numbers[index] = number;
                    }
                }

                else if (commands[0] == "Change")
                {
                    int index1 = int.Parse(commands[1]);
                    int givenNumber = int.Parse(commands[2]);

                    if (index1 >= 0 && index1 < numbers.Count)
                    {
                        numbers[index1] = givenNumber;
                    }
                }


                else if (commands[0] == "Sum")
                {

                    int sumNegative = 0;
                    int sumPositive = 0;
                    foreach (var number in numbers)
                    {
                        if (number < 0)
                        {
                            sumNegative += number;

                        }
                        else
                        {
                            sumPositive += number;

                        }
                    }



                    if (commands[1] == "Negative")
                    {
                        Console.WriteLine(sumNegative);
                    }
                    else if (commands[1] == "Positive")
                    {
                        Console.WriteLine(sumPositive);
                    }

                    else if (commands[1] == "All")
                    {
                        Console.WriteLine(numbers.Sum());
                    }

                }

            }
            foreach (var number in numbers)
            {
                if (number >= 0)
                {
                    Console.Write(number + " ");
                }
            }
        }
    }
}



                  
                       

                
        

