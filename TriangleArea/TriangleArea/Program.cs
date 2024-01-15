using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double TriangleBase = 0;
            double TriangleHeight = 0;
            double TriangleArea = 0;  

            Console.WriteLine("Hello André ! We are going to calculate the Area of a triangle.");

            #region TriangleBase
            while (TriangleBase == 0)
            {
                Console.WriteLine("\nInsert the value of the triangle's base in cm:");
                bool isnumber = Double.TryParse(Console.ReadLine(), out TriangleBase);

                if (isnumber == true && TriangleBase > 0)
                {
                    Console.WriteLine("The triangle's BASE is: " + TriangleBase + " cm");
                }
                else if (isnumber == true && TriangleBase <= 0d)
                {
                    Console.WriteLine("Please Insert a number bigger than 0.");
                }
                else
                {   
                    Console.WriteLine("Please insert a number.");
                }
            }
            #endregion

            #region Triangle Height
            while (TriangleHeight == 0)
            {
                Console.WriteLine("\nInsert the value of the triangle's HEIGHT in cm:");
                bool isnumber = Double.TryParse(Console.ReadLine(), out TriangleHeight);

                if (isnumber == true && TriangleHeight > 0)
                {
                    Console.WriteLine("The triangle's HEIGHT is: " + TriangleHeight + " cm");
                }
                else if (isnumber == true && TriangleHeight <= 0f)
                {
                    Console.WriteLine("Please Insert a number bigger than 0.");
                }
                else
                {
                    Console.WriteLine("Please insert a valid number.");
                }
            }
            #endregion

            Console.WriteLine("\nPress any key to Calculate the AREA.");
            Console.ReadKey();

            Console.WriteLine("\nThe BASE is  :" + TriangleBase + "cm");
            Console.WriteLine("The HEIGHT is:" + TriangleHeight + "cm");

            TriangleArea = 0.5 * (TriangleBase * TriangleHeight);

            Console.WriteLine("\nThe AREA is  :" + TriangleArea + "cm");

            Console.ReadKey();
        }
    }
}
