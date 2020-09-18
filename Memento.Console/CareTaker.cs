﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento.Console
{
    public class CareTaker
    {
        private List<Memento> mementoList = new List<Memento>();

        public void add(Memento state) {
            mementoList.Add(state);
        }

        public Memento get(int index) {
            return mementoList.ElementAt(index);
        }
    }
}
