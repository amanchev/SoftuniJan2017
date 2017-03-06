using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16ex.Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());

            for (int first = 1; first < n; first++)
            {
                for (int second = 1; second < n; second++)
                {
                    for (char third = 'a'; third < 'a' + l; third++)
                    {
                        for (char fourth = 'a'; fourth < 'a' + l; fourth++)
                        {
                            for (int fifth = 0; fifth <= n ; fifth++)
                            {
                                if (fifth == 0)
                                {
                                    if (first > second)
                                    {
                                        fifth = first + 1;
                                    }
                                    else
                                    {
                                        fifth = second + 1;
                                    }
                                }
                                Console.Write("{0}{1}{2}{3}{4} ",first,second,third,fourth,fifth);
                            }
                        }
                    }
                }
            }

        }
    }
}
