using System;

namespace ConsoleApp1
{
    public abstract class Observer
    {
        public Subject subject;
        public abstract void update();

    }
}