using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Attempt4
    {
        int Previous = 0 ;
        int Number;
        public Attempt4(int Next) 
        {

       Console.WriteLine("Enter numbers to display");
            Number = Convert.ToInt32(Console.ReadLine());
            for (int i=0; i < Number; i++)
            {
                int total = Next + Previous;
                Previous = Next;
                Next = total;
                Console.WriteLine(Next);
            }
        }
         
    }
}
