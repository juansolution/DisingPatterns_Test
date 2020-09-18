using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Subject
    {

        private List<Observer> observers = new List<Observer>();
        private int state { get; set; }

        public int getState() {
            return state;
        }

        public void setState( int state) {
            this.state = state;
            notifyAllObserver();
        }

        public void attach(Observer observer) {

            observers.Add(observer);
                
        }

        private void notifyAllObserver()
        {
            foreach (Observer observer in observers)
            {
                observer.update();

            }
        }
    }
}
