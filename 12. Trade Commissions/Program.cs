using System;

namespace _12._Trade_Commissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine().ToLower();
            double salesVolume = double.Parse(Console.ReadLine());
            double commission = 0.0;
            if (salesVolume > 0 && salesVolume <= 500)
            {
                if (city == "sofia")
                {
                    commission = 5;
                }
               else if (city == "varna")
                {
                    commission = 4.5;
                }
               else if (city == "plovdiv")
                {
                    commission = 5.5;
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (salesVolume > 500 && salesVolume <= 1000)
            {
                if (city == "sofia")
                {
                    commission = 7;
                }
                else if (city == "varna")
                {
                    commission = 7.5;
                }
                else if (city == "plovdiv")
                {
                    commission = 8;
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (salesVolume > 1000 && salesVolume <= 10000)
            {
                if (city == "sofia")
                {
                    commission = 8;
                }
                else if (city == "varna")
                {
                    commission = 10;
                }
                else if (city == "plovdiv")
                {
                    commission = 12;
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (salesVolume > 10000)
            {
                if (city == "sofia")
                {
                    commission = 12;
                }
                else if (city == "varna")
                {
                    commission = 13;
                }
                else if (city == "plovdiv")
                {
                    commission = 14.5;
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                Console.WriteLine("error");
            }
            double finalCommission = (salesVolume * (commission / 100));
            if (finalCommission != 0)
            {
                Console.WriteLine($"{finalCommission:f2}");
            }
        }
    }
}
