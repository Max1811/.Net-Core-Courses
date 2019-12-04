using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateTriangles.TriangleElements
{
    public class Triangle: Trianglesizing
    {
        private string Name { get; set; }
        private double TriangleSquare { get; set; }

        public Triangle()
        {
            Name = "Undefined";
        }

        public Triangle(string name, double firstSide, double secondSide, double thirdSide)
            :base(firstSide, secondSide, thirdSide)
        {
            this.Name = name;
        }

        public double CalculateSquare()
        {
            double halfPerimetr = (FirstSide + SecondSide + ThirdSide) / 3;
            TriangleSquare = Math.Sqrt(halfPerimetr * (halfPerimetr - FirstSide)*(halfPerimetr - SecondSide)*(halfPerimetr - ThirdSide));
            return TriangleSquare;
        }

    }
}
