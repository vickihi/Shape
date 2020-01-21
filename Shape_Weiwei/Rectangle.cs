using System;
namespace Shape_Weiwei
{
    internal class Rectangle : IShape
    {
        decimal length = 5;
        decimal width = 6;

        public decimal CalculateArea()
        {
            return length * width;
        }

        public string Display()
        {
            return $"The area of circle with length {length} and width {width} is {length * width}";
        }
    }
}
