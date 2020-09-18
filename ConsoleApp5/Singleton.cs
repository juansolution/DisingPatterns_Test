using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Singleton
    {
        // Because the _instance member is made private, the only way to get the single 
        // instance is via the static Instance property below. This can also be similarly 
        // achieved with a GetInstance() method instead of the property.
        private static Singleton _instance = null;

        // Making the constructor private prevents other instances from being 
        // created via something like Singleton s = new Singleton(), protecting
        // against unintentional misuse.
        private Singleton()
        {
        }

        public static Singleton Instance
        {
            get
            {
                // The first call will create the one and only instance.
                if (_instance == null)
                {
                    _instance = new Singleton();
                }

                // Every call afterwards will return the single instance created above.
                return _instance;
            }
        }

        public void showMessage()
        {
            Console.WriteLine("Hello World");
        }
    }
}
