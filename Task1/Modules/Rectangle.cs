using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Modules
{
    public class Rectangle: IFigure
    {
        double height;
        double width;

        public Rectangle(double height, double width)
        {
            this.height = height;
            this.width = width;
        }

        public double Width { get {  return width; } set { width = value; } }
        public double Height { get { return height; } set { height = value; } }

        public double CalculateArea()
        {
            return width * height;
        }

        public double CalculatePerimeter()
        {
            return (height + width) * 2;
        }

    }
}
