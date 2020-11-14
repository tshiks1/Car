using System;
using System.Collections.Generic;

namespace Car
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dot Notation.
            Car  honda = new Car();
            honda.Make = "Honda";
            honda.Year = 2012;
            honda.Model = "Accord";

            // Object initializer -Syntax Sugar.-Inline
            var mazda = new Car() { Make = "Mazda", Model = "Protege", Year = 2012 };


            //Extended syntax
            var nissan = new Car()
            {
                Make = "Nissan",
                Model = "Altima",
                Year = 2014
            };

            Car lexus = new Car()
            {
                Make = "Toyota",
                Model = "Corolla",
                Year = 2020
            };
            List<Car> cars = new List<Car>() { honda, lexus, mazda, nissan };
           
            foreach(var item in cars)
            { Console.WriteLine("-----");
                Console.WriteLine($"In my list of cars I have :{item.Make} {item.Model}which was made in {item.Year } .");
                
            }

           

        }
    }
}
