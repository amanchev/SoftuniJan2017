using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.SumOfNumDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int ones = n % 10;
            int sum = ones;

            while ((n / 10 != 0))
            {
                n = n / 10;
                ones = n % 10;
                sum += ones;
            }
            Console.WriteLine(sum);

        }
    }
}
