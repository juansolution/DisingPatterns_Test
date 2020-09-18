using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {

            ShapeFactory shapeFactory = new ShapeFactory();
            IShape shape;

            shape = shapeFactory.GetShape("Circle");
            shape.draw();
            
            shape = shapeFactory.GetShape("Rectangle");
            shape.draw();
            
            shape = shapeFactory.GetShape("Squeare");
            shape.draw();

        }
    }
}
