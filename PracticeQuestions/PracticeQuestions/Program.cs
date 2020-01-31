using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQuestions
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 6;
            string result;

            if(number > 0)
            {
                result = "positive";

            }
            else
            {
                if(number < 0)
                {
                    result = "negative";
                }
                else
                {
                    result = "equal to zero";
                }
            }

            Console.WriteLine($"{number} is {result}");
            Console.ReadKey();
        }
    }
}
