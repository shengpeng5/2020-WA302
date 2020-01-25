using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            //int first, second, highest = -99;
            int number;
            const int Two = 2;
            string inputValue;

            //reuse, inputValue because the previous contents of inputValue has been store elsewhere
            Console.Write("Enter a number:\t");
            inputValue = Console.ReadLine();
            number = int.Parse(inputValue);

            if ((number % Two) == 0)
            {
                //true path coding block
                //true mean the condition on the if statement is true
                Console.WriteLine($"Your number {number} is even");
                Console.WriteLine("Your number {0} is even", number);
                Console.WriteLine("Your number" + number + "is even");

            }
            else
            {
                //false path coding block
                //false mean the condition on the if statement is false
                Console.WriteLine($"Your number {number} is odd");
            }//eof
        }//eom
    }//eoc
}//eon
