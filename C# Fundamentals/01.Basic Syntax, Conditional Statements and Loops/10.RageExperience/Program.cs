using System;

namespace _10.RageExperience
{
    class Program
    {
        static void Main(string[] args)
        {
            int games = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

           
            int keyboardCounter = 0;
           

            double cost = 0;

            for (int i = 1; i <= games; i++)
            {
                if (i % 2 == 0)
                {

                    cost += headsetPrice;
                }
                if (i % 3 == 0)
                {
                    cost += mousePrice;
                }
                if (i % 2 == 0 && i % 3 == 0)
                {
                    
                    cost += keyboardPrice;
                    keyboardCounter++;
                    if (keyboardCounter % 2 == 0)
                    {
                        cost += displayPrice;
                    }
                }

            }
            Console.WriteLine($"Rage expenses: {cost:f2} lv.");

        }
    }
}
