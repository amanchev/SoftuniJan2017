using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Equal
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int prevSum = 0;
            bool isAllEqual = true;
            int maxDiff = int.MinValue;






            for (int i = 0; i < n; i++)
            {

                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                sum = a + b;

                if (i != 0)
                {
                    if (sum != prevSum)
                    {
                        isAllEqual = false;
                        int diff = Math.Abs(sum - prevSum);

                        if (diff > maxDiff)
                        {
                            maxDiff = diff;
                        }
                    }
                }
                
                prevSum = sum;
            }


            if (isAllEqual)
            {
                Console.WriteLine("Yes, value={0}", sum);
            }
            else
            {
                Console.WriteLine("No, maxdiff={0}",maxDiff);
            }
        }
    }
}
