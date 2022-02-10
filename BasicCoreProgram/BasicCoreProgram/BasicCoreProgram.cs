using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    internal class BasicCoreProgram
    {
        public void QuotientAndRemainder()
        {

            int quotient = 0;
            int remainder = 0;
            int dividend = 0;
            int divisor = 0;
            Console.WriteLine("Enter Dividend: ");
            dividend = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Divisor: ");
            divisor = Convert.ToInt32(Console.ReadLine());
            quotient = dividend / divisor;
            remainder = dividend % divisor;
            Console.WriteLine("Quotient: " + quotient + " Remainder: " + remainder);
        }   
    }
}