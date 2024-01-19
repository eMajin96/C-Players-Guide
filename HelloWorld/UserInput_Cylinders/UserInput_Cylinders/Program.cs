using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInput_Cylinders
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *  A cylinder is usually defined by a height (h) and radius of the base (r). 
             *  Create a program that allows the user to type in these two values. 
             *  We’ll do some math with those values to figure out the volume of that cylinder, as well as the surface area. 
             *  The program will then output the results to the user.
             *  
                The formula for the volume of a cylinder is this:
                𝑉 = 𝜋*𝑟^2*ℎ

                The formula for the surface area of a cylinder is this:
                𝑆𝐴 = 2𝜋𝑟(𝑟 + ℎ)

                In both of these equations, r is the radius of the cylinder, h is the height of the cylinder, and of
                course, π≈ 3.1415926.
            */

            #region Introduction
            Console.WriteLine("Hello André! We are going to calculate a cylinders volume and base area based on two values given by you.");
            #endregion

            #region Variables

            double? height = null, baseRadius = null, volume, baseArea;
            double pi = 3.1415926, baseRadiusAux = 0, heightAux = 0;

            #endregion

            #region baseRadius
            while (baseRadius is null || baseRadiusAux == 0)
            {
                Console.WriteLine("\nPlease insert the value of the base radius in cm.");
                bool radiusIsNumber = double.TryParse(Console.ReadLine(), out baseRadiusAux);

                if (radiusIsNumber == true && baseRadiusAux != 0)
                {
                    baseRadius = baseRadiusAux;
                    Console.WriteLine($"The base radius of the cylinder is: {baseRadiusAux} cm");
                }
                else if (radiusIsNumber == true && baseRadiusAux == 0)
                {
                    Console.WriteLine("Please insert a number different from 0");
                }
                else
                {
                    Console.WriteLine("Please insert a number.");
                }
            }
            #endregion

            #region height
            while (height is null || height == 0)
            {
                Console.WriteLine("\nPlease insert the value of the height in cm.");
                bool heightIsNumber = double.TryParse(Console.ReadLine(), out heightAux);

                if (heightIsNumber == true && heightAux != 0)
                {
                    height = heightAux;
                    Console.WriteLine($"The base radius of the cylinder is: {heightAux} cm");
                }
                else if (heightIsNumber == true && heightAux == 0)
                {
                    Console.WriteLine("Please insert a number different from 0");
                }
                else
                {
                    Console.WriteLine("Please insert a number.");
                }
            }
            #endregion

            #region Results

            volume = pi * Math.Pow(baseRadiusAux, 2) * heightAux;

            Console.WriteLine($"\nThe volume of the Cylinder is: {volume} cm^3");

            baseArea = 2 * pi * baseRadiusAux * (baseRadiusAux + heightAux);

            Console.WriteLine($"The base area of the Cylinder is: {baseArea} cm^2");

            #endregion

            Console.ReadKey();
        }
    }
}
