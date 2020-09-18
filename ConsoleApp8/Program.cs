using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape redCircle = new Circle(new RedCircle(),100,100,10);
            Shape greenCircle = new Circle(new GreenCircle(), 100, 100, 10);

            redCircle.draw();
            greenCircle.draw();

        }
    }
}
