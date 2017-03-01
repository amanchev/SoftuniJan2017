using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12ex.Fort
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int halfWidth = n;
            int arrow = n / 2;
            int bottomDashes = halfWidth - arrow - 2;

            Console.WriteLine("/{0}\\{1}{1}/{0}\\",
                new string('^', arrow),
                new string('_', bottomDashes));

            for (int i = 0; i < n - 3; i++)
            {
                Console.WriteLine("|{0}|", new string(' ',2*n - 2));
            }

            Console.WriteLine("|{0}{1}{1}{0}|",
                new string(' ', halfWidth - 1 - bottomDashes),
                new string('_', bottomDashes));

            Console.WriteLine("\\{0}/{1}{1}\\{0}/",
                 new string('_', arrow),
                 new string(' ', bottomDashes));



        }
    }
}
