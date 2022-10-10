using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tekning
{
    internal abstract class Tekning
    {        
        public virtual double GetArea(double baseLength, double heightLength)
        {
            return baseLength * heightLength;
        }
        public virtual double GetCircumference(double side = 0, double length = 0)
        {
            return (side + length) * 2;
        }
        public double getVolume(double width, double length, double height)
        {
            return width * length * height;
        }
    }
}
