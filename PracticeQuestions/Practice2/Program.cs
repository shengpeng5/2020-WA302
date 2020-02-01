using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 19;
            string people;
            string money;

            if(age <= 6)
            {
                people = "Child";
                money = "FREE";

            }
            else
            {
                if(age <= 17)
                {
                    people = "Students";
                    money = "$9.80";
                }
                else
                {
                    if(age <= 54)
                    {
                        people = "Adults";
                        money = "$11.35";
                    }
                    else
                    {
                        people = "Seniors";
                        money = "$10.00";
                    }
                }
            }//eos

            Console.WriteLine($"Cunstomer age is {people} price is {money}");
        }
    }
}
