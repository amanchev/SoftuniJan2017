using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.DataAfterFiveDays
{
    class Program
    {
        static void Main(string[] args)
        {
            int d = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            
            int daysInMonth = 0;
            switch (m)
            {
                case 4:
                case 6:
                case 9:
                case 11:
                    daysInMonth = 30;
                    break;

                case 2:
                    daysInMonth = 28;
                    break;

                default:
                    daysInMonth = 31;
                    break;
            }

            d += 5;

            if (d > daysInMonth)
            {
                d = d - daysInMonth;
                m++;
            }
            
            if (m > 12)
            {
                m = m - 12;
            }
            Console.WriteLine($"{d}.{m:00}");
        }
    }
}
