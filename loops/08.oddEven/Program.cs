using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.LeftRight
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            int evenSum = 0;
            int oddSum = 0;

            for (int i = 0; i < n; i++)
            {
                int a = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    evenSum += a;
                }
                else
                {
                    oddSum += a;
                }
            }

            if (evenSum == oddSum)
            {
                Console.WriteLine("Yes, sum = {0}", evenSum);
            }
            else
            {
                Console.WriteLine("No, diff = {0}", Math.Abs(evenSum - oddSum));
            }





        }
    }
}
