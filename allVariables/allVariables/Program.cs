using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace allVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            // We will start with the Integral Types
            #region Integral Types

            sbyte   sByteVar    = 126;
            byte    ByteVar     = 255;

            short   ShortVar    = 32765;
            ushort  uShortvar   = 65534;
            
            int     IntVar      = 2147483646;
            uint    uIntVar     = 4294967294;

            long    LongVar     = 9223372036854775806;
            ulong   uLongVar    = 18446744073709551614;

            char    CharVar     = 'A';

            #endregion

            // Then we will show Floating Point Types
            #region Floating Point Types

            float   FloatVar    = 1.5f;

            double  DoubleVar   = 1.214213435634d;

            #endregion

            //Other Numeric Types
            #region Other Numeric Types

            decimal DecimalVar = 1.23444556m;

            #endregion

            //Other Simple Types (All The Above are Simple Types)
            #region Other Simple Types

            string StringVar = "This is a string";

            #endregion

            Console.Write(StringVar);
            Console.ReadKey();

        }
    }
}
