using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19ex.HotelRooms
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double apartamentPrice = 0;
            double studioPrice = 0;
            double studioDiscount = 0;

            switch (month)
            {
                case "May":
                case "October":
                    apartamentPrice = 65.0;
                    studioPrice = 50.0;

                    if (nights > 14)
                    {
                        studioDiscount = 30d/100d;
                    }
                    else if (nights > 7)
                    {
                        studioDiscount = 5d / 100d;
                    }
                    break;

                case "June":
                case "September":
                    studioPrice = 75.2;
                    apartamentPrice = 68.7;

                    if (nights > 14)
                    {
                        studioDiscount = 20d / 100d;
                    }

                    break;

                case "July":
                case "August":
                    studioPrice = 76.0;
                    apartamentPrice = 77.0;

                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }

            double apartamentDiscount = 0;
            if (nights > 14)
            {
                apartamentDiscount = 10d / 100;
            }

            Console.WriteLine("Apartment: {0:f2} lv.", apartamentPrice * nights - (apartamentPrice *nights * apartamentDiscount));
            Console.WriteLine("Studio: {0:f2} lv.", studioPrice * nights - (studioPrice * nights * studioDiscount) );


        }
    }
}
