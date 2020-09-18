using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class ChickenBurger : Burger
    {
        public override string nombre()
        {
            return "Chicken Burger";
        }

        public override float valor()
        {
            return 50.5f;
        }
    }
}
