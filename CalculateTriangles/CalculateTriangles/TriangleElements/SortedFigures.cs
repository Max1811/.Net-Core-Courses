using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateTriangles.TriangleElements
{
    public class SortedFigures<T>
    {
        public List<T> Figures { get; set; }

        public SortedFigures()
        {
            Figures = new List<T>();
        }

        public void Add(T figure)
        {
            if(figure != null)
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
