using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Complex_condition
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int places = r * c;
            double price = 0;

            switch (type)
            {
                case "Premiere":
                    price = 12.0;
                    break;
                case "Normal":
                    price = 7.5;
                    break;
                case "Discount":
                    price = 5.0;
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }

            double result = places * price;
            Console.WriteLine("{0:f2}", result);

        }
    }
}
