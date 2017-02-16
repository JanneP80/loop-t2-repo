using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop_t4
{
    class Program
    {
        static void Main(string[] args)
        {

            // program sums up N numbers for negative numbers too.

            int n = 0;
            //int runningnumber = 1;
            int solution = 0;
            int negsolution = 0;
            string message = string.Empty;
            Console.Write("Please type amount of numbers for calculating their sum: ");

            bool userinput = int.TryParse(Console.ReadLine(), out n);
            if (!userinput) // incorrect input
            {
                message = "Input is NOT a number.";
            }
            else if (n == 0)
            {
                message = string.Format("You gave {0} numbers to sum, the sum is {1}.", n, n);
            }

            else if (n < 0)
            {
                Console.Write("Calculating... "); // negative calculation
                for (int runningnumber = -1; runningnumber > n+1; runningnumber--)
                {
                    Console.Write(" {0}", runningnumber); // error check line
                    negsolution = negsolution + runningnumber;

                }


                message = string.Format("You gave {0} numbers to sum, the sum is {1}.", n, negsolution);
            }

            else // positive calculation
            {
                Console.Write("Calculating... 1");
                for (int runningnumber = 1; runningnumber < n-1; runningnumber++)
                {
                    Console.Write(" {0}", runningnumber); // error check line
                    solution = solution + runningnumber;

                }


                message = string.Format("You gave {0} numbers to sum, the sum is {1}.", n, solution);
            }

            Console.WriteLine("\n" + message);
            Console.ReadKey();

        }
    }
}
