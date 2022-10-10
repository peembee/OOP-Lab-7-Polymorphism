using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Tekning
{
    internal class Rektangel : Tekning
    {
        public double Circumference { get; set; }
        public double Area { get; set; }
        public Rektangel(int baseLength = 6, int heightLength = 12)
        {
            Area = GetArea(baseLength, heightLength);
            Console.WriteLine("Area Rectangle: " + Area);
        }
        public Rektangel(string sayHey)
        {
            Console.WriteLine("Rectangle says hey!");
        }
        public override double GetArea(double baseLength, double heightLength)
        {
            Area = baseLength * heightLength;
            return Area;
        }
        public override double GetCircumference(double baseLength, double heightLength)
        {
            Circumference = (baseLength + heightLength) * 2;
            return Circumference;
        }
        public override string ToString()
        {
            return "Rectangle";
        }
    }
}
