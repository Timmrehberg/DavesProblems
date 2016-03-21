using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    class Lists
    {
      
     public int checklength()
        {
            List<int> Stringlist = new List<int>();
            Stringlist.Add(5);
            Stringlist.Add(2);
            Stringlist.Add(3);
            Stringlist.Add(4);
            Stringlist.Add(4);
            return Stringlist.Count();
        }
       
       
    }
}
