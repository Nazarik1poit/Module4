using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Modules
{
    public class Circle: IFigure
    {
        double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double Radius { get { return radius; } set { radius = value; } }

        public double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public double CalculatePerimeter()
        {
            return 2 * Math.PI * radius;
        }
    }
}
