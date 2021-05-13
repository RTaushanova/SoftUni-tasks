using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01.Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            decimal totalPrice = 0;
            List<string> furn = new List<string>();

            while (input != "Purchase")
            {
                Regex pattern = new Regex(@">>(?<furniture12>[A-Za-z]+)<<(?<price>\d+\.?\d*)!(?<count>\d+)");
                Match match = pattern.Match(input);

                if (match.Success)
                {
                    string furniture = match.Groups["furniture12"].Value;
                    decimal price = decimal.Parse(match.Groups["price"].Value);
                    int count = int.Parse(match.Groups["count"].Value);

                    furn.Add(furniture);
                    totalPrice += count * price;
                }

                input = Console.ReadLine();
            }
            Console.WriteLine("Bought furniture:");

            //foreach (var furniture in furn)
            //{
            //    Console.WriteLine(furniture);
            //}

            if (furn.Count > 0)
            {

            Console.WriteLine(string.Join("\n", furn));
            }
            Console.WriteLine($"Total money spend: {totalPrice:f2}");
        }
    }
}
