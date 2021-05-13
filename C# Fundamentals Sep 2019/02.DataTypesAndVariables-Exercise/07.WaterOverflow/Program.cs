using System;

namespace _07.WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfPouring = int.Parse(Console.ReadLine());
            int pouredLiters = 0;
            for (int i = 1; i <= numOfPouring; i++)
            {
                int liters = int.Parse(Console.ReadLine());

                if (i == 1 && liters > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                    continue;
                }
                pouredLiters += liters;

               
                if (pouredLiters > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                    pouredLiters -= liters;
                }
                
               
            }
            Console.WriteLine(pouredLiters);
        }
    }
}
