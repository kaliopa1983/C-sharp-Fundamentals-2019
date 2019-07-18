using System;
using System.Collections.Generic;



public class Program

{

    public static void Main()

    {

        string someText = Console.ReadLine();
        Dictionary<char, int> countChars = new Dictionary<char, int>();
        for (int i = 0; i < someText.Length; i++)
        {
            char letter = someText[i];
            if (letter != ' ')
            {
                if (!countChars.ContainsKey(letter))
                {
                    countChars[letter] = 1;
                }
                else
                {
                    countChars[letter]++;
                }
            }

        }
        foreach (var kvp in countChars)
        {
            Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
        }
     }
  }
