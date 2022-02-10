using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    internal class BasicCoreProgram
    {
        public void HarmonicNumber()
        {
            Console.Write("Enter the number = ");
            int Number = Convert.ToInt32(Console.ReadLine());
            double HarmonicNum = 0.0;
            for (int i = 1; i <= Number; i++)
            {
                HarmonicNum += (double) 1 / i;
            }
            Console.WriteLine(Number + "th harmonic number = "+ HarmonicNum);

        }
    }
}