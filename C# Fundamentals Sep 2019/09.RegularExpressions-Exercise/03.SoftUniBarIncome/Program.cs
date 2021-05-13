using System;
using System.Text.RegularExpressions;

namespace _03.SoftUniBarIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double totalIncome = 0;

            while (input != "end of shift")
            {
                Regex customerPattern = new Regex(@"%[A-Z][a-z]+%");
                Regex productPattern = new Regex(@"<\w+>");
                Regex countPattern = new Regex(@"\|[0-9]{1,}\|");
                Regex pricePattern = new Regex(@"([0-9]{1,}\.[0-9]{1,}\$)|([0-9]{1,}\$)");

                Match matchesCustomers = customerPattern.Match(input);
                Match matchesProducts = productPattern.Match(input);
                Match matchesCounts = countPattern.Match(input);
                Match matchesPrices = pricePattern.Match(input);

                string name = "";
                string product = "";
                string count = "";
                string price = "";
                double totalPrice = 0;

                if (matchesCustomers.Success && matchesProducts.Success && matchesCounts.Success && matchesPrices.Success)
                {

                    for (int i = 0; i < matchesCustomers.Length; i++)
                    {
                        if (i >= 1 && i < matchesCustomers.Length - 1)
                        {
                            name += matchesCustomers.Value[i];
                        }
                    }
                    for (int i = 0; i < matchesProducts.Length; i++)
                    {
                        if (i >= 1 && i < matchesProducts.Length - 1)
                        {
                            product += matchesProducts.Value[i];
                        }
                    }
                    for (int i = 0; i < matchesCounts.Length; i++)
                    {
                        if (i >= 1 && i < matchesCounts.Length - 1)
                        {
                            count += matchesCounts.Value[i];
                        }
                    }
                    for (int i = 0; i < matchesPrices.Length; i++)
                    {
                        if (i >= 0 && i < matchesPrices.Length - 1)
                        {
                            price += matchesPrices.Value[i];
                        }
                    }
                    int currentCount = int.Parse(count);
                    double currentPrice = double.Parse(price);
                    totalPrice = currentCount * currentPrice;

                    Console.WriteLine($"{name}: {product} - {totalPrice:f2}");
                    totalIncome += totalPrice;
                }


                input = Console.ReadLine();
            }
            Console.WriteLine($"Total income: {totalIncome:f2}");
        }
    }
}
