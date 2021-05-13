using System;

namespace _05.Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = Console.ReadLine();

            string passwordCheck = "";
            int counter = 0;

            for (int i = username.Length-1; i >= 0; i--)
            {
                passwordCheck += username[i];

            }

            while (passwordCheck != password)
            {
                counter++;

                if (counter >= 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    return;
                }
                else
                {
                    Console.WriteLine($"Incorrect password. Try again.");
                }
                password = Console.ReadLine();

            }
            Console.WriteLine($"User {username} logged in.");

        }
    }
}
