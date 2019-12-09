using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculateTriangles.TriangleElements;
using FluentValidation;

namespace CalculateTriangles.Validation
{
    public class TrianglesValidator: AbstractValidator<Triangle>
    {
        public TrianglesValidator()
        {
            RuleFor(triangle => triangle.Name).NotEmpty();

            RuleFor(triangle => triangle.Sides[0])
                .LessThan(triangle => triangle.Sides[1] + triangle.Sides[2])
                .LessThan(triangle => double.MaxValue);

            RuleFor(triangle => triangle.Sides[1])
                .LessThan(triangle => triangle.Sides[0] + triangle.Sides[2])
                .LessThan(triangle => double.MaxValue);

            RuleFor(triangle => triangle.Sides[2])
                .LessThan(triangle => triangle.Sides[1] + triangle.Sides[0])
                .LessThan(triangle => double.MaxValue);
        }
    }
}
