using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    public abstract class Car
    {
        public string Model { get; set; }
        public double HorsePower { get; set; }
        public string Color { get; set; }

        public abstract Car Clone();

        protected Car(string model, double horsePower, string color)
        {
            Model = model;
            HorsePower = horsePower;
            Color = color;
        }
    }
}
