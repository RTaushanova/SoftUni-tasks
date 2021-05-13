using System;

namespace демо
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Reading from console - each element is on new line;
            //string[] arr = new string[10];

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = Console.ReadLine();
            //}

            //Console.WriteLine(string.Join(" ",arr));          //intput: Gosho         output: Gosho Pesho
            //        Pesho


            // Reading from console - all elements are on the same line:
            //(1) STRING
            string[] arr = Console.ReadLine().Split();
            Console.WriteLine(string.Join(" ", arr));

        }
    }
}
