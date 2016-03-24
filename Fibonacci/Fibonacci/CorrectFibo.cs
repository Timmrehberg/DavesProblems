using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class CorrectFibo
    {
        public int CorrectFibonacci(int numberoftimes)
        {
            int a = 0;
            int b = 1;
            for(int i = 0; i < numberoftimes; i++)
            {
                int num01 = a;
                a = b;
                b = num01 + b;
            }
            return a;
                

            }
        }




    }

