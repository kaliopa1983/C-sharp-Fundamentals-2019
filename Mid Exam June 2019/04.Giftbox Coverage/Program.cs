using System;

namespace _04.Giftbox_Coverage
{
    class Program
    {
        static void Main(string[] args)
        {
            double sizeOfSide = double.Parse(Console.ReadLine());
            int numberSheetsOfpaper = int.Parse(Console.ReadLine());
            double areaCoveredBySingleSheet = double.Parse(Console.ReadLine());

            double areaOfBox = 6 * (sizeOfSide * sizeOfSide);
            double areaCoveredByAllSheets = numberSheetsOfpaper * areaCoveredBySingleSheet;
            //  double percentage = (areaCoveredBySingleSheet / areaOfBox) * 100;
            double coveredArea = 0.0;
            for (int sheet = 1; sheet <=numberSheetsOfpaper; sheet++)
            {
                if (sheet%3==0)
                {
                    coveredArea = 0.25 * areaCoveredBySingleSheet;
                   


                }
            } double smallerSheetArea = (numberSheetsOfpaper / 3) * coveredArea;
              double totalAreaCovered =((numberSheetsOfpaper - (numberSheetsOfpaper/3)) * 
                        areaCoveredBySingleSheet) + smallerSheetArea;
            double percentage = (totalAreaCovered / areaOfBox) * 100;
            Console.WriteLine($"You can cover {percentage:f2}% of the box.");
        }
    }
}
