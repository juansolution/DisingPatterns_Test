using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisingPatterns_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona();
            Persona persona2 = (Persona)persona1.Clone();
            bool result = persona1 == persona2;
        }
    }
}
