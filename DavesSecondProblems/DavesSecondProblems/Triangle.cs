using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DavesSecondProblems
{
    class Triangle
    {
       //ist<List<string>> triangles = new List<List<string>>();
        public void regularTriangle()
        {
            int number = 5;

            for (int i = 1; i <= number; i++)
            {
                for (int Inner = 0 ; Inner <= number-i; Inner++)
                    Console.Write(" ");
                for (int Outer = 5; Outer <= i; Outer++)
                    Console.Write(" .");
                Console.WriteLine(" ");


            }


        }
        public void backwardsTriangle()
        {
            int number = 4;
            for (int i = 1; i <= number; i++)
            {
                for (int Inner = 1; Inner <= number + i; Inner++)
                    Console.Write(" ");
                for (int Outer = 1; Outer <= i; Outer++)
                    Console.Write(" .");
                Console.WriteLine(" ");
            }
        }
        
       

        }



    }


