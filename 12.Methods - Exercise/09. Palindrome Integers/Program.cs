using System;
using System.Linq;

namespace _09._Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = string.Empty;
            IsPalendrom(command);
        }
         static void IsPalendrom(string command)
        {
            string reversed = string.Empty;
            while (command != "END")
            {
                command = Console.ReadLine();
                if (command == "END")
                {
                    break;
                }
                else
                {


                    for (int i =command.Length-1; i >= 0; i--)
                    {
                        reversed += command[i];
                    }
                    if (reversed!=command)
                    {
                        Console.WriteLine("false");
                    }
                    else if(reversed==command)
                    {
                        Console.WriteLine("true");
                    }

                    reversed = string.Empty;
                }

            }

        }

    }
 }
               
    


        
