using System;

namespace _08.Cinema_Ticket
{
    class Program
    {
        static void Main(string[] args)
        {

            string day = Console.ReadLine().ToLower();
            int price=0;

            switch (day)
            {
                case "monday":
                    price = 12;
                    break;
                case "tuesday":
                    price = 12;
                    break;
                case "wednesday":
                    price = 14;
                    break;
                case "thursday":
                    price = 14;
                    break;
                case "friday":
                    price = 12;
                    break;
                case "saturday":
                    price = 16;
                    break;
                case "sunday":
                    price = 16;
                    break;
                default:
                    break;
            }
            Console.WriteLine(price);
        }
    }
}
