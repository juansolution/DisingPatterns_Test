using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public abstract class Burger : IItem
    {
        public abstract string nombre();

        public IPacking packing() {
            return new Wrapper();
        }

        public abstract float valor();
    }
}
