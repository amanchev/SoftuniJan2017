using System;
class TriangleFromStars
{
    static void Main(string[] args)
    {

        

        for (int i = 1; i <= 10; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write('*');
            }
            Console.WriteLine();
        }


        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(new String('*', i));
        }


       
    }

}

