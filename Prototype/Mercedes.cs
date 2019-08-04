using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    public class Mercedes : Car
    {
        public Mercedes(string model, double horsePower, string color) : base(model, horsePower, color)
        {
        }

        public override Car Clone()
        {
            return MemberwiseClone() as Car;
        }
    }
}
