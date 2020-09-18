using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class VegBurger : Burger
    {
        public override string nombre()
        {
            return "Veg Burger";
        }

        public override float valor()
        {
            return 25.0f;
        }
    }
}
