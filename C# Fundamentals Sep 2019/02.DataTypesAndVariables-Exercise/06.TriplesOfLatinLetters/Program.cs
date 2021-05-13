using System;

namespace _06.TriplesOfLatinLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < number; j++)
                {
                    for (int k = 0; k < number; k++)
                    {



                        char char1 = (char)('a' + i);
                        char char2 = (char)('a' + j);
                        char char3 = (char)('a' + k);
                        Console.Write($"{char1}{char2}{char3}");
                        Console.WriteLine();


                    }
                }
            }
        }
    }
}
