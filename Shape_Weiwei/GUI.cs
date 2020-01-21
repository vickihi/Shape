using System;
namespace Shape_Weiwei
{
    class GUI
    {
        public decimal GetCircleParamater(decimal radius)
        {
            Console.Write($"Enter radius: {radius} ");
            decimal enteredRadius = decimal.Parse(Console.ReadLine());
            return enteredRadius;
        }

        //public decimal GetRectangleParamater(decimal length, decimal width)
        //{
        //    Console.Write($"Enter length: {length} ");
        //    decimal enteredNumber = decimal.Parse(Console.ReadLine());
        //    return enteredNumber;
        //}


        public IShape GetShape()
        {
            IShape shape = new Circle();
            Console.Write("Shape:");
            var shapeKey = Console.ReadLine();
            switch (shapeKey)
            {
                case "circle":
                    shape = new Circle();
                    break;
                case "rectangle":
                    shape = new Rectangle();
                    break;
                case "square":
                    shape = new Square();
                    break;
            }
            return shape;
        }

    }
}
