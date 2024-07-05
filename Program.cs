using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IShape circle = new Circle(5);
            Console.WriteLine("Area of circle is " + circle.calculateArea());

            Circle circle2 = new Circle(15);
            Console.WriteLine("circumference of circle is "+ circle2.calculateCircumference());

            IShape triangle = new Triangle(5, 10);
            Console.WriteLine("Area of triangle is " + triangle.calculateArea());

            triangle = new Triangle(5, 10);
            Console.WriteLine("Area of triangle is " + triangle.calculateArea());
        }
    }
}
