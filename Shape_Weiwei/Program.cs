using System;

namespace Shape_Weiwei
{
    class Program
    {
        static void Main(string[] args)
        {
            bool yesToContinue = true;
            GUI display = new GUI();

            Canvas canvas = new Canvas();


            while (yesToContinue)
            {
                Console.Clear();
                
                IShape shape = display.GetShape();
                canvas.CalculateArea(shape);
                canvas.Display(shape);

                Console.WriteLine($"Result {canvas.ResultArea}");
                Console.WriteLine($"Result {canvas.ResultDisplay}");

                Console.Write("Continue: (Y/N)? ");
                var contKey = Console.ReadKey();
                yesToContinue = (contKey.Key == ConsoleKey.Y ? true : false);

            }
            
        }
    }
}
