using System;
namespace Shape_Weiwei
{
    class Square : IShape
    {
        decimal length = 10;

        public decimal CalculateArea()
        {
            return length * length;
        }

        public string Display()
        {
            return $"The area of circle with length {length} is " + length * length;
        }
    }
}
