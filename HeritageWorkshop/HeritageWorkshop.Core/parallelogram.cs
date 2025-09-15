namespace Geometry
{
    public class Parallelogram : Rectangle
    {
        private double _h;

        public double H
        {   
            get  => _h;
            set 
            { 
                _h = value; 
            }
        }

        public Parallelogram(string name, double a, double b, double h)
            : base(name, a, b)
        {
            H = h;
        }

        public override double GetArea()
        {
            return B * H;
        }

        public override double GetPerimeter()
        {
            return 2 * (A + B);
        }

        private bool ValidateH(double h)
        {
            return h > 0;
        }
    }
}
