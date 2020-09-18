using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Originator originator = new Originator();
            CareTaker careTaker = new CareTaker();

            Persona persona = new Persona();
            originator.setState(persona);

            /*Cambio 1*/
            careTaker.add(originator.saveStateToMemento());

            persona.email = "juan.piedrahita@satrack.com";

            originator.setState(persona);

            /*Cambio 1*/
            careTaker.add(originator.saveStateToMemento());

            persona.id = 1212;
            originator.setState(persona);
            /*Cambio 1*/
            careTaker.add(originator.saveStateToMemento());

            persona.lastname = "Montoya";
            originator.setState(persona);

            /*Retornar un estado anterior o actual */

            /*Restaurar al primer cambio*/
            originator.getStateFromMemento(careTaker.get(0));

            /*Restaurar al primer cambio*/
            originator.getStateFromMemento(careTaker.get(1));

        }
    }
}
