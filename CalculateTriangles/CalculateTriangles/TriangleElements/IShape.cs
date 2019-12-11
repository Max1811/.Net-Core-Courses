using System;

namespace CalculateTriangles.TriangleElements
{
    public interface IShape: IComparable<IShape>
    {
        string Name { get; set; }
        int NumberOfSides { get; set; }
        double[] Sides { get; set; }
        double Perimetr { get; set; }
        double Square { get; set; }
        void CountSquare();
    }
}
