using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class ShapeFactory : AbstractFactory
    {
        public override IShape getShape(string shapetype)
        {
            switch (shapetype)
            {
                case "Rectangle":
                    return new Rectangle();
                case "Square":
                    return new Square();
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
