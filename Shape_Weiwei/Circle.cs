using System;

namespace Shape_Weiwei
{
    internal class Circle : IShape
    {
        decimal radius;

        public decimal CalculateArea()
        {
            return (decimal)3.14 * radius * radius;
        }

        public string Display()
        {
            return $"The area of circle with radius {radius} is " + (decimal)3.14 * radius * radius;
        }
    }
}
