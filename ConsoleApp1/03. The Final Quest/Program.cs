using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._The_Final_Quest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split(" ").ToList();
           

            while (true)
            {
               string[] commands = Console.ReadLine().Split().ToArray();
                if (commands[0] =="Stop")
                {
                    break;
                }
                if (commands[0] == "Delete")
                {
                    int index = int.Parse(commands[1])+1;
                    if (index >= 0 && index < words.Count)
                    {
                        words.RemoveAt(index );
                    }

                }
                else if (commands[0] == "Swap")
                {
                    string word1 = commands[1];
                    string word2 = commands[2];
                    if (words.Contains(word1) && words.Contains(word2))
                    {


                        int index1 = words.IndexOf(word1);
                        int index2 = words.IndexOf(word2);
                        words[index1] = word2;
                        words[index2] = word1;

                    }
                }
                else if (commands[0] == "Put")
                {
                    string currentWord = commands[1];
                    int index = int.Parse(commands[2])-1;
                    if (index>=0&&index<=words.Count)
                    {
                      words.Insert(index, currentWord);
                    }
                   

                }
              
               
               
                else if (commands[0]=="Sort")
                {
                    words.Sort();
                    words.Reverse();

                }
                else if (commands[0]=="Replace")
                {
                    string firstWord = commands[1];
                        string secondWord = commands[2];
                    if (words.Contains(secondWord))
                    {
                       
                         int secondIndex = words.IndexOf(secondWord);
                        words[secondIndex] = firstWord;
                             
                    }
                }
               
            }
            Console.WriteLine(string.Join(" ",words));
        }
    }
}
