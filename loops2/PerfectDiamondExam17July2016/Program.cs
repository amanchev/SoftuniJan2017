using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfectDiamondExam17July2016
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int width = 5 * n;

            Console.WriteLine("{0}{1}{0}",
                new string('.', n),
                new string('*', width - 2 * n));

            for (int i = 0; i < n - 1; i++)
            {
                Console.WriteLine("{0}*{1}*{0}",
                    new string('.', n - 1 - i),
                    new string('.', width - 2 - 2 * (n - 1 - i)));
            }

            Console.WriteLine(new string('*', width));

            for (int i = 1; i <= 2 * n; i++)
            {
                Console.WriteLine("{0}*{1}*{0}",
                    new string('.', i),
                    new string('.', width - 2 - (2 * i)));
            }

            Console.WriteLine("{0}{1}{0}",
                new string('.', (width - (n - 2)) / 2),
                new string('*', n - 2));
        }
    }
}
