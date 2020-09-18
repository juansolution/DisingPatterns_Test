using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento.Console
{
    public class Originator
    {
        private Persona state { get; set; }

        public void setState(Persona state) {
            this.state = state;
        }

        public Persona getState() {
            return state;
        }

        public Memento saveStateToMemento() {
            return new Memento((Persona)state.Clone());
        }

        public void getStateFromMemento(Memento memento) {
            state = memento.getState();

        }
    }
}
