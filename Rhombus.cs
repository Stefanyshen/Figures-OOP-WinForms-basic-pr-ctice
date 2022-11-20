namespace FiguresWindow
{
    public class Rhombus : Quadrangle
    {
        public Rhombus(string[] array) : base(array)
        {

        }

        public override double Square() => (Point1.Distance(Point3) * Point2.Distance(Point4)) / 2;
    }
}
