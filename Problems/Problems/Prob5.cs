using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    class Prob5
    {
        public void armup() {

            Console.WriteLine(@"
                      *  * 
                    *      * 
                      *  *        * 
                        *      * 
                    *  *  * 
                  *    *     
                *      *       
                        * 
                    *      * 
                  *          * 
                *              * 
              *                  * 
            *                      * ");


}
        public void armdown()
        {
            Console.WriteLine(@"
                      *  * 
                    *      * 
                      *  *        
                        *      
                    *  *  * 
                  *    *     *
                *      *       *
                        * 
                    *      * 
                  *          * 
                *              * 
              *                  * 
            *                      * ");
        }
        public void Dance() {
            for (int i = 0; i < 5; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Clear();
                    armdown();
                    Console.ReadKey();
                }else
                {
                    
                    Console.Clear();
                    armup();
                    Console.ReadKey();
                }


            }




}



    }
}
