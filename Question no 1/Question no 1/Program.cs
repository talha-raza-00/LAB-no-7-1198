using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_no_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("BMW","ultra",2012,190);
            car1.disp();
            Car car2 = new Car();
            car2.disp();
            Car car3 = new Car(car1);
            car3.disp();
            car1.ACsped();
            car1.disp();



        }
    }
}
