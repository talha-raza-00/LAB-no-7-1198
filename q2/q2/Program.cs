using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.disp();
            Person p2 = new Person("talha",18,"FSD");
            p2.disp();
            Person p3 = new Person(p1);
            p3.disp();

            p2.change();
            p2.disp();

        }
    }
}
