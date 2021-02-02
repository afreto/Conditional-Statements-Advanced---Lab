using System;

namespace _05._Small_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine().ToLower();
            string city = Console.ReadLine().ToLower();
            double quantity = double.Parse(Console.ReadLine());
            double productPrice = 0.0;
            switch (city)
            {
                case "sofia":
                    switch (product)
                    {
                        case "coffee":
                            productPrice = 0.50;
                            break;
                        case "water":
                            productPrice = 0.80;
                            break;
                        case "beer":
                            productPrice = 1.20;
                            break;
                        case "sweets":
                            productPrice = 1.45;
                            break;
                        case "peanuts":
                            productPrice = 1.60;
                            break;
                    }
                    break;
                case "plovdiv":
                    switch (product)
                    {
                        case "coffee":
                            productPrice = 0.40;
                            break;
                        case "water":
                            productPrice = 0.70;
                            break;
                        case "beer":
                            productPrice = 1.15;
                            break;
                        case "sweets":
                            productPrice = 1.30;
                            break;
                        case "peanuts":
                            productPrice = 1.50;
                            break;
                    }
                    break;
                case "varna":
                    switch (product)
                    {
                        case "coffee":
                            productPrice = 0.45;
                            break;
                        case "water":
                            productPrice = 0.70;
                            break;
                        case "beer":
                            productPrice = 1.10;
                            break;
                        case "sweets":
                            productPrice = 1.35;
                            break;
                        case "peanuts":
                            productPrice = 1.55;
                            break;
                    }
                    break;
                
            }
            Console.WriteLine(quantity * productPrice);
        }
    }
}
