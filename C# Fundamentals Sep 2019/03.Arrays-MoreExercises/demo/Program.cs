using System;
using System.Linq;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int length = arr.Length;
            int leftSum = 0;
            int rightSum = 0;
            int index = 0;

            if (length == 1)
            {
                Console.WriteLine(0);
                return;
            }

            for (int i = 1; i <= length; i++) // i=2
            {
                for (int j = i - 1; j >= 0; j--) //j = 1 to 0;
                {
                    leftSum += arr[j];
                }

                for (int k = i + 1; k < length; k++) //j = 3 to 3
                {
                    rightSum += arr[k];
                }

                if (rightSum == leftSum)
                {
                    
                    Console.WriteLine(i);
                    return;
                }
                else
                {
                    leftSum = 0;
                    rightSum = 0;
                }

            }

            Console.WriteLine("no");
        }
    }
}
