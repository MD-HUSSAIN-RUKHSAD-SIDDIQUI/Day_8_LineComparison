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

            Console.WriteLine("We are going to Calculate length of a line based on a point consisting of (x, y) co-ordinates using the Cartesian system");
             Linelength linelength = new Linelength();
             linelength.Calculation();
           

            Console.WriteLine("We are going to check Equality of two lines:");
            LineLengthEquality lineLengthEquality = new LineLengthEquality();
            lineLengthEquality.Check();
            
            Console.WriteLine("We are going two compare length of lines:");
            CompareLength compareLength = new CompareLength();
            compareLength.Check();
            
            Console.ReadKey();
        }
    }
}
