using System;

namespace _10.LowerToUpper
{
    class Program
    {
        static void Main(string[] args)
        {
            //char letter = char.Parse(Console.ReadLine());

            //bool result = Char.IsUpper(letter);

            //if (result == true)
            //{
            //    Console.WriteLine("upper-case");
            //}
            //else
            //{
            //    Console.WriteLine("lower-case");
            //}

            char letter = char.Parse(Console.ReadLine());

            if (Char.IsUpper(letter))
            {
                Console.WriteLine("upper-case");
            }
            else
            {
                Console.WriteLine("lower-case");
            }
        }
    }
}
