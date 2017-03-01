using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Voleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine();
            int p = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());

            double saturdaysInSofia = (48 - h) * (3.0/4.0);
            double holidaysInSofia = p * 2.0 / 3.0;

            double allGames = saturdaysInSofia + holidaysInSofia + h;

            if (year == "leap")
            {
                allGames = allGames + allGames * 15.0 / 100.0;
            }

            Console.WriteLine(Math.Truncate(allGames));
        }
    }
}
