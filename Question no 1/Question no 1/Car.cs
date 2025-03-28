using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_no_1
{
    internal class Car
    {
        // properties 
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Speed { get; set; }

        // Constructor (parameter)
        public Car(string make,string modle,int yewar,int speed)
        {
            this.Make = make;
            this.Model = modle;
            this.Year = yewar;
            this.Speed = speed;
        }

        // for default values 
        public Car() : this("Unknown", "Generic", 2025, 0)
        {
        }

        public void ACsped()
        {
            Console.WriteLine($"\nThe speed of car was {Speed}");
            Speed += 10;
            Console.WriteLine($"Now the Car speed is {Speed}");

        }

        // for copy
        public Car(Car c1)
        {
            Make = c1.Make;
            Model = c1.Model;
            Year = c1.Year;
            Speed = c1.Speed;
        } 

        public void disp()
        {
            Console.WriteLine($"\nMake = {Make}");
            Console.WriteLine($"MOdle = {Model}");
            Console.WriteLine($"Year = {Year}");
            Console.WriteLine($"Speed = {Speed}");

        }

    }
}
