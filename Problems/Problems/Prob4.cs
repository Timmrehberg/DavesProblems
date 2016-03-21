using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    class Prob4
    {

        public List<int> Checknumbers()
        {
            List<int> ListA = new List<int>();
            ListA.Add(1);
            ListA.Add(2);
            ListA.Add(3);
            
            for (int i = 0; i < ListA.Count; i++)
            {
               

                ListA.Add(ListA[0]);
                ListA.RemoveAt(0);
                ListA.Insert(1, 2);
                ListA.RemoveAt(1);
                ListA.Insert(2, 1);
                ListA.RemoveAt(2);
               
                i += 5;
                

                foreach (int item in ListA)
                {
                    Console.WriteLine(item + 5 );
                    
                }
            }
           
            return ListA;
            

            


                }
        }
    }
