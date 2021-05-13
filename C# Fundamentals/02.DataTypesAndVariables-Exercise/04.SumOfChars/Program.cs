using System;

namespace _04.SumOfChars
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= input; i++)
            {
                char command = char.Parse(Console.ReadLine());
                sum += command;
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
