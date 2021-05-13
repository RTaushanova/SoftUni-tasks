using System;

namespace _06.StrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            int factorielSum = 0;
            
            int factoriel = 1;


            for (int i = 0; i <= n.Length - 1; i++)
            {
                int digit = int.Parse(n[i].ToString());


                for (int j = 1; j <= digit ; j++)
                {
                    factoriel *= j;
                }
                factorielSum += factoriel;
                factoriel = 1;


            }

            if (factorielSum == int.Parse(n))
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
            
        }
    }
}
