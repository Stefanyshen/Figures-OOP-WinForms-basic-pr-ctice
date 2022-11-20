namespace FiguresWindow
{
    public class Triangle : Figure
    {
        public readonly string Name;
        public readonly Point Point1;
        public readonly Point Point2;
        public readonly Point Point3;

        public Triangle(string[] array)
        {
            Name = array[0];
            Point1 = new Point(double.Parse(array[1]), double.Parse(array[2]));
            Point2 = new Point(double.Parse(array[3]), double.Parse(array[4]));
            Point3 = new Point(double.Parse(array[5]), double.Parse(array[6]));
        }

        public override double Square()
        {
            var perimeter = Perimeter() / 2; 
            return Math.Sqrt(perimeter * (perimeter - Point1.Distance(Point2)) * (perimeter - Point2.Distance(Point3)) * (perimeter - Point3.Distance(Point1)));
        }

        public override double Perimeter() => 
            Point1.Distance(Point2) + Point2.Distance(Point3) + Point3.Distance(Point1);

        public override string ToString()
        {
            return $"{Name}: {{({Point1}),({Point2}),({Point3})}}";
        }
    }
}
