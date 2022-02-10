using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    internal class BasicCoreProgram
    {
        public void Factorization(int num)
        {
            Console.WriteLine("Enter the number");
            for (int i = 2; i <= num; i++)
            {
                if (num % i == 0)
                {
                    int isprime = 1;
                    for (int j = 2; j <= i / 2; j++)
                    {
                        if (i % j == 0)
                        {
                            isprime = 0;
                            break;
                        }
                    }
                    if (isprime == 1)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
    }
}