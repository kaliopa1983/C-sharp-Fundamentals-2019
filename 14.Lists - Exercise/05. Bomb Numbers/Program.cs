using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int specialBombNumber = input[0];
            int power = input[1];

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i]==(specialBombNumber))
                {
                    int indexNum = numbers.IndexOf(specialBombNumber);
                    if (indexNum < 0)
                    {
                        break;
                    }

                    int startIndex = GetStartIndex(indexNum, power, numbers);
                    int countLeftElements = CalculateLeftElements(startIndex, indexNum);
                    int count = GetCount(power, numbers, indexNum, countLeftElements);
                    numbers.RemoveRange(startIndex, count);
                }
                Console.WriteLine(numbers.Sum());
            }

           private static int CalculateLeftElements(int startIndex, int indexNum)
            {
                int count = 0;
                for (int i = startIndex; i < indexNum; i++)
                {
                    count++;
                }
                return count;
            }

            private static int GetCount(int power, List<int> numbers, int index, int leftCount)
            {
                int count = 0;
                if ((numbers.Count - 1 - index) < power)
                {
                    for (int i = index; i < numbers.Count; i++)
                    {
                        count++;
                    }
                }
                else
                {
                    for (int i = 0; i <= power; i++)
                    {
                        count++;
                    }
                }
                return count + leftCount;
            }

            private static int GetStartIndex(int index, int power, List<int> numbers)
            {
                if (index < power)
                {
                    index = 0;
                }
                else
                {
                    index = index - power;
                }
                return index;
            }


        }
    }



}
    
