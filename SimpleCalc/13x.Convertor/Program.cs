using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13x.Convertor
{
    class Program
    {
        static void Main(string[] args)
        {

            double n = double.Parse(Console.ReadLine());
            string val1 = Console.ReadLine();
            string val2 = Console.ReadLine();

            double usd = 1.79549;
            double eur = 1.95583;
            double gbp = 2.53405;

            if (val1 == "USD")
            {
                n = n * usd;
            }
            else if (val1 == "EUR")
            {
                n = n * usd;
            }
            else if (val1 == "GBP")
            {
                n = n * usd;
            }

            if (val2 == "USD")
            {
                n = n / usd;
            }
            else if (val2 == "EUR")
            {
                n = n / eur;
            }
            else if (val2 == "GBP")
            {
                n = n / gbp;
            }



            Console.WriteLine(Math.Round(n,2) + " " + val2);
        }
    }
}
