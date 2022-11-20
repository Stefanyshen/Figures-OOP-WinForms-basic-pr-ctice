namespace FiguresWindow
{
    public class Circle : Figure
    {
        public readonly string Name;
        public readonly Point Center;
        public readonly double Radius;

        public Circle(string[] args)
        {
            Name = args[0];
            Center = new Point(double.Parse(args[1]), double.Parse(args[2]));
            Radius = double.Parse(args[3]);
        }

        public override double Square() => Math.PI*Radius*Radius;

        public override double Perimeter() => 2*Math.PI*Radius;

        public override string ToString()
        {
            return $"{Name}: {{({Center}), r = {Radius}}}";
        }
    }
}
