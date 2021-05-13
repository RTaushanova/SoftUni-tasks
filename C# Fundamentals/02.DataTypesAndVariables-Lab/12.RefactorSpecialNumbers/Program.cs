using System;

namespace _12.RefactorSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int sum = 0;
            int current = 0;
            bool isSpecialNum = false;

            int i;
            for (i=1 ; i <= count; i++)
            {
                current = i;

                while (i>0)
                {
                    sum += i % 10;
                    i /= 10;
                }
                if (sum == 5 || sum == 7 || sum == 11)
                {
                    isSpecialNum = true;
                    Console.WriteLine($"{current} -> {isSpecialNum}");
                }
                sum = 0;
                i = current;
            }
        }
    }
}
