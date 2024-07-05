using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator
{
    public class Triangle : IShape
    {
        double _baseLenght = 0;
        double _Height = 0;
        private Triangle() { }
        public Triangle(double baseLenght, double Height)
        {
            _baseLenght = baseLenght;
            _Height = Height;
        }
        public double calculateArea()
        {
            return 0.5 * _Height * _baseLenght;
        }
    }
}
