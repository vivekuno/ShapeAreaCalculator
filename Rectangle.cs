using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator
{
    public class Rectangle : IShape
    {
        double _lenght = 0;
        double _width = 0;

        public Rectangle() { }
        public Rectangle(double length, double width)
        {
            _lenght = length;
            _width = width;
        }
        public double calculateArea()
        {
            return _lenght * _width;
        }
    }
}
