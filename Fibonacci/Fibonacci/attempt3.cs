using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class attempt3
    {
        int i;
        int num01 = 0;
        int num02 = 0;
        int num03 = 0;
        public attempt3 (int numberoftimes)
        {
            Console.WriteLine("Enter times to loop");
            numberoftimes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num01);
            Console.WriteLine(num02);
            for(i = 0; i <= numberoftimes; i++)
            {
                num03 = num01 + num02;
                Console.WriteLine(num03);
                num01 = num02;
                num02 = num03;
            }
            Console.ReadLine();
        }

    }
}
