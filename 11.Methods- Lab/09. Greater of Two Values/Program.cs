using System;

namespace _09._Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string dataType = Console.ReadLine().ToLower();
            if (dataType == "int")
            {
                int firstInput = int.Parse(Console.ReadLine());
                int secondInput = int.Parse(Console.ReadLine());

                int getMaxInt= GetMaxInt(firstInput, secondInput);
                Console.WriteLine(getMaxInt);
            }
            else if (dataType == "char")
            {
                char firstIntup = char.Parse(Console.ReadLine());
                char secondIntup = char.Parse(Console.ReadLine());

                char getMaxChar = GetMaxChar(firstIntup,secondIntup);
                Console.WriteLine(getMaxChar);
            }
            else if (dataType == "string")
            {
                string firstInput = Console.ReadLine();
                string secondInput = Console.ReadLine();

               string getMaxString = GetMaxString( firstInput, secondInput);
                Console.WriteLine(getMaxString);
            }
                

            }

        private static string GetMaxString(string firstInput, string secondInput)
        {
            if (firstInput.CompareTo(secondInput)>=0)
            {
                return firstInput;
            }
            else
            {
                return secondInput;
            }
        }

        private static char GetMaxChar(char firstIntup, char secondIntup)
        {
            if (firstIntup>secondIntup)
            {
                return firstIntup;
            }
            else
            {
                return secondIntup;
            }
        }

        private static int GetMaxInt(int firstInput, int secondInput)
        {
            if (firstInput>secondInput)
            {
                return firstInput;
            }
            else
            {
                return secondInput;
            }
        }
    }
}
