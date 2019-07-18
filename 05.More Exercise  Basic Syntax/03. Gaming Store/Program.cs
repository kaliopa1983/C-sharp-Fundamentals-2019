using System;

namespace _03._Gaming_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            double currentBalance = double.Parse(Console.ReadLine());
            string nameOfgame = Console.ReadLine();
            double price = 0.0;
            double spentMoney = 0.0;
            switch (nameOfgame)
            {
                case "OutFall 4":

                    price = 39.99;
                    if (currentBalance >= price)

                    {
                        currentBalance -= price;
                        spentMoney += price;

                        Console.WriteLine($"Bought {nameOfgame}");



                    }
                    break;
                case "CS: OG":

                    price = 15.99;
                    if (currentBalance >= price)

                    {


                        currentBalance -= price;
                        spentMoney += price;

                        Console.WriteLine($"Bought {nameOfgame}");



                    }
                    break;
                case "Zplinter Zell":

                    price = 19.99;
                    if (currentBalance >= price)

                    {


                        currentBalance -= price;
                        spentMoney += price;

                        Console.WriteLine($"Bought {nameOfgame}");



                    }
                    break;
                case " Honored 2":

                    price = 59.99;
                    if (currentBalance >= price)

                    {


                        currentBalance -= price;
                        spentMoney += price;

                        Console.WriteLine($"Bought {nameOfgame}");



                    }
                    break;
                case "  RoverWatch":

                    price = 29.99;
                    if (currentBalance >= price)

                    {


                        currentBalance -= price;
                        spentMoney += price;

                        Console.WriteLine($"Bought {nameOfgame}");



                    }
                    break;
                case " RoverWatch Origins Edition":

                    price = 39.99;
                    if (currentBalance >= price)

                    {


                        currentBalance -= price;
                        spentMoney += price;

                        Console.WriteLine($"Bought {nameOfgame}");



                    }
                    break;
                default:

                    Console.WriteLine("Not Found");
                    break;

            }
            nameOfgame = Console.ReadLine();

            while (true)
            {
                if (nameOfgame != "Game Time")
                {
                    if (currentBalance == 0)
                    {
                        Console.WriteLine("Out of money!");
                        break;
                    }
                   
                    else if(currentBalance<price)
                    {
                        Console.WriteLine("Too Expensive");
                        nameOfgame = Console.ReadLine();
                    }

                }
                else if (nameOfgame == "Game Time")
                {
                    Console.WriteLine($"Total spent: ${spentMoney}.Remaining: ${currentBalance - spentMoney}");
                }
                Console.WriteLine();


            }




           
        }    
           
        }
    }

