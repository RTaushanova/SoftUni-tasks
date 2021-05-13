﻿using System;
using System.Linq;

namespace _06.EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int leftSum = 0;
            int rightSum = numbers.Sum();

            // 1 2 3 3
            for (int i = 0; i < numbers.Length; i++)
            {
                rightSum -= numbers[i];

                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    return;
                }
                leftSum += numbers[i];
            }
            Console.WriteLine("no");
        }
    }
}
