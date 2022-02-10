using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    internal class BasicCoreProgram
    {
        public void EvenOdd()
        {
            Console.WriteLine("Enter the positive integer number");
            int Number = Convert.ToInt32(Console.ReadLine());
            int reminder = Number % 2;
            if (reminder == 0)
            {
                Console.WriteLine("The Number Is Even");
            }
            else
            {
                Console.WriteLine("The Number Is Odd");
            }

        }
    }
}