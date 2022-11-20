namespace FiguresWindow
{
    public class Ellipse : Figure
    {
        public readonly string Name;
        public readonly Point Center;
        public readonly double SmallRadius;
        public readonly double BigRadius;

        public Ellipse(string[] args)
        {
            Name = args[0];
            Center = new Point(double.Parse(args[1]), double.Parse(args[2]));
            SmallRadius = double.Parse(args[3]);
            BigRadius = double.Parse(args[4]);
        }

        public override double Square() => Math.PI * SmallRadius * BigRadius;

        public override double Perimeter() =>
            4 * ((Math.PI * SmallRadius * BigRadius + BigRadius - SmallRadius) / (BigRadius + SmallRadius));

        public override string ToString()
        {
            return $"{Name}: {{({Center}), r = {SmallRadius}, R = {BigRadius}}}";
        }
    }
}
