using System;

namespace _05._Orders
{
    class Program
    {       
        static void Main(string[] args)

        {   string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            double singlePrice = 0.0;
            double totalPrice = CalculatePrice(product,quantity, singlePrice);
            Console.WriteLine( "{0:f2}",totalPrice);
            
            
        }
          static  double CalculatePrice(string product,int quantity, double singlePrice)
        {
            switch (product)
            {
                case "coffee":
                    singlePrice = 1.50;
                    break;
                case "coke":
                    singlePrice = 1.40;
                    break;
                case "water":
                    singlePrice = 1.00;
                    break;
                case "snacks":
                    singlePrice = 2.00;
                    break;
                default: break;
            }
                    return  quantity* singlePrice;
            
        }
    }
}
