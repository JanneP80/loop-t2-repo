using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop_t2_repo
{
    class Program
    {
        static void Main(string[] args)
        {
            // program sums up N numbers.

            int n = 0;
            //int runningnumber = 1;
            int solution = 0;
            string message = string.Empty;
            Console.Write("Please type amount of numbers for calculating their sum: ");

            bool userinput = int.TryParse(Console.ReadLine(), out n);
            if (!userinput) // incorrect input
            {
                message = "Input is NOT a number.";
            }
            else if (n < 1)
            {
                message = "Please insert number over 1.";
            }

            else // calculation
            {
                Console.Write("Calculating... ");
                for (int runningnumber = 1; runningnumber < n+1; runningnumber++)
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
