using System;
using System.Linq;

namespace _05.TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            

            for (int i = 0; i < numbers.Length-1; i++)
            {
                int currentNumber = numbers[i];
                bool isTopNumber = true;
                for (int j = i+1; j < numbers.Length; j++)
                {
                    int otherNumber = numbers[j];

                    if (currentNumber <= otherNumber)
                    {
                        isTopNumber = false;
                        break;
                    }
                }
                if (isTopNumber == true)
                {
                    Console.Write(currentNumber + " ");
                }
            }
            Console.WriteLine(numbers[numbers.Length-1]);
        }
    }
}
