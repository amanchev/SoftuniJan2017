using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10x.Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int constant = 0;

            if (n%2!=0)
            {
                Console.WriteLine("{0}*{0}", new string('-', (n-1) / 2));

                constant = 1;
            }


            
                for (int i = 0; i < n / 2; i++)
                {
                    Console.WriteLine("{0}*{1}*{0}",
                        new string('-', n / 2 - i - constant),
                        new string('-', i * 2));
                }

                for (int i = n / 2 - 2; i >= 0; i--)
                {
                    Console.WriteLine("{0}*{1}*{0}",
                        new string('-', n / 2 - i - constant),
                        new string('-', i * 2));
                }


            if (n%2!=0)
            {
                Console.WriteLine("{0}*{0}", new string('-', (n-1) / 2 ));

            }

        }
    }
}