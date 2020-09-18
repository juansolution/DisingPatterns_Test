using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento.Console
{
    public class Memento
    {
        private Persona state { get; set; }
        public Memento(Persona state)
        {
            this.state = state;
        }

        public Persona getState() {

            return state;
        } 
    }
}
