using System;

namespace _07._Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalMoney =0.0;
            string input;
            while ((input = Console.ReadLine()) !="Start")
            {
                double coins = double.Parse(input);
                switch (coins)
                {
                    case 0.1:
                    case 0.2:
                    case 0.5:
                    case 1:
                    case 2:
                        totalMoney += coins;
                        break;


                    default:
                        Console.WriteLine($"Cannot accept {coins}");
                        break;
                }
            }
            string product;
            while ((product= Console.ReadLine()).ToLower() !="end")
            {
                double price = 0.0;
                if (product == "coke" )
                {
                    price = 1;
                    Console.WriteLine($"Purchased {product}");
                }
                else if (product == "soda")
                {
                    price= 0.8;
                    Console.WriteLine($"Purchased {product}");
                }
                else if (product == "crisps")
                {
                    price= 1.5;
                    Console.WriteLine($"Purchased {product}");
                }
                else if(product =="water")
                {
                    price= 0.7;
                    Console.WriteLine($"Purchased {product}");
                }
                else
                {
                    Console.WriteLine("Invalid product");
                    continue;
                }
                if (totalMoney -price >= 0)
                {
                    totalMoney -= price;
                    Console.WriteLine($"Purchased {product.ToLower()}");
                }
                else
                {
                    Console.WriteLine("Sorry, not enough money");
                }
            }
            Console.WriteLine($"Change: {totalMoney:f2}");
        }
    }
}
