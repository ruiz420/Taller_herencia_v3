namespace Geometry
{
    public class Trapeze : Triangle
    {
        private double _d;

        public double D
        {
            get => _d;
            set
            {
                _d = value;
            }

        }

       

        public Trapeze(string name, double a, double b, double c, double h, double d)
            : base(name, a, b, c, h)
        {
            D = d;
        }

        public override double GetArea()
        {
            return ((B + C) * H) / 2;
        }

        public override double GetPerimeter()
        {
            return A + B + C + D;
        }

        private bool ValidateD(double d)
        {
            return d > 0;
        }
    }
}
