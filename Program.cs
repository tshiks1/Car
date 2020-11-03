using System;

namespace Car
{
    class Program
    {
        static void Main(string[] args)
        {
            var honda = new Car();
            honda.Make = "Honda";
            honda.Year = 2012;
            Console.WriteLine($"{honda.Make} is a good brand.\n  I have a {honda.Year } model.");

        }
    }
}
