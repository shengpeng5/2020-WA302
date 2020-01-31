using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratice3
{
    class Program
    {
        static void Main(string[] args)
        {
            int mark = 36;
            string grade;

            if (mark >= 0 && mark <= 49)
            {
                grade = "F";
            }
            else if (mark <=69)
            {
                grade = "D";
            }
            else if (mark <= 79)
            {
                grade = "C";
            }
            else if (mark <= 89)
            {
                grade = "B";
            }
            else
            {
                grade = "A";
            }

            Console.WriteLine($"When you mark is {mark}, your grade will be {grade}!");
        }
    }
}
