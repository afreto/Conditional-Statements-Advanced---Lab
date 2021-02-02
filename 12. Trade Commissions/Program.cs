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
                switch (city)
                {
                    case "sofia":
                        commission = 5;
                        break;
                    case "varna":
                        commission = 4.5;
                        break;
                    case "plovdiv":
                        commission = 5.5;
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else if (salesVolume > 500 && salesVolume <= 1000)
            {
                switch (city)
                {
                    case "sofia":
                        commission = 7;
                        break;
                    case "varna":
                        commission = 7.5;
                        break;
                    case "plovdiv":
                        commission = 8;
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else if (salesVolume > 1000 && salesVolume <= 10000)
            {
                switch (city)
                {
                    case "sofia":
                        commission = 8;
                        break;
                    case "varna":
                        commission = 10;
                        break;
                    case "plovdiv":
                        commission = 12;
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else if (salesVolume > 10000)
            {
                switch (city)
                {
                    case "sofia":
                        commission = 12;
                        break;
                    case "varna":
                        commission = 13;
                        break;
                    case "plovdiv":
                        commission = 14.5;
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
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