using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tekning
{
    internal class Fyrkant : Tekning
    {
        public double Circumference { get; set; }
        public double Area { get; set; }
        public double Volume { get; set; }
        public Fyrkant(double baseLength = 8, double heightLength = 8)
        {
            Area = GetArea(baseLength, heightLength);
            Console.WriteLine("Area Square: " + Area);
        }
        public Fyrkant(string sayHey)
        {
            Console.WriteLine("Square says hey!");
        }
        public override double GetArea(double baseLength, double heightLength)
        {
            Area = baseLength * heightLength;
            return Area;
        }
        public override double GetCircumference(double side1, double side2 = 0)
        {
            Circumference = side1 * 4;
            return Circumference;
        }
        public override string ToString()
        {
            return "Square";
        }
    }
}
