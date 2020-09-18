using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Rectangle : IShape
    {
        public void draw()
        {
            Console.WriteLine("Se pinta un rectangulo.");
        }
    }
}
