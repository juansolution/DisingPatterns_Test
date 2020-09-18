using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context;

            context = new Context(new OperationAdd());
            Console.WriteLine("10 + 5 =" + context.executeStrategy(10, 5));

            context = new Context(new OperationSubstract());
            Console.WriteLine("10 - 5 =" + context.executeStrategy(10, 5));

            context = new Context(new OperationMultiply());
            Console.WriteLine("10 * 5 =" + context.executeStrategy(10, 5));


        }
    }
}
