using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {

        int n = int.Parse(Console.ReadLine());
        int max = int.MinValue;
        int sum = 0;

        for (int i = 0; i < n; i++)
        {

            int num = int.Parse(Console.ReadLine());
            sum += num;

            if (num > max)
            {
                max = num;
            }

        }

        if (sum - max == max)    // if(sum/2 == max)
        {
            Console.WriteLine("Yes");
            Console.WriteLine("Sum = {0}", max);
        }
        else
        {

            Console.WriteLine("No");
            Console.WriteLine("Diff = {0}", Math.Abs(sum - max - max));
        }

    }
}
