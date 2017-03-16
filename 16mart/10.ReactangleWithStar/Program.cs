using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.ReactangleWithStar
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int width = 2 * n;
            int height = 0;

            if (n % 2 == 0)
            {
                height = n + 1;
            }
            else
            {
                height = n + 2;
            }


            for (int i = 0; i < height; i++)
            {
                int stars = 0;
                int spaces = 0;
                int percent = 0;
                if (i == 0 || i == height - 1)
                {
                    percent = width / 2;
                }
                else if (i == height / 2)
                {
                    percent = 1;
                    spaces = (width - 4) / 2;
                    stars = 2;
                }
                else
                {
                    percent = 1;
                    spaces = (width - 2) / 2;

                }

                Console.WriteLine("{2}{0}{1}{0}{2}", new string(' ', spaces), new string('*', stars), new string('%', percent));



            }






        }
    }
}
