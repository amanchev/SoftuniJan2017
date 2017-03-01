using System;
class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int stars = 0;
        if (n%2==0)
        {
            stars = 2;
        }
        else
        {
            stars = 1;
        }

        for (int i = 0; i < (n+1)/2; i++)
        {
            if (i == 0)
            {
                Console.WriteLine("{0}{1}{0}",
                    new string('-', (n - stars) / 2),
                    new string('*', stars));
            }
            else
            {
                Console.WriteLine("{0}*{1}*{0}",
                    new string('-', (n - stars - 2)/2),
                    new string('-', stars)
                    );

                stars += 2;

            }

        }
        stars = stars - 2;
        for (int i = 0; i < n / 2 - 1; i++)
        {
            stars -= 2;


            Console.WriteLine("{0}*{1}*{0}",
                    new string('-', (n - stars - 2) / 2),
                    new string('-', stars)
                    );
        }

        if (n%2!=0)
        {
            Console.WriteLine("{0}{1}{0}",
                    new string('-', (n - stars) / 2),
                    new string('*', stars));
        }
        
    }
}

