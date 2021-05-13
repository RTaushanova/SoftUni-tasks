using System;

namespace _03.CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char startSymbol = char.Parse(Console.ReadLine());
            char endSymbol = char.Parse(Console.ReadLine());

            if ((int)startSymbol < (int)endSymbol)
            {
            for (int i = startSymbol+1; i < endSymbol; i++)
            {
                char currentSymbol = (char)(i);

                Console.Write(currentSymbol + " ");
            }

            }
            else
            {
                for (int i = endSymbol+1; i < startSymbol; i++)
                {
                    char currentSymbol = (char)(i);

                    Console.Write(currentSymbol + " ");
                }
            }


        }
    }
}
