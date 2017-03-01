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

            int leftSum = 0;
            int rightSum = 0;

            for (int i = 0; i < 2*n; i++)
            {
                int a = int.Parse(Console.ReadLine());

                if (i < n)
                {
                    leftSum += a;
                }
                else
                {
                    rightSum += a;
                }
            }

            if (leftSum == rightSum)
            {
                Console.WriteLine("Yes, sum = {0}", leftSum);
            }
            else
            {
                Console.WriteLine("No, diff = {0}", Math.Abs(leftSum - rightSum));
            }





        }
    }
}
