using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.TimeAfter15Min
{
    class Program
    {
        static void Main(string[] args)
        {

            int hours = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());

            min = min + 15;

            if (min > 59)
            {
                min = min - 60;
                hours++;
            }

            if (hours > 23)
            {
                hours = 0;
            }

            Console.WriteLine("{0}:{1:00}", hours, min);


        }
    }
}
