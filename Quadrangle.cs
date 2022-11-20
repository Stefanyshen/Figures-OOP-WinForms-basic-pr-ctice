using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresWindow
{
    public class Quadrangle : Figure
    {
        public readonly string Name;
        public readonly Point Point1;
        public readonly Point Point2;
        public readonly Point Point3;
        public readonly Point Point4;

        public Quadrangle(string[] array)
        {
            Name = array[0];
            Point1 = new Point(double.Parse(array[1]), double.Parse(array[2]));
            Point2 = new Point(double.Parse(array[3]), double.Parse(array[4]));
            Point3 = new Point(double.Parse(array[5]), double.Parse(array[6]));
            Point4 = new Point(double.Parse(array[7]), double.Parse(array[8]));
        }

        public override double Square() => Point1.Distance(Point2) * Point2.Distance(Point3);

        public override double Perimeter() => 
            2 * (Point1.Distance(Point2) + Point2.Distance(Point3));

        public override string ToString()
        {
            return $"{Name}: {{({Point1}),({Point2}),({Point3}),({Point4})}}";
        }
    }
}
