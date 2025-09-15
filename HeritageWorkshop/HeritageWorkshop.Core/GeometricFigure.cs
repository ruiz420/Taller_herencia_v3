﻿namespace Geometry
{
    public abstract class GeometricFigure
    {
        public string Name { get; set; }

        protected GeometricFigure(string name)
        {
            Name = name;
        }

        public abstract double GetArea();
        public abstract double GetPerimeter();

        public override string ToString()
        {
            return $"{Name,-13} => Area.....: {GetArea():F5}   Perimeter: {GetPerimeter():F5}";
        }

    }
}

