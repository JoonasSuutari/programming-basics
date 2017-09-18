using System;

namespace carobjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("blue", "Volvo", "V60");
            Console.WriteLine(car);
            car.Color = "White";
            car.Accelerate(10);
            Console.WriteLine(car);

            Console.ReadLine();
        }
    }
}
