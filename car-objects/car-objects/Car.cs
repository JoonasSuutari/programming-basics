using System;
using System.Collections.Generic;
using System.Text;

namespace car-objects
{
    class Car
    {
        private string color;
        private string brand;
        private string model;
        
        // Constrictor
        public Car(string color, string brand, string model)
        {
            this.color = color;
            this.brand = brand;
            this.model = model;
        }

        public string GetColor()
        {
            return this.color;
        }
    }
}
