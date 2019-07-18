using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupOfpeople = int.Parse(Console.ReadLine());
            string typeOfgroup = Console.ReadLine();
            string dayOfweek = Console.ReadLine();
            double singlePrice = 0.00;

            if ((typeOfgroup == "Students") && (groupOfpeople < 30))
            {

                if (dayOfweek == "Friday")
                {
                    singlePrice = 8.45;
                }
                else if (dayOfweek == "Saturday")
                {
                    singlePrice = 9.80;
                }
                else if (dayOfweek == "Sunday")
                {
                    singlePrice = 10.46;
                }
                double totalPrice = groupOfpeople * singlePrice;
                Console.WriteLine("Total price: {0:f2}", totalPrice);
            }

            else if ((typeOfgroup == "Business") && (groupOfpeople < 100))
            {
                if (dayOfweek == "Friday")
                {
                    singlePrice = 10.90;
                }
                else if (dayOfweek == "Saturday")
                {
                    singlePrice = 15.60;
                }
                else if (dayOfweek == "Sunday")
                {
                    singlePrice = 16;
                }
                double totalPrice = groupOfpeople * singlePrice;
                Console.WriteLine("Total price: {0:f2}", totalPrice);
            }
            else if (((typeOfgroup == "Regular") && (groupOfpeople < 10))||
                ((typeOfgroup=="Regular" ) &&(groupOfpeople>20)))
            {
                if (dayOfweek == "Friday")
                {
                    singlePrice = 15 ;
                }
                else if (dayOfweek == "Saturday")
                {
                    singlePrice = 20;
                }
                else if (dayOfweek == "Sunday")
                {
                   singlePrice = 22.50;
                }
                double totalPrice = groupOfpeople * singlePrice;
                Console.WriteLine("Total price: {0:f2}", totalPrice);
            }
            else
            {
                if (typeOfgroup == "Students")
                { 
                   if (dayOfweek == "Friday")
                   {
                        singlePrice = 8.45;
                   }
                   else if (dayOfweek=="Saturday")
                   {
                        singlePrice = 9.80;
                   }
                   else if(dayOfweek=="Sunday")
                   {
                        singlePrice = 10.46;
                   }
                    double totalPrice = (groupOfpeople * singlePrice) - ((groupOfpeople * singlePrice) * 0.15);
                    Console.WriteLine("Total price: {0:f2}",totalPrice);
                }
                else if (typeOfgroup=="Business")
                { if(dayOfweek=="Friday")
                    {
                        singlePrice = 10.90;
                    }
                else if(dayOfweek=="Saturday")
                    {
                        singlePrice = 15.60;
                    }
                else if (dayOfweek=="Sunday")
                    {
                        singlePrice = 16;
                    }
                 
                   double totalPrice = singlePrice * (groupOfpeople - 10);
                    Console.WriteLine("Total price: {0:f2}",totalPrice);
                }
                else if(typeOfgroup=="Regular")
                {
                    if (dayOfweek=="Friday")
                    {
                        singlePrice = 15;
                    }
                    else if (dayOfweek=="Saturday")
                    {
                        singlePrice = 20;
                    }
                    else if (dayOfweek=="Sunday")
                    {
                        singlePrice = 22.50;
                    }
                    double totalPrice = (singlePrice * groupOfpeople) - ((singlePrice * groupOfpeople) * 0.05);
                    Console.WriteLine("Total price: {0:f2}",totalPrice);
                }
            }

        }
    }
}
