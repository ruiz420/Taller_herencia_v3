namespace Geometry
{
    public class Rectangle : Square
    {
        
        private double _b;
        public double B
        {
            get => _b;
            set
            {
                _b = value;
            }
        }

        public Rectangle(string name, double a, double b) : base(name, a)
        {

            B = b;
        }

        public override double GetArea()
        {
            return A * B;
        }

        public override double GetPerimeter()
        {
            return 2 * (A + B);
        }

        private bool ValidateB(double b)
        {
            return b > 0;
        }
    }
}
