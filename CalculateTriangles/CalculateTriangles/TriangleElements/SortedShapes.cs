using System.Collections.Generic;

namespace CalculateTriangles.TriangleElements
{
    public class SortedShapes<T> where T: IShape
    {
        public List<T> Figures { get; set; }

        public SortedShapes()
        {
            Figures = new List<T>();
        }

        public void Add(T figure)
        {
            if (figure != null)
            {
                Figures.Add(figure);
            }
        }

        public void SortFiguresList()
        {
            Figures.Sort();
        }

    }
}
