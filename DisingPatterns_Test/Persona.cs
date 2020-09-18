using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisingPatterns_Test
{
    class Persona : ICloneable
    {
        public Persona()
        {
            this.fistname = "Juan Esteban";
            this.lastname = "Piedrahita";
            this.id = 71293257;
        }

        public Persona(string fistname, string lastname, int id)
        {
            this.fistname = fistname;
            this.lastname = lastname;
            this.id = id;
        }

        public string fistname { get; set; }
        public string lastname { get; set; }

        public int id { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
