using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateTriangles.TriangleElements
{
    public interface IFigure
    {
        string Name { get; set; }
        int NumberOfSides { get; set; }
        double[] Sides { get; set; }
        double Perimetr { get; set; }
        double Square { get; set; }

        void CountSquare();
    }
}
