using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemainderOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Create a simple program to write out the results of a division operation. Create two
                integer variables called a and b. Create a third integer variable called quotient (the result of a
                division) that stores the result of the division of a and b, and another integer variable called
                remainder that stores the remainder (using the % operator). Write out the results using
                Console.WriteLine or Console.Write to write out the results in the following form: if a = 17 and b = 4,
                print the following:
                 17/4 is 4 remainder 1
                For bonus points check your work. Create another variable and store in it b * quotient + remainder.
                Print this value out as well. This value should be the same as a in all cases.
                Edit your code to try multiple values for a and b to ensure it’s working like it should.
             */
            #region Variables
            int? a = null, b = null, remainder, quotient, bonus;
            #endregion

            #region Introduction

            Console.WriteLine("Hello André! We are going to divide 2 numbers using only integers.");
            Console.WriteLine("Please don't worry if some results dont match the decimal precision.");
            
            #endregion

            #region Dividend
            while (a is null)
            {
                Console.WriteLine("\nPlease insert the first number (dividend):");

                bool isnumber = Int32.TryParse(Console.ReadLine(), out int aaux);

                if (isnumber == true)
                {
                    a = aaux;
                    Console.WriteLine("The dividend is: " + a);
                }
                else
                {
                    Console.WriteLine("Please insert a number.");
                }
            }
            #endregion

            #region Divisor
            while (b is null || b == 0)
            {
                Console.WriteLine("\nPlease insert the second number (divisor):");

                bool isnumber = Int32.TryParse(Console.ReadLine(), out int baux);

                if (isnumber == true && baux != 0)
                {
                    b = baux;

                    Console.WriteLine("The divisor is: " + b);
                }
                else if (isnumber == true && baux == 0)
                {
                    Console.WriteLine("Error: Cannot Divide by 0 !");
                }
                else
                {
                    Console.WriteLine("Please insert a number.");
                }
            }
            #endregion

            #region Results
            quotient = a / b;
            Console.WriteLine($"\nThe result of dividing {a} by {b} is: {quotient}");

            remainder = a % b;
            Console.WriteLine($"The remainder of this division is: {remainder}");

            Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");

            bonus = b * quotient + remainder;
            Console.WriteLine($"The value {bonus} should be equal to {a}");
            #endregion

            Console.ReadKey();
        }
    }
}
