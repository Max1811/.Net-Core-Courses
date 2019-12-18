using System;

namespace CalculateTriangles.TriangleElements
{
    public class Triangle : NumberOfSides, IShape
    {
        public string Name { get; }
        public double[] Sides { get; }
        public double Perimetr { get; }
        public double Square { get; }

        public Triangle(string name, params double[] integers)
        {
            Name = name;
            Sides = integers;
            NUMBER_OF_SIDES = 3;
            SetPerimetr();
            SetSquare();
        }

        private double _halfPerimetr { get; set; }
        public void SetPerimetr()
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

        public void SetSquare()
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
