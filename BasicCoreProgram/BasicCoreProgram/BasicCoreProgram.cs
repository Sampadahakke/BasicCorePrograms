using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    internal class BasicCoreProgram
    {
        public int reminder1 = 0;
        public int reminder2 = 0;
        public void CheckLeapYear()
        {
            Console.Write("Please Enter The Four Digit Number =");
            int Year = Convert.ToInt32(Console.ReadLine());
            reminder1 = Year % 4;
            reminder2 = Year % 400;
            if (reminder1 == 0)
            {
                Console.WriteLine("This is leap year");
            }
            else if (reminder2 == 0)
            {
                Console.WriteLine("This is leap year");
            }
            else
            {
                Console.WriteLine("This is not a leap year");
            }
        }
    }
}