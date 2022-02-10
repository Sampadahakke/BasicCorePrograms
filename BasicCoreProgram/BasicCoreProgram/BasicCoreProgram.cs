using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    internal class BasicCoreProgram
    {
         public void  LargestNum()
         {
            int Num1, Num2, Num3;
            Console.Write("Enter First Number: ");
            Num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second Number: ");
            Num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Third Number: ");
            Num3 = Convert.ToInt32(Console.ReadLine());
            if (Num1 > Num2 && Num1 > Num3)
            {
                Console.WriteLine(Num1 + " is the largest");
            }
            else if (Num2 > Num3)
            {
                Console.WriteLine(Num2 + " is the largest");
            }
            else
            {
                Console.WriteLine(Num3 + " is the largest");
            }

         }
    }
}