using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01._Furniture
{
    class Program
    {
        static void Main(string[] args)
        { string pattern = @">>(?<furnitureName>.*)<<(?<price>[0-9]+\.?[0-9]*)!(?<quantity>\d+)";
            string  input = Console.ReadLine();
            decimal totalMoney = 0;
            List<string> furnituresName = new List<string>();
            while (input != "Purchase")

            {

                Regex regex = new Regex(pattern);

                MatchCollection matches = regex.Matches(input);

                foreach (Match match in matches)
                {
                    string furnitureName = match.Groups["furnitureName"].Value;
                    decimal price = decimal.Parse(match.Groups["price"].Value);
                    int quantity = int.Parse(match.Groups["quantity"].Value);

                    furnituresName.Add(furnitureName);
                    totalMoney += price * quantity;


                }

                input = Console.ReadLine();
            }
                Console.WriteLine($"Bought furniture:");
                foreach (string name in furnituresName)
                {

                    Console.WriteLine($"{name}");
                    
                }
                   Console.WriteLine($"Total money spend: {totalMoney:f2}");
            }
        }
    }

