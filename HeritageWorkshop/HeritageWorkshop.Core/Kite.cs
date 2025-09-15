

namespace Geometry
{
    public class Kite : Rhombus
    {
   
        private double _b;   

        public double B
        {
            get => _b;
            set
            {
                if (!ValidateB(value))
                    throw new ArgumentException("La diagonal B debe ser mayor que 0");
                _b = value;
            }
        }

      
        public Kite(string name, double a, double d1, double d2, double b)
            : base(name, a, d1, d2)
        {
            B = b;
        }

        public override double GetArea() // -- Methods ---
        {
            return (D1 * D2) / 2;
        }

        public override double GetPerimeter()
        {
            return 2 * (A+B);
        }

        private bool ValidateB(double b)
        {
            return b > 0;
        }
    }
}
