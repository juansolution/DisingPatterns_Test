using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class Coke : ColdDrink
    {
        public override string nombre()
        {
            return "Coke";
        }

        public override float valor()
        {
            return 30.0f;
        }
    }
}
