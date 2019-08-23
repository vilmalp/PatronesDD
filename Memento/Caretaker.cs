using System;
using System.Collections.Generic;
using System.Text;

namespace Memento
{
    class Caretaker
    {
        private List<Memento> mementos =  new List<Memento>();

        public void AddMemento(Memento m)
        {
            mementos.Add(m);
        }

        public Memento GetMemento(int index)
        {
            return this.mementos[index];
        }
    }
}
