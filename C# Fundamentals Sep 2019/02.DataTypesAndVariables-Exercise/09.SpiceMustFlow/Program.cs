using System;

namespace _09.SpiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            int yield = int.Parse(Console.ReadLine());
            int daysCounter = 0;
            int totalSpice = 0;
     
         
            
            for (int i = yield; i >=100; i-=10)
            {

                totalSpice += i;
              
                if (totalSpice >= 26)
                {

                    totalSpice -= 26;
                }


                
               

                daysCounter++;
            }
            if (totalSpice >= 26)
            {
            totalSpice -= 26;

            }
            Console.WriteLine(daysCounter);
            Console.WriteLine(totalSpice);

        }
    }
}
