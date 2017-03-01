using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Ex._20Nov2016_morning__SoftUniCamp
{
    class Program
    {
        static void Main(string[] args)
        {

            int groups = int.Parse(Console.ReadLine());

            int peoplesInCar = 0;
            int peoplesInMicrobus = 0;
            int peoplesInSmallBus = 0;
            int peoplesInBus = 0;
            int peoplesInTrain = 0;


            for (int i = 0; i < groups; i++)
            {

                int peoples = int.Parse(Console.ReadLine());


                if (peoples <= 5)
                {
                    peoplesInCar += peoples;
                }
                else if (peoples <= 12)
                {
                    peoplesInMicrobus += peoples;
                }
                else if (peoples <= 25)
                {
                    peoplesInSmallBus += peoples;
                }
                else if (peoples <= 40)
                {
                    peoplesInBus += peoples;
                }
                else
                {
                    peoplesInTrain += peoples;
                }
            }

            int allPeople = peoplesInCar + peoplesInMicrobus + peoplesInSmallBus + peoplesInBus + peoplesInTrain;

            Console.WriteLine("{0:f2}%", (peoplesInCar) / allPeople * 100);
            Console.WriteLine("{0:f2}%", peoplesInMicrobus / allPeople * 100);
            Console.WriteLine("{0:f2}%", peoplesInSmallBus / allPeople * 100);
            Console.WriteLine("{0:f2}%", peoplesInBus / allPeople * 100);
            Console.WriteLine("{0:f2}%", peoplesInTrain / allPeople * 100);












        }
    }
}
         