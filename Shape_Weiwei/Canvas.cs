using System;
namespace Shape_Weiwei
{
    class Canvas
    {
        //public decimal ResultArea { get; set; }
        //public string ResultDisplay { get; set; }

        //public void CalculateArea(IShape shape)
        //{
        //    ResultArea = shape.CalculateArea();
        //}

        //public void Display(IShape shape)
        //{
        //    ResultDisplay = shape.Display();
        //}


        public decimal Raduis { get; set; }
        public decimal Length { get; set; }
        public decimal Result { get; set; }

        public decimal ResultArea { get; set; }
        public string ResultDisplay { get; set; }

        public void CalculateArea(IShape shape)
        {
            ResultArea = shape.CalculateArea();
        }

        public void Display(IShape shape)
        {
            ResultDisplay = shape.Display();
        }
    }
}
