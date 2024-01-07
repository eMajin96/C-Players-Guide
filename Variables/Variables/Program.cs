using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            int P1Score = 1, P2Score = 2;
            
            P2Score = P1Score;
            P1Score = 3;

            //We need to see the Score
            Console.WriteLine("P1Score: " + P1Score);
            Console.WriteLine("P2Score: " + P2Score);
            Console.ReadKey();
        }
    }
}
