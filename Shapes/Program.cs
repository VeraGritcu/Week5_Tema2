using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            var triangle = new Triangle(5, 6);
            var rectangle = new Rectangle(7, 5);
            var square = new Square(6);
            List<Shape> shapes = new List<Shape>();
            shapes.Add(triangle);
            shapes.Add(rectangle);
            shapes.Add(square);

            foreach (var shape in shapes)
            {
                Console.WriteLine($"This {shape.GetType().Name}'s area is {shape.CalculateSurface()}");
            }
        }
    }
}
