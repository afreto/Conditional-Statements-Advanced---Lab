using System;

namespace _13._Ski_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string roomType = Console.ReadLine();
            string feedback = Console.ReadLine();
            double priceForSleep = 0;
            double discount = 0;
            switch (roomType)
            {
                case "room for one person":
                    priceForSleep = (days - 1) * 18.00;
                    break;
                case "apartment":
                    priceForSleep = (days - 1) * 25.00;
                    break;
                case "president apartment":
                    priceForSleep = (days - 1) * 35.00;
                    break;
            }

            switch (roomType)
            {
                case "apartment":
                    if (days < 10)
                    {
                        discount = 0.30;
                    }
                    else if (days >= 10 && days < 15)
                    {
                        discount = 0.35;
                    }
                    else if (days >= 15)
                    {
                        discount = 0.50;
                    }

                    break;
                case "president apartment":
                    if (days < 10)
                    {
                        discount = 0.10;
                    }
                    else if (days >= 10 && days < 15)
                    {
                        discount = 0.15;
                    }
                    else if (days >= 15)
                    {
                        discount = 0.20;
                    }

                    break;
            }

            double totalSum = priceForSleep - (priceForSleep * discount);
            switch (feedback)
            {
                case "positive":
                    totalSum += totalSum * 0.25;
                    break;
                case "negative":
                    totalSum -= totalSum * 0.10;
                    break;
            }

            Console.WriteLine($"{totalSum:f2}");
        }
    }
}
