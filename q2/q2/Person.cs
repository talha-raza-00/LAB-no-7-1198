using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q2
{
    internal class Person
    {
        private string name {  get; set; }
        private int age { get; set; }
        private string adress { get; set; }

        public Person(string name,int age,string adr)
        {
            this.name = name;
            this.age = age;
            this.adress = adr;
        }

        public Person() : this("Unknown", 0, "Unknown")
        { }

        public Person(Person p1)
        {
            name = p1.name;
            age = p1.age;
            adress = p1.adress;
        }

        public void change()
        {
            Console.WriteLine($"\nThe adress before changing was {adress}");
            adress = "321 road dubai";
            Console.WriteLine($"After changing the adress is {adress}");

        }

        public void disp()
        {
            Console.WriteLine($"\nName = {name}");
            Console.WriteLine($"Age = {age}");
            Console.WriteLine($"adress = {adress}");
        }

    }
}
