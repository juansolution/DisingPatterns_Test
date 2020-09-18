using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public abstract class Shape
    {
        protected DrawAPI drawAPI;

        public Shape(DrawAPI drawAPI)
        {
            this.drawAPI = drawAPI;

        }
        public abstract void draw();

    }
}
