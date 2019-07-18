using System;

namespace _01._Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] userNames = Console.ReadLine().Split(", ");
            for (int i = 0; i < userNames.Length; i++)
            {
                string currentUserName = userNames[i];
                bool IsLengthValid = true;
                bool IsContentValid = true;
                if (currentUserName.Length < 3 || currentUserName.Length > 16)
                {
                    IsLengthValid = false;
                }
               
                for (int j = 0; j <currentUserName.Length; j++)
                {
                    char currentSymbol = currentUserName[j];
                    if (!char.IsLetterOrDigit(currentSymbol)&& currentSymbol!='-'&& currentSymbol!='_')
                    {
                        IsContentValid = false;
                        break;
                    }
                }
                if (IsContentValid&& IsLengthValid)
                {
                    Console.WriteLine(currentUserName);
                }
            }
        }
    }
}
