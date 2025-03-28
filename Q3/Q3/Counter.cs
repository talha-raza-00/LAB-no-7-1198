using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    internal class Counter
    {

        private static int count;
         
        public void Increment() { count++; } 

        public Counter() { Increment(); }
        
        public  static int Getc()
        {
            return count;
        }
    }
}
