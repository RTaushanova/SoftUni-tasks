using System;

namespace _05.SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            
            int sum = 0;

            for (int i = 1; i <=number; i++)
            {
                string iToString = i.ToString();
                for (int j = 0; j < iToString.Length; j++)
                {
                    int digit = int.Parse(iToString[j].ToString());
                    sum += digit;

                }

                if (sum == 5 || sum == 7 || sum ==11)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False");
                }
                sum = 0;
                    
            }


        }
    }
}
