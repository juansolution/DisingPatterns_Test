using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Pepsi : ColdDrink
    {
        public override string nombre()
        {
            return "Pepsi";
        }

        public override float valor()
        {
            return 35.5f;
        }
    }
}
