using System;
using System.Collections.Generic;
using System.Text;

namespace carobjects
{
    public class Car
    {

        // Private variables/fields
        private string _originalColor;

        // Properties
        public string Color { get; set; }
        public string Brand { get; }
        public string Model { get; }
        public double Speed { get; set; }

        private double _speed;

        public bool SetSpeed(double value)
        {
            if (value > 0)
            {
                _speed = value;
                return true;
            }
            return false;
        }

        // Constructor
        public Car(string color, string brand, string model)
        {
            Color = color;
            Brand = brand;
            Model = model;
            Speed = 0;
            _originalColor = color;
        }

        // Functions
        public void Accelerate()
        {
            Speed = Speed + 10;
        }

        public void Accelerate(double value)
        {
            Speed = Speed + value;
        }

        // Overriding default ToString
        public override string ToString()
        {
            return $"Brand: {Brand}, Model: {Model}, Color: {Color}, Speed: {Speed}";
        }
    }
}

