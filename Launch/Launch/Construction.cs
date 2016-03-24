using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Launch
{
    class Construction
    {
        public Construction(int number)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=hl_9_q_uLF8");
        }


           ~Construction()
        {
            Console.WriteLine("Goodbye");
            System.Diagnostics.Process.Start("https://youtu.be/JwXohnAYyuc?t=22s");
        }

    }
  






}

//Create a class called construction.Launch a new process of chrome.exe that will automatically open this youtube video when the constructor is called-> https://www.youtube.com/watch?v=hl_9_q_uLF8 
//open this youtube video when the destructor is called -> 
//https://youtu.be/JwXohnAYyuc?t=22s    