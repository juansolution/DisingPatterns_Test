using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractFactory factoryProducer;
            IShape shape;

            /*Pinta Objetos simples.*/
            factoryProducer = FactoryProducer.getFactory(false);

            shape = factoryProducer.getShape("Rectangle");
            shape.draw();

            shape = factoryProducer.getShape("Square");
            shape.draw();

            /*Pinta Objetos avanzados.*/
            factoryProducer = FactoryProducer.getFactory(true);

            shape = factoryProducer.getShape("Rectangle");
            shape.draw();

            shape = factoryProducer.getShape("Square");
            shape.draw();

        }
    }
}
