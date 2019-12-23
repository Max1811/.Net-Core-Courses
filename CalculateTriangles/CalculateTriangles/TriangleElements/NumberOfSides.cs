using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateTriangles.TriangleElements
{
    public abstract class NumberOfSides
    {
        protected readonly int NUMBER_OF_SIDES;

        public NumberOfSides(int sides)
        {
            NUMBER_OF_SIDES = sides;
        }
    }
}
