using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator
{
    public class Circle : IShape, IRoundShape
    {
        private double _radius = 0;
        private Circle() { }

        public Circle(double x)
        {
            _radius = x;
        }
        public double calculateArea()
        {
            return Math.PI * _radius * _radius;
        }

        public double calculateCircumference()
        {
            return 2 * Math.PI * _radius;
        }
    }
}
