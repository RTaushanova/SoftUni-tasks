using System;

namespace _10.PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            int power = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());

            int startPower = power;
            int pokesCounter = 0;

            while (power >= distance)
            {
                power -= distance;
                pokesCounter++;

                if (power == (double)startPower / 2.0)
                {
                    if (exhaustionFactor == 0)
                    {
                        continue;
                    }
                    else
                    {
                    power /= exhaustionFactor;

                    }
                }
            }
            Console.WriteLine(power);
            Console.WriteLine(pokesCounter);
        }
    }
}
