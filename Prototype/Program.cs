using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Car bmwTemplateCar = new BMW("X5", 180, "White");
            Car greenX5 = bmwTemplateCar.Clone(); greenX5.Color = "green";

            Car mercedesTemplateCar = new Mercedes("C63", 180, "White");
            Car greenC63 = mercedesTemplateCar.Clone(); greenX5.Color = "green";
        }
    }
}
