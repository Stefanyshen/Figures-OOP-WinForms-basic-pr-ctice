namespace FiguresWindow
{
    public static class Program
    {
        public readonly static Dictionary<string, Func<string[], Figure>> Dict = new Dictionary<string, Func<string[], Figure>>
            {
                { "triangle", (arguments) => new Triangle(arguments) },
                { "circle", (arguments) => new Circle(arguments) },
                { "ellipse", (arguments) => new Ellipse(arguments) },
                { "rectangle", (arguments) => new Rectangle(arguments) },
                { "isosceles-triangle", (arguments) => new IsoscelesTriangle(arguments) },
                { "square", (arguments) => new Square(arguments) },
                { "rhombus", (arguments) => new Rhombus(arguments) }
            };
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}