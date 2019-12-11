using System;

namespace CalculateTriangles.TriangleElements
{
    public class Triangle : IShape, IComparable<IShape>
    {
        public string Name { get; set; }
        public int NumberOfSides { get; set; } = 3;
        public double[] Sides { get; set; }
        public double Perimetr { get; set; }
        public double Square { get; set; }

        public Triangle(string name, params double[] integers)
        {
            Name = name;
            Sides = integers;
            CountPerimetr();
            CountSquare();
        }

        private double _halfPerimetr { get; set; }
        public void CountPerimetr()
        {
            if (Sides.Length == NumberOfSides)
            {
                double sum = 0;
                foreach (var item in Sides)
                {
                    sum += item;
                }
                this.Perimetr = sum;
                _halfPerimetr = Perimetr / 2;
            }
        }

        public void CountSquare()
        {
            if (Sides.Length == NumberOfSides)
            {
                double _firstSide = Sides[0];
                double _secondSide = Sides[1];
                double _thirdSide = Sides[2];

                Square = Math.Sqrt(_halfPerimetr * (_halfPerimetr - _firstSide) * (_halfPerimetr - _secondSide) * (_halfPerimetr - _thirdSide));
            }
        }

        public int CompareTo(IShape obj)
        {
            if (Square > obj.Square)
            {
                return -1;
            }
            else if (Square < obj.Square)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public override string ToString()
        {
            string triangleWriteline = $"Name: {Name}, Square: {Square}";
            return triangleWriteline;
        }
    }
}
