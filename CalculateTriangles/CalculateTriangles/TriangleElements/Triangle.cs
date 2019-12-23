using System;

namespace CalculateTriangles.TriangleElements
{
    public class Triangle : NumberOfSides, IShape
    {
        public string Name { get; }
        public double[] Sides { get; }
        public double Perimetr { get; }
        public double Square { get; }

        public Triangle(string name, int sides = 3, params double[] integers)
            :base(sides)
        {
            Name = name;
            Sides = integers;
            SetPerimetr();
            Square = SetSquare();
        }

        private double _halfPerimetr { get; set; }
        public void SetPerimetr()
        {
            if (Sides.Length == NUMBER_OF_SIDES)
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

        public double SetSquare()
        {
            if (Sides.Length == NUMBER_OF_SIDES)
            {
                double _firstSide = Sides[0];
                double _secondSide = Sides[1];
                double _thirdSide = Sides[2];

                return Math.Sqrt(_halfPerimetr * (_halfPerimetr - _firstSide) * (_halfPerimetr - _secondSide) * (_halfPerimetr - _thirdSide));
            }
            else throw new InvalidOperationException("Invalid number of sides");
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
