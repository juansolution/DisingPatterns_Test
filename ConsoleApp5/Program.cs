using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {

            //SingleObject singleObject = SingleObject.getIntance();
            //singleObject.showMessage();

            SingleObject s1 = SingleObject.getIntance();
            SingleObject s2 = SingleObject.getIntance();

            // Both Singleton objects above should now reference the same Singleton instance.
            if (Object.ReferenceEquals(s1, s2))
            {
                Console.WriteLine("Singleton is working");
            }
            else
            {
                // Otherwise, the Singleton Instance property is returning something 
                // other than the unique, single instance when called.
                Console.WriteLine("Singleton is broken");
            }


            Singleton s3 = Singleton.Instance;
            Singleton s4 = Singleton.Instance;

            // Both Singleton objects above should now reference the same Singleton instance.
            if (Object.ReferenceEquals(s3, s4))
            {
                Console.WriteLine("Singleton is working");
            }
            else
            {
                // Otherwise, the Singleton Instance property is returning something 
                // other than the unique, single instance when called.
                Console.WriteLine("Singleton is broken");
            }


        }
    }
}
