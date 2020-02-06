using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iterations
{
    class Program
    {
        static void Main(string[] args)
        {
            //int first, second, highest = -99;
            int number;
            const int Two = 2;
            string inputValue;

            //the loop structure demonstrated in this sample is a Pre-test
            //Pre-test is also known as Do While
            //Pre-test checks to see if the condition is true BEFORE executing the code
            //after the code has executed, the Pre-test condition is still true
            //if the condition is still true the loop code is re-executed
            //if the condition is false the loop terminates and execution
            //  continues with the remainder of the program

            Console.Write("Doyou you wish to play the Even or Odd game?");
            string answer = Console.ReadLine();

            //the loop construction
            //answer.ToUpper().Equals("Y")
            //answer == "Y" || answer == "y"
            while(answer.Equals("Y") || answer.Equals("y"))
            {
                //within this coding block you are inside your loop
                //this loop will terminate if answer is not Yy

                //TO DO: place your loop logic here
                Console.Write("Enter a number:\t");
                inputValue = Console.ReadLine();
                number = int.Parse(inputValue);

                if ((number % Two) == 0)
                {

                    Console.WriteLine($"Your number {number} is even");
                }
                else
                {
                    Console.WriteLine($"Your number {number} is odd");

                }//eof

                //ask if the user wishes to continue to play the game
                //give the user an opportunity to exit the loop
                Console.Write("\n\nDo you you wish to play the Even or Odd game?");
                answer = Console.ReadLine();
            }//eow end of while

            Console.WriteLine("\n\nYou terminated the loop with your last answer");
            Console.ReadKey();
        }
    }
}
