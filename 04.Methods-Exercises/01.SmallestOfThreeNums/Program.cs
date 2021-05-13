using System;

namespace _01.SmallestOfThreeNums
{
    class Program
    {
        static int SmallestNumber(int first, int second)
        {
            if (first < second)
            {
                return first;
            }
            else
            {
                return second;
            }
        }


        static void Main(string[] args)
        {

            int minNumber = int.MaxValue;

            for (int i = 0; i < 3; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                minNumber = SmallestNumber(currentNumber, minNumber);
            }
            Console.WriteLine(minNumber);
            
            
            
            
            
            
        
            
            //    int num1 = int.Parse(Console.ReadLine());
        //    int num2 = int.Parse(Console.ReadLine());
        //    int num3 = int.Parse(Console.ReadLine());

        //    int firstResult = SmallerNumber(num1, num2);
        //    int finalResult = SmallerNumber(firstResult, num3);

        //    Console.WriteLine(finalResult);
            
        //}


        //static int SmallerNumber(int first, int second)
        //{
        //    if (first < second)
        //    {
        //        return first;
        //    }
        //    else
        //    {
        //        return second;
        //    }
               
        }

    

    }
}
