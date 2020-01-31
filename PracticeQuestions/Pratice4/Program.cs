using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratice4
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Please enter your taxable income");
            int taxIncome = int.Parse(Console.ReadLine());
            double totaltax = 0;
            if (taxIncome <= 50000)
            {
                totaltax = (0 + (taxIncome * 0.05));
            }
            else if (taxIncome > 50000 && taxIncome < 100000)
            {
                totaltax = (2500 + (taxIncome * 0.07));
            }
            else if(taxIncome >= 100000)
            {
                totaltax = (6000 + (taxIncome * 0.09));
            }
            Console.WriteLine($"Taxable income is {taxIncome:c0}, Tax Due will be {totaltax:c0}");
        }
    }
}
