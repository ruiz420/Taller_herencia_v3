namespace Geometry
{
    public class Square : GeometricFigure
    {
        private double _a;

        public double A
        {
            get => _a;
            set
            {
                _a = value;
            } 
        }
        public Square(string name, double a) : base(name) 
        {
            Name = name;
            A = a;
        }

        public override double GetArea()
        {
            return A * A;
        }

        public override double GetPerimeter()
        {
            return 4 * A;
        }

        private bool ValidateA(double a)
        {
            return a > 0;
        }
    }
}
