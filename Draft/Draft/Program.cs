using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draft
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalApples = 25;
            int people = 4;
            int remainingApples = totalApples % people; // this will be 1.

            Console.WriteLine(remainingApples);

            Console.ReadKey();
        }
    }
}
