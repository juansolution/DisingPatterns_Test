﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Circle : IShape
    {
        public void draw()
        {
            Console.WriteLine("Se dibuja un circulo.");
        }
    }
}
