using System;
using System.Collections.Generic;
using System.Text;

namespace car_1
{
    class Car_1
    {
        public string Brand { get; }
        public double Speed { get; set; }

        public Car_1(string brand, double speed)
        {
            Brand = brand;
            Speed = speed;
        }

        public void Accelerate()
        {
            Speed = Speed * 1.1;
        }

        public void Decelerate()
        {
            Speed = Speed * 0.9;
        }

        public override string ToString()
        {
            return $"Brand: {Brand}, Speed: {Speed} km/h";
        }
    }
}
