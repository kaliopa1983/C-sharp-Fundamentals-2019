﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Append_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> numbersLikeString = Console.ReadLine()
                  .Split("|")
                  .Reverse()
                  .ToList();

            List<int> numbers = new List<int>();
            foreach (var str in numbersLikeString)
            {
              numbers.AddRange( str.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToList());
                
            }
            Console.WriteLine(string.Join(" ",numbers));
           
            
               
            }
           

        

        }

       
    }

