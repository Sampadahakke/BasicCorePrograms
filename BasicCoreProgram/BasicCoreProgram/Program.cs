using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("================Welcome to Basic Core Program====================");
            BasicCoreProgram program = new BasicCoreProgram();
            //program.PercentageCheck();
            //program.CheckLeapYear();
            //program.Powertwo();
            //program.HarmonicNumber();
            program.EvenOdd();
            Console.ReadLine();
        }
    }
}
