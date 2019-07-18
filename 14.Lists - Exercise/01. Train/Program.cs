﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine()
                 .Split(" ")
                 .Select(x => int.Parse(x))
                 .ToList();
            int maxCapacity = int.Parse(Console.ReadLine());
           string input;
            
            while ((input=Console.ReadLine()) != "end")
            {
               
                string[] splitedInput = input.Split(" ");
                if (splitedInput.Length==1)
                {
                    int passengers = int.Parse(splitedInput[0]);
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i]+passengers<=maxCapacity)
                        {
                            wagons[i] += passengers;
                            break;
                        }
                    }
                }
                else
                {
                     int passengers = int.Parse(splitedInput[1]);
                        wagons.Add(passengers);
                }
                
                       
                 
                }
            Console.WriteLine(string.Join(" ",wagons));
            }

        }
    }

