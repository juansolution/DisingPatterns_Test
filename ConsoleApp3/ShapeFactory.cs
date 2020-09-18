using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class ShapeFactory
    {

        public IShape GetShape(string shapetype)
        {

            switch (shapetype)
            {
                case "Circle":
                    return new Circle();
                case "Squeare":
                    return new Square();
                case "Rectangle":
                    return new Rectangle();
                default:
                    throw new NotImplementedException();

            }

        }

    }
}
