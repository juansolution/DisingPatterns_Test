using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class HexaObserver : Observer
    {
        public HexaObserver(Subject subject )
        {
            this.subject = subject;
            this.subject.attach(this);
        }

        public override void update()
        {
            Console.WriteLine("Hexa String:" + Convert.ToString(subject.getState()));
        }
    }
}
