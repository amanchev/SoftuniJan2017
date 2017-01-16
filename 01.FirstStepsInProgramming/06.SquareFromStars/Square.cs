using System;
class Square
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("{0}", new string('*',n));

        for (int i = 0; i < n -2; i++)
        {
            Console.WriteLine("*{0}*", new string(' ', n - 2));
        }



        Console.WriteLine("{0}", new string('*',n));
    }
}
