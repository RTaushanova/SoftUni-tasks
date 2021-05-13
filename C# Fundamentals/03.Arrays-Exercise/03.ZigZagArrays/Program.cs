using System;
using System.Linq;

namespace _03.ZigZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int firstNum = 0;
            int secondNum = 0;

            int[] firstArray = new int[n];
            int[] secondArray = new int[n];

            for (int i = 0; i < n; i++)
            {
                int[] currentArray = Console.ReadLine().Split().Select(int.Parse).ToArray(); ;


                if (i % 2 != 0)
                {
                    firstArray[i] = currentArray[0];
                    secondArray[i] = currentArray[1];
                }
                else
                {
                    firstArray[i] = currentArray[1];
                    secondArray[i] = currentArray[0];
                }

            }
            Console.WriteLine(string.Join(" ", secondArray));
            Console.WriteLine(string.Join(" ", firstArray));
        }
    }
}
