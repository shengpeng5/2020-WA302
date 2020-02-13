using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menuloop
{
    class Program
    {
        static void Main(string[] args)
        {
            //generic menu setup
            //loop: post-loop
            //loop contents
            //  prompt for menu option
            //  switch with case for each option, default is bad menu option
            //  within the case we will simple output a message
            //decide how to terminate your loop
            string meanuOption = "";

            do
            {
                //prompts
                Console.WriteLine("Select a option from the following menu:");
                Console.WriteLine("A) Do CASE A");
                Console.WriteLine("B) Do CASE B");
                Console.WriteLine("C) Do CASE C");
                Console.WriteLine("X) Exit\n");

                Console.Write("Enter your menu option:\t");
                meanuOption = Console.ReadLine();
                switch (meanuOption.ToUpper())
                {
                    case "A":
                        {
                            Console.WriteLine($"You entered the menu option of A.\n\n");
                            break;
                        }
                    case "B":
                        {
                            Console.WriteLine($"You entered the menu option of B.\n\n");
                            break;
                        }
                    case "C":
                        {
                            Console.WriteLine($"You entered the menu option of C.\n\n");
                            break;
                        }
                    case "X":
                        {
                            Console.WriteLine($"Thank you. Come again\n\n");
                            break;
                        }
                    default:
                        {
                            //this case acts as a validation for the proper value of a meanuOption
                            Console.WriteLine($"Your menu option choice of {meanuOption} is incorrect. Try again," + ".\n\n");
                            break;
                        }
                }
                } while (!(meanuOption.ToUpper() != "X"));
            Console.ReadKey();
        }
    }
}
