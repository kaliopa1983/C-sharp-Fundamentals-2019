using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Easter_Gifts
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> namesOfTheShops = Console.ReadLine().Split(" ").ToList();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] commands = Console.ReadLine().Split(" ").ToArray();
                if (commands[0] == "Include")
                {
                    string shop = commands[1];
                    namesOfTheShops.Add(shop);
                }
                else if (commands[0] == "Place")
                {
                    string shopToAdd = commands[1];
                    int shopIndex = int.Parse(commands[2]);
                    int resultIndex = shopIndex + 1;
                    if (resultIndex > 0 && resultIndex < namesOfTheShops.Count)
                    {
                        namesOfTheShops.Insert(resultIndex, shopToAdd);
                    }

                }

                else if (commands[0] == "Prefer")

                {
                    int shopIndex1 = int.Parse(commands[1]);
                    int shopIndex2 = int.Parse(commands[2]);

                    if ((shopIndex1 >= 0 && shopIndex1 <= namesOfTheShops.Count) && (shopIndex2 >= 0 && shopIndex2 <= namesOfTheShops.Count))
                    {

                var     tempStoreFirstIndex = namesOfTheShops[shopIndex1];
                        namesOfTheShops[shopIndex1] = namesOfTheShops[shopIndex2];
                        namesOfTheShops[shopIndex2] = tempStoreFirstIndex;


                    }
                }
                else if (commands[0] == "Visit")
                {
                    int rangeToRemove = int.Parse(commands[2]);
                    if (rangeToRemove <= namesOfTheShops.Count)
                    {
                        if (commands[1] == "first")
                        {
                            namesOfTheShops.RemoveRange(0, rangeToRemove);
                        }
                        else if (commands[1] == "last")
                        {
                            namesOfTheShops.RemoveRange(namesOfTheShops.Count - 1, rangeToRemove);
                        }
                    }
                }
            }
                Console.WriteLine("Shops left:");
                Console.WriteLine(string.Join(" ", namesOfTheShops));





            }

        }


       
    }





        
    
