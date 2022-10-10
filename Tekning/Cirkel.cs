using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tekning
{
    internal class Cirkel : Tekning
    {
        public double Radius {get; set;}
        public double Circumference { get; set; }
        public double Area { get; set; }
        public double Volume { get; set; }
        public Cirkel(int radius = 10)
        {
            Radius = radius;
            Area = GetArea(Radius,Radius);
            Console.WriteLine("Area Circle: " + Area);
        }
        public Cirkel(string sayHey)
        {
            Console.WriteLine("Circle says hey!");
        }
        public override double GetArea(double radius, double equalRadius)
        {
            Area = Math.PI * radius * radius;
            return Area;
        }
        public override double GetCircumference(double radius, double nullVariable = 0)
        {
            Circumference = 2 * Math.PI * radius;
            return Circumference;
        }
        public override string ToString()
        {
            return "Circle";
        }
    }
}
