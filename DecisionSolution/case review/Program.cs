using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace case_review
{
    class Program
    {
        static void Main(string[] args)
        {
            //pring out the month name
            int mounthNumber = 6;

            //there is a single argument variable
            //this single argument variable will be tested against multiple constant values
            //The case test is an == test
            switch (mounthNumber)
            {
                case 1:
                    {
                        //do any logic that is required when monthNumber is 1
                        //this could be one line of code or 100000lines of code
                        Console.WriteLine("the name of the month is January.");
                        break;
                    }
                case 2:
                    {
                        //do any logic that is required when monthNumber is 1
                        //this could be one line of code or 100000lines of code
                        Console.WriteLine("the name of the month is February.");
                        break;
                    }
                case 3:
                    {
                        //do any logic that is required when monthNumber is 1
                        //this could be one line of code or 100000lines of code
                        Console.WriteLine("the name of the month is March.");
                        break;
                    }
                case 4:
                    {
                        //do any logic that is required when monthNumber is 1
                        //this could be one line of code or 100000lines of code
                        Console.WriteLine("the name of the month is April.");
                        break;
                    }
                case 5:
                    {
                        //do any logic that is required when monthNumber is 1
                        //this could be one line of code or 100000lines of code
                        Console.WriteLine("the name of the month is May.");
                        break;
                    }
                default:
                    {
                        //this logic is done if one of the previous cases was not executed.
                        //any necessary logic
                        Console.WriteLine("Too late in the year to think any more.");
                        break;
                    }
                    
            }

        }
    }
}
