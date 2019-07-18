using System;

namespace _08._Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int countKegs = int.Parse(Console.ReadLine());
            string modelOfkeg = string.Empty;
            double volume = 0.0;
            for (int i = 0; i < countKegs; i++)
            {
                string currentModel = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                double currentVolume = Math.PI * Math.Pow(radius, 2) * height;

                if (currentVolume>volume)
                {
                    volume = currentVolume;
                    modelOfkeg = currentModel;
                   
                }

            }
             Console.WriteLine(modelOfkeg);
            
            
        }
    }
}
