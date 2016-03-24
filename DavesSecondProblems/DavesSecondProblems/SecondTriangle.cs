using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DavesSecondProblems
{
   public class SecondTriangle
    {
        List<List<string>> makeRegularTriangle = new List<List<string>>();
        List<List<string>> makeUpsidedownTriangle = new List<List<string>>();
        List<List<string>> makeBackwardsTriangl = new List<List<string>>();
        public string innerContent = ".";

            public int makeRegTriangle(int rotations)

            {
                for (int outterIndex = 0; outterIndex < rotations; outterIndex++)
                {
                    makeRegularTriangle.Add(new List<string>());

                    for (int inIndex = 0; inIndex < outterIndex + 1; inIndex++)
                    {
                        makeRegularTriangle[outterIndex].Add(innerContent);

                    }
                }
                return rotations;

            }
            public bool printRegTriangle()
            {
                foreach (List<string> rotations in makeRegularTriangle)
                {

                    foreach (string innerstuff in rotations)
                    {

                        Console.Write(innerstuff);


                    }
                    Console.WriteLine();
                }

                return true;
            }
        
    

         
           public int makeUpsidedown(int rotations)
            {
               
                for(int outerindex = 0; outerindex < rotations; outerindex++)
                {
                   makeUpsidedownTriangle.Add(new List<string>());
                   for (int innerindex = rotations-1; innerindex > outerindex-1; innerindex--)
                   {
                    makeUpsidedownTriangle[outerindex].Add(innerContent);

                   }
                    
               }
               return rotations;
           }
           public bool printUpsidedownTriangle()
            {
               foreach(List<string> rotations in makeUpsidedownTriangle)
              {
                   foreach(string inner in rotations)
                    {
                       Console.Write(inner);

                        
                  }
                   Console.WriteLine();
             }
                return true;

            }
        public int makeBackwardsTriangle(int rotations)
        {
            for(int outerindex = 0; outerindex < rotations; outerindex++)
            {
                makeBackwardsTriangl.Add(new List<string>());
                for (int innerindex = rotations - 1; innerindex > outerindex - 1; innerindex--)
                {
                    makeBackwardsTriangl[outerindex].Add(" ");
                   
                }
                for(int inindex = 0; inindex < outerindex + 1; inindex++)
                {
                    makeBackwardsTriangl[outerindex].Add(innerContent);
                }
                
            }
            return rotations;
        }
        public bool printBackwardsTriangle()
        {
            foreach(List<string> rotate in makeBackwardsTriangl)
            {
                foreach(string inside in rotate)
                {
                    Console.Write(inside);
                }
                Console.WriteLine();
            }
            return true;
        }

       }
   }


