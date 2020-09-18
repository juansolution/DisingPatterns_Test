using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class RoundedShapeFactory : AbstractFactory
    {
        public override IShape getShape(string shapetype)
        {
            switch (shapetype)
            {
                case "Rectangle":
                    return new RoundedRectangle();
                case "Square":
                    return new RoundedSqueare();
                default:
                    throw new NotImplementedException(); 
            }
        }
    }
}
