using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14ex.Stop
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int width = n*4 + 3;
            int dots = n + 1;
            int underline = width - dots * 2;

            Console.WriteLine("{0}{1}{0}",
                new string('.', dots),
                new string('_', underline));


            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}//{1}\\\\{0}",
                    new string('.',n - i),
                    new string('_', width - 2*(n-i) - 4));
            }

            Console.WriteLine("//{0}STOP!{0}\\\\",new string('_',(width - 5 - 4)/2));


            for (int i = n; i > 0; i--)
            {
                Console.WriteLine("{0}\\\\{1}//{0}",
                    new string('.', n - i),
                    new string('_', width - 2 * (n - i) - 4));
            }

        }
    }
}
