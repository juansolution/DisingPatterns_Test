using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public abstract class ColdDrink : IItem
    {
        public abstract string nombre();
        public IPacking packing() {
            return new Bottle();
        }
        public abstract float valor();
    }
}
