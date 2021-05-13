using System;

namespace _02.SumDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            int sum = 0;
            for (int i = 0; i <=num.Length-1; i++)
            {
                int digit = int.Parse(num[i].ToString());
                sum += digit;

            }
            Console.WriteLine(sum);
        }
    }
}
