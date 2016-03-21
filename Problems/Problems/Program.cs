using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    class Program
    {
        static void Main(string[] args)
        {
            Lists l1 = new Lists();
            Prob2 p2 = new Prob2();
            Probthree p3 = new Probthree();
            Prob4 p4 = new Prob4();
            int checkit = l1.checklength();
           Console.WriteLine(checkit);


            string pie= p2.PiValue();
             Console.WriteLine(pie);
             p3.BMO();
            p4.Checknumbers();
            Prob5 p5 = new Prob5();
            p5.Dance();



           
        }
    }
}
