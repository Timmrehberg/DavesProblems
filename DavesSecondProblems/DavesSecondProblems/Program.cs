using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DavesSecondProblems
{
    class Program
    {
        static void Main(string[] args)
        {

             Triangle t1 = new Triangle();
             t1.regularTriangle();
             Console.ReadKey();
            Console.Clear();
            t1.backwardsTriangle();
            Console.ReadKey();
            Console.Clear();
            SecondTriangle s2 = new SecondTriangle();
            s2.makeRegTriangle(5);
             s2.printRegTriangle();

            Console.ReadLine();
            s2.makeUpsidedown(5);
             s2.printUpsidedownTriangle();
             Console.ReadLine();
            s2.makeBackwardsTriangle(5);
            s2.printBackwardsTriangle();





        }

    }
}




  