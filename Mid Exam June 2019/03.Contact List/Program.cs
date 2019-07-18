using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Contact_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> contactsList = Console.ReadLine().Split(" ").ToList();
            while (true)
            {
                string commands = Console.ReadLine();

                string[] currentcommands = commands.Split(" ").ToArray();
                if (currentcommands[0] == "Add")
                {
                    string contactName = currentcommands[1];
                    int index = int.Parse(currentcommands[2]);
                    if (contactsList.Contains(contactName))
                    {
                        if (index > 0 && index < contactsList.Count)
                        {
                            contactsList.Insert(index, contactName);
                        }
                    
                     }
                    else

                    {
                    contactsList.Add(contactName);
                    }

                }
                else if (currentcommands[0] == "Remove")
                {
                    int removeIndex = int.Parse(currentcommands[1]);
                    if (removeIndex >= 0 && removeIndex < contactsList.Count)
                    {
                        contactsList.RemoveAt(removeIndex);
                    }
                }
                else if (currentcommands[0] == "Export")
                {
                    int startIndex = int.Parse(currentcommands[1]);

                    int count = int.Parse(currentcommands[2]);

                    while (startIndex < contactsList.Count && count > 0)
                    {
                        Console.Write(contactsList[startIndex] + " ");
                        startIndex++;
                        count--;
                    }
                    Console.WriteLine();

                }   
                else if (currentcommands[0]=="Print")
                {
                    string normalOrReversed = currentcommands[1];

                    if (normalOrReversed == "Reversed")
                    {
                        contactsList.Reverse();
                    }
                    Console.WriteLine($"Contacts: {string.Join(" ",contactsList)}");
                    break;
                }

            }
        }
    }
}
