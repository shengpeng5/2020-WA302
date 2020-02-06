using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iterations_Post_test
{
    class Program
    {
        static void Main(string[] args)
        {
            //int first, second, highest = -99;
            int number;
            const int Two = 2;
            string inputValue;
            string answer = "";
            //the loop structure demonstrated in this sample is a Post-test
            //Post-test is also known as Do Until
            //Post-test executes the code ONCE BEFORE the loop condition is tested
            //after the code has executed, the Post-test condition is still for true
            //if the condition is still true the loop code is re-executed
            //if the condition is false the loop terminates and execution
            //  continues with the remainder of the program

            do
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
                Console.Write("\n\nDo you you wish to continue play the Even or Odd game?");
                answer = Console.ReadLine();
            } while (answer.ToUpper().Equals("Y"));

            Console.WriteLine("\n\nYou terminated the loop with your last answer");
            Console.ReadKey();
        }
    }
}
