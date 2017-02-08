using System;
class Program
{
    static void Main(string[] args)
    {

        double km = double.Parse(Console.ReadLine());
        string dayOrNight = Console.ReadLine();

        double taxi;
        double bus;
        double train;
        
        if (dayOrNight == "day")
        {
            taxi = 0.7 + 0.79 * km;
        }
        else
        {
            taxi = 0.7 + 0.9 * km;           
        }
        
        if(km < 20)
        {
            Console.WriteLine(taxi);
        }
        else if (km < 100)
        {
            bus = 0.09 * km;
            Console.WriteLine(Math.Min(taxi,bus));
        }
        else
        {
            bus = 0.09 * km;
            train = 0.06 * km;
            Console.WriteLine(Math.Min(Math.Min(taxi, bus), train));
        }
    }
}

