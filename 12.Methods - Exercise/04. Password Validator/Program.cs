using System;

namespace _04._Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();


            ValidPassword(password);



        }
        static void PasswordLenght(string password)
        {
            bool IsLenghtValid = false;
            if (password.Length >= 6 && password.Length <= 10)
            {
                IsLenghtValid = true;
            }
            if (!IsLenghtValid)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
        }
        static void SymbolValidInPass(string password)
        {
            bool AreSymbolisValid = false;
            int counter = 0;
            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsDigit(password[i]))
                {
                    AreSymbolisValid = true;
                    counter++;

                }
                if (char.IsLetter(password[i]))
                {
                    AreSymbolisValid = true;
                }
              
                
            }
            if (!AreSymbolisValid)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
        }
        static void AtLeastTwoDigits(string password)
        {
            int counter = 0;
            bool containsAtleastTwoDigits = false;
            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsDigit(password[i]))
                {
                    
                    counter++;

                }
            }


            if (counter >= 2)
            {
                containsAtleastTwoDigits = true;
            }


            if (!containsAtleastTwoDigits)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }

        }

        static void ValidPassword(string password)
        {
            bool IsLenghtValid = false;
            bool containsAtleastTwoDigits = false;
            bool AreSymbolisValid = false;
            int counter = 0;
            PasswordLenght(password);
            SymbolValidInPass(password);
            AtLeastTwoDigits(password);
            if (password.Length >= 6 && password.Length <= 10)
            {
                IsLenghtValid = true;
            }
            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsDigit(password[i]) )
                {
                    counter++;
                    AreSymbolisValid = true;

                }
            if (char.IsLetter(password[i]))
            {
                    AreSymbolisValid = true;
            }
              
                
                if (counter >= 2)
                {
                    containsAtleastTwoDigits = true;
                }
            }
                if (IsLenghtValid && containsAtleastTwoDigits && AreSymbolisValid)
                {
                    Console.WriteLine("Password is valid");
                }


            

        }
    }
}
        
            
          
                 
  