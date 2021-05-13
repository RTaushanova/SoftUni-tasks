using System;

namespace _02.VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine().ToLower();
            int counter = 0;

            string vowels = "aouei";

            for (int i = 0; i < word.Length; i++)
            {
                char letter = word[i];

                if (vowels.Contains(letter.ToString()))
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }

    }
}
