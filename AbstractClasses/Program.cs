using System;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            Console.WriteLine("Hello World!");
        }
    }


    public abstract class Vehicle 
    {
        public string VIN { get; set; }

        public string Manufacturer { get; set; }

        public int YearOfManufacture { get; set; }

    }

    public class Car : Vehicle
    {
        public int NumberOfWheels { get; set; }
    }
}
