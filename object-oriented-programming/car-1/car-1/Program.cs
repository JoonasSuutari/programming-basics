using System;

namespace car_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car_1 car_1 = new Car_1("Volvo", 80);
            car_1.Accelerate();
            car_1.Accelerate();
            car_1.Decelerate();
            Console.WriteLine(car_1);

            Car_2 car_2 = new Car_2("Ford", 90);
            car_2.Accelerate();
            car_2.Accelerate();
            car_2.Decelerate();
            Console.WriteLine(car_2);

            Car_3 car_3 = new Car_3("Toyota", 100);
            car_3.Accelerate();
            car_3.Accelerate();
            car_3.Decelerate();
            Console.WriteLine(car_3);

            Console.ReadLine();
        }
    }
}
