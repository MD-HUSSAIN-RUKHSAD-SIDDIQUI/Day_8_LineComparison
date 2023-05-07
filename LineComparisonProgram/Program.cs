using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my Program of Line Comparison Problem:");
           /*
            * Linelength linelength = new Linelength();
            linelength.Calculation();
           */

            /*
             * LineLengthEquality lineLengthEquality = new LineLengthEquality();
            lineLengthEquality.Check();
            */
            CompareLength compareLength = new CompareLength();
            compareLength.Check();
            
            Console.ReadKey();
        }
    }
}
