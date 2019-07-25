using System;
using System.Collections.Generic;
using System.Text;

namespace Demo__Final_Exam__21_July_2019
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = String.Empty;
            while (true)
            {
                input = Console.ReadLine();
                StringBuilder text = new StringBuilder();
                if (input=="End")
                {
                    break;
                }
                string[] command = input.Split();
                if (command[0]=="Add")
                { string str = command[1];
                    text.Append(str);

                    Console.WriteLine(text);
                }
                 if (command[0]=="Upgrade")
                { char replaceMe = char.Parse(command[1]);
                    
                    for (int i = 0; i < text.Length; i++)
                    {
                        if (text[i]==replaceMe)
                        {
                      text= text.Replace(replaceMe, (char)(replaceMe+1));
                            Console.WriteLine(text);
                        }
                    }
                    
                }
                 if (command[0]=="Print")
                {
                    Console.WriteLine(text);
                }
                 if (command[0]=="Index")
                { 
                     char ch =char.Parse( command[1]);
                     List<int> index = new List<int>();
                    for (int i = 0; i <text.Length; i++)
                    {
                       if (text[i]==ch)
                       {
                            index.Add(i);
                            Console.WriteLine(string.Join(" ",index));
                       }
                        else
                        {
                            Console.WriteLine("None");
                        }
                    }
                   
                }
                 if (command[0]=="Remove")
                {
                    string str = command[1];
                    if (input.Contains(str))
                    {
                        input.Replace(str, string.Empty);
                        Console.WriteLine(input);
                    }    

                    
                }

            }
        }
    }
}
