using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19ex.PoolTubes
{
    class Program
    {
        static void Main(string[] args)
        {


            int v = int.Parse(Console.ReadLine());
            int p1 = int.Parse(Console.ReadLine());
            int p2 = int.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double p1Litters = p1 * h;
            double p2Litters = p2 * h;

            double litters = p1Litters + p2Litters;

            if (litters <= v)
            {

                double fullPercent = litters / v * 100;
                double p1Percent = p1Litters / litters * 100;
                double p2Percent = p2Litters / litters * 100;

                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.", Math.Truncate(fullPercent),Math.Truncate(p1Percent),Math.Truncate(p2Percent));
            }
            else
            {
                Console.WriteLine("For {0} hours the pool overflows with {1} liters.",h, litters - v);
            }
            

        }
    }
}
