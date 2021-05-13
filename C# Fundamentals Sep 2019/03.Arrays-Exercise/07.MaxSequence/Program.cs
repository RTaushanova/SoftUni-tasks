using System;
using System.Linq;

namespace _07.MaxSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            
            int counter = 1;
            int maxCounter = 1;
            int number = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[i-1])
                {
                    counter++;
                   
                    if(counter > maxCounter)
                    {
                        maxCounter = counter;
                        number = numbers[i];
                    }
                    
                }
                else
                {
                    counter = 1;
                }
            }
            for (int i = 0; i < maxCounter; i++)
            {
                Console.Write(number + " ");
            }
        }
    }
}
