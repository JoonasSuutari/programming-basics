using System;
using System.Collections.Generic;
using System.Text;

namespace car_1
{
    class Car_3
    {
        public string Brand { get; }
        public double Speed { get; set; }

        public Car_3(string brand, double speed)
        {
            Brand = brand;
            Speed = speed;
        }

        public void Accelerate()
        {
            Speed = Speed + 10;
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
