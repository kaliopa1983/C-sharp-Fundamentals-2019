using System;

namespace _05._Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();

            string password = "";
           
            for (int i = username.Length-1; i >= 0; i--)
            {
                password += username[i];
            }
            int counter = 1;
            bool isLogged = false;
            while (counter< 4)
            {
                string inputpassword = Console.ReadLine();
                if (inputpassword==password)
                {
                    isLogged = true;
                    Console.WriteLine($"User {username} logged in." );
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }
                counter++;

            }
            if (!isLogged)
            {
                Console.WriteLine($"User { username} blocked!");
                
            }
        }
    }
}
