using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    internal class BasicCoreProgram
    {
        public void SwapingOfNumbers()
        {
            int a, b;
            Console.WriteLine("Enter the value of a");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the value of b");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Before swap a= " + a + " b= " + b);
            a = a * b;
            b = a / b;
            a = a / b;
            Console.Write("After swap a= " + a + " b= " + b);
        }
    }
}