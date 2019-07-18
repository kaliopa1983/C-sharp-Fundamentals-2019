using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                  .Split()
                  .Select(int.Parse)
                  .ToList();

            while (true)

            {
                string[] input = Console.ReadLine().Split();
                string command = input[0];

                if (command == "End")
                {
                    break;
                }
                switch (command)
                {
                    case "Add":
                        int numberToAdd = int.Parse(input[1]);
                        numbers.Add(numberToAdd);
                        break;
                    case "Insert":
                        int number = int.Parse(input[1]);
                        int index = int.Parse(input[2]);
                        if (index < 0 || index > numbers.Count)
                        {
                            
                           Console.WriteLine("Invalid index");
                        }
                        else
                        {
                            numbers.Insert(index, number);
                        }
                        break;
                    case "Remove":
                        int removeIndex = int.Parse(input[1]);
                        if (removeIndex < 0 || removeIndex>numbers.Count)
                        {
                           
                            Console.WriteLine("Invalid index");
                        }
                        else
                        {
                             numbers.RemoveAt(removeIndex);
                        }
                 
                    break;
                case "Shift" :
                        string direction = input[1];
                        int rotations = int.Parse(input[2]);

                        if (direction == "left")
                        {
                            for (int i = 0; i < rotations % numbers.Count; i++)
                            {
                                int firstNum = numbers[0];
                                numbers.Add(firstNum);
                                numbers.RemoveAt(0);
                            }
                        }
                        else
                        {
                            for (int i = 0; i < rotations % numbers.Count; i++)
                            {
                                int lastNum = numbers[numbers.Count - 1];
                                numbers.Insert(0, lastNum);
                                numbers.RemoveAt(numbers.Count - 1);
                            }
                        }
                            break;
                
                    default:
                        break;
                }
               
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
