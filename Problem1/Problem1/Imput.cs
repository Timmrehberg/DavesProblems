using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    class Imput
    {
        List<string> Useranswers = new List<string>();
        public void Userimput()
        {
            while (true)
            {
                {
                    Console.WriteLine("Enter a word");

                    string reply = Console.ReadLine();

                    
                    {
                        if (Useranswers.Contains(reply))
                        {
                            Console.WriteLine("You already entered that word dumbass Bark Bark!");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Good Job enter another unique word");
                            Useranswers.Add(reply);
                        } 
                    }

                }

            }

        }


    }
}
        
