using System;
using System.Linq;

namespace _01.EncryptSortNPrintArr
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];

            string vowels = "aAeEiIoOuU";
            char[] vowelsToChar = vowels.ToCharArray();

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                char[] letters = name.ToCharArray();

                int sum = 0;

                for (int j = 0; j < letters.Length; j++)
                {
                    char currentChar = letters[j];
                
                    if (vowelsToChar.Contains(currentChar))
                    {
                        sum += letters[j] * letters.Length;
                    }
                    else
                    {
                        sum += letters[j] / letters.Length;
                    }


                }
            }
        }
    }
}
