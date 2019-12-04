using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateTriangles.TriangleElements
{
    public class Trianglesizing
    {
        protected double FirstSide { get; set; }
        protected double SecondSide { get; set; }
        protected double ThirdSide { get; set; }

        public Trianglesizing()
        {
            FirstSide = 0;
            SecondSide = 0;
            ThirdSide = 0;
        }

        public Trianglesizing(double firstSide, double secondSide, double thirdSide)
        {
            FirstSide = firstSide;
            SecondSide = secondSide;
            ThirdSide = thirdSide;
        }
    }
}
