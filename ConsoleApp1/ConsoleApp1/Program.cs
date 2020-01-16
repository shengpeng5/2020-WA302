using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal Mile;
            decimal Kilometre;
            decimal TotalM = 0.0m;
            decimal TotalKM = 0.0m;

            const decimal ImperialTotalKMValue = 1.60934m;

            Mile = 3m;

            TotalKM = Mile * ImperialTotalKMValue;
            Console.WriteLine("According to your Mile {0:0.0}: your Total KM is {1:0.00} ", Mile, TotalKM);


            Kilometre = 3m;

            const decimal ImperialTotalMValue = 0.621371m;

            TotalM = Kilometre * ImperialTotalMValue;
            Console.WriteLine("According to your Kilometre {0:0.0}: your Total M is {1:0.00}", Kilometre, TotalM);

        }
    }
}
