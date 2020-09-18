using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new Subject();
            new HexaObserver(subject);
            new OctalObserver(subject);
            new BinaryObserver(subject);

            Console.WriteLine("Primer estado cambia por: 15");
            subject.setState(15);
            Console.WriteLine("Primer estado cambia por: 10");
            subject.setState(10);
        }
    }
}
