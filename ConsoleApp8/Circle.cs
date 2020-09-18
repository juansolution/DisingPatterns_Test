using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public class Circle : Shape
    {
        private int x;
        private int y;
        private int radius;

        public Circle(DrawAPI drawAPI, int x, int y, int radius) : base(drawAPI)
        {
            this.x = x;
            this.y = y;
            this.radius = radius;
            
        }

        public override  void draw()
        {
            drawAPI.drawCircle(radius, x, y);
        }
    }
}
