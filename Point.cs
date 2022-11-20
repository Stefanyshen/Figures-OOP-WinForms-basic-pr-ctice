namespace FiguresWindow
{
    public struct Point
    {
        public double X { get; }
        public double Y { get; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public Point()
        {
            X = 0;
            Y = 0;
        }

        public double Distance(Point point) => Math.Sqrt((point.X - X) * (point.X - X) + (point.Y -Y) * (point.Y - Y));

        public override string ToString()
        {
            return $"{X};{Y}";
        }
    }
}
