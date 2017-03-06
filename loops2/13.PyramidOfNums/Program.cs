using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.PyramidOfNums
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            int counter = 1;

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    counter = row + col + 1;

                    if (counter < n)
                    {
                        Console.Write(counter + " ");
                    }
                    else
                    {
                        counter = 2 * n - counter;
                        Console.Write(counter + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
