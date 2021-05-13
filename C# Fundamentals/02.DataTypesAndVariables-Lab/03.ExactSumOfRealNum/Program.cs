using System;

namespace _03.ExactSumOfRealNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            decimal sum = 0;
            for (int i = 1; i <= count; i++)
            {
                 decimal currentNum = decimal.Parse(Console.ReadLine());

                sum += currentNum;
            }
            Console.WriteLine(sum);
        }
    }
}
