using System;

namespace _07.VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            double totalMoney = 0;
            double receivedMoney = 0;
            while (command != "Start")
            {
                if (command == "0.1" || command == "0.2" || command == "0.5" || command == "1" || command == "2")
                {
                    receivedMoney = double.Parse(command);
                    totalMoney += receivedMoney;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {command}");

                }

     
                command = Console.ReadLine();
            }

            command = Console.ReadLine();

            while (command != "End")
            {
                double price = 0; 

                if (command == "Nuts")
                {
                    price = 2.0;
                   
                }
                else if (command == "Water")
                {
                    price = 0.7;
                    
                }
                else if (command == "Crisps")
                {
                    price = 1.5;
                    
                }
                else if (command == "Soda")
                {
                    price = 0.8;
                    
                }
                else if (command == "Coke")
                {
                    price = 1.0;
                    
                }
                else
                {
                    Console.WriteLine("Invalid product");
                    command = Console.ReadLine();
                    continue;
                }

                if (totalMoney < price)
                {
                    Console.WriteLine("Sorry, not enough money");
                    
                }
                else
                {
                    Console.WriteLine($"Purchased {command.ToLower()}");
                    totalMoney -= price;
                }


               

                command = Console.ReadLine();
            }
            if (command == "End")
            {
            Console.WriteLine($"Change: {totalMoney:f2}");

            }
        }
    }
}
