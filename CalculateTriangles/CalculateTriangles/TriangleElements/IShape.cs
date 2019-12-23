using System;

namespace CalculateTriangles.TriangleElements
{
    interface IShape: IComparable<IShape>
    {
        string Name { get; }
        double[] Sides { get; }
        double Perimetr { get; }
        double Square { get; }
        double SetSquare();
    }
}
