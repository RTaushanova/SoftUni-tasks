using System;

namespace _01.Ages
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            string type = "";

            if (age <= 2)
            {
                type = "baby";
            }
            else if (age <= 13)
            {
                type = "child";
            }
            else if (age <= 19)
            {
                type = "teenager";
            }
            else if (age <= 65)
            {
                type = "adult";
            }
            else if ( age >= 66)
            {
                type = "elder";
            }
            Console.WriteLine(type);
        }
    }
}
