using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int prevNum = 0;
            int counter = 1;
            int maxCounter = 1;

            // 5   1 2 1 2 3
            if (n == 0)
            {
                maxCounter = 0;
            }
            else
            {

                for (int i = 1; i <= n; i++)
                {
                    int num = int.Parse(Console.ReadLine());

                    if (i != 1)
                    {


                        if (prevNum < num)
                        {
                            counter++;
                            if (counter > maxCounter)
                            {
                                maxCounter = counter;
                            }
                        }
                        else
                        {
                            counter = 1;
                        }

                    }
                    prevNum = num;


                }
            }
            Console.WriteLine(maxCounter);

        }
    }
}
