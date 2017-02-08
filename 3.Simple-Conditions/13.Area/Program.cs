using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Area
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            double a;
            double b;
            double r;
            double h;

            switch (figure)
            {
                case "square":
                    a = double.Parse(Console.ReadLine());
                    Console.WriteLine("{0:F3}", a*a);
                    break;
                case "rectangle":
                    a = double.Parse(Console.ReadLine());
                    b = double.Parse(Console.ReadLine());
                    Console.WriteLine("{0:F3}", a *b);
                    break;
                case "circle":
                    r = double.Parse(Console.ReadLine());
                    Console.WriteLine("{0:F3}", Math.PI * r * r);
                    break;
                case "triangle":
                    a = double.Parse(Console.ReadLine());
                    h = double.Parse(Console.ReadLine());

                    Console.WriteLine("{0:F3}", a * h / 2);
                    break;
            }
        }
    }
}
