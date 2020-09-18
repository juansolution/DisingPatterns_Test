using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxi.Console
{
    class RealSubject : ISubject
    {
        public void Request()
        {
            System.Console.WriteLine("RealSubject: Handling Request.");
        }
    }
}
