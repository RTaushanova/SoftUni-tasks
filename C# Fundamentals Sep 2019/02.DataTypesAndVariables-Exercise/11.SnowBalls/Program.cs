using System;
using System.Numerics;
namespace _11.SnowBalls
{
    class Program
    {
        static void Main(string[] args)
        {
            int ballsCount = int.Parse(Console.ReadLine());
            BigInteger maxValue = 0;
            int snowballSnowWinner = 0;
            int snowballTimeWinner = 0;
            int snowballQuallityWinner = 0;
            
           

            for (int i = 1; i <= ballsCount; i++)
            {

                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuallity = int.Parse(Console.ReadLine());

                BigInteger snowballValue = BigInteger.Pow((snowballSnow / snowballTime),snowballQuallity);
                
                if (snowballValue >= maxValue)
                {
                    maxValue = snowballValue;
                    snowballSnowWinner = snowballSnow;
                    snowballTimeWinner = snowballTime;
                    snowballQuallityWinner = snowballQuallity;
                }

                
            }
            Console.WriteLine($"{snowballSnowWinner} : {snowballTimeWinner} = {maxValue} ({snowballQuallityWinner})");
        }
    }
}
