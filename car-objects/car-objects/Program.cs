using System;

namespace car_objects
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Car car = new Car("blue", "Volvo", "V60");
            Console.WriteLine("Car color: " + car.Getcolor());
            Console.ReadLine();
        }
    }
}
