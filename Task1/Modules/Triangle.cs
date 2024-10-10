using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Animation;

namespace Task1.Modules
{
    public class Triangle: IFigure
    {
        double height;
        double basis;
        double side1;
        double side2;
        double side3;

        public Triangle(double height, double basis, double side1, double side2, double side3)
        {
            this.height = height;
            this.basis = basis;
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }

        double Basis { get {  return basis; } set { basis = value; } }
        double Height { get { return height; } set { height = value; } }
        double Side1 { get { return side1; } set { side1 = value; } }
        double Side2 { get { return side2; } set { side2 = value; } }
        double Side3 { get { return side3; } set { side3 = value; } }

        public double CalculateArea()
        {
            return (basis * height) / 2;
        }

        public double CalculatePerimeter()
        {
            return side1 + side2 + side3;
        }
    }
}
