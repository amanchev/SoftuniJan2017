using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSwitch
{
    class Program
    {
        static void Main(string[] args)
        {

            int password = 2;

            switch (password)
            {
                case 5:
                    Console.WriteLine("Welcome, Gosho!");
                    break;
                case 1:
                case 9:
                case 98:
                    Console.WriteLine("Welcome");
                    break;
                default:
                    Console.WriteLine("Wrong Password");
                    break;
               
                
            }

        }
    }
}
