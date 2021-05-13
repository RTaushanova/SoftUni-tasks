using System;

namespace _09.PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double lightsabersPrice = double.Parse(Console.ReadLine());
            double robesPrice = double.Parse(Console.ReadLine());
            double beltsPrice = double.Parse(Console.ReadLine());

            double discount = 0;
            double neededMoney = 0;
            

            int freeBelts = students / 6;           // целочислено делене

                if (freeBelts >= 1)
                {
                   discount = freeBelts * beltsPrice;
                }


                double lightsabersPriceTotal = Math.Ceiling(students *1.1)*lightsabersPrice;
                double robesPriceTotal = students * robesPrice;
                double beltsPriceTotal = students * beltsPrice - discount;

                neededMoney = lightsabersPriceTotal + robesPriceTotal + beltsPriceTotal;

                if (neededMoney <= budget)
                {
                    Console.WriteLine($"The money is enough - it would cost {neededMoney:f2}lv.");
                    
                }
                else
                {
                    Console.WriteLine($"Ivan Cho will need {neededMoney-budget:f2}lv more.");
                   
                }
                
            
        }
    }
}
