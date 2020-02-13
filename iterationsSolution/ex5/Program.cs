using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            //query user for a number
            //validate a number was entered(integer)
            //if a number was entered check for even /odd
            //continue unless a 0 was enter then exit

            //to validate a string to contain an number
            //  use the xxx.TryParse of the number datatype
            //  syntax of .TryParse(string, out variablename)
            //  string hold the value to test
            //if the value is good 
            //  the number is automatically place in your variable
            //  the test returns a boolean true
            //if the value is NOT good
            //  NO value is placed in your variable
            //  the test returns a boolean false

            int number = -1;
            string inputString = "";

            while(number != 0)
            {
                bool validFlag = false;
                do
                {
                    Console.Write("Enter a positive whole number OR Enter 0 to quit.");
                    inputString = Console.ReadLine();
                    if (int.TryParse(inputString, out number))
                    {
                        validFlag = true;
                    }
                } while (validFlag == false); ; //(!int.TryParse(inputString, out number))

                if(number>0)
                {
                    if(number % 2 == 0)
                    {
                        Console.WriteLine($"{number} is an even value.\n\n");
                    }
                    else
                    {
                        Console.WriteLine($"{number} is an odd value.\n\n");
                    }
                }
                else
                {
                    if(number == 0)
                    {
                        Console.WriteLine($"thank you. come again.\n\n");
                    }
                    else
                    {
                        Console.WriteLine($"{number} is invalid. Try again\n\n");
                    }
                }
            }
        }
    }
}
