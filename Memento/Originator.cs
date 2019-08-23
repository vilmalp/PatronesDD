using System;
using System.Collections.Generic;
using System.Text;

namespace Memento
{
    // sabe como guardar el objeto
    class Originator
    {
        public Juego Estado { get; set; }

        public Memento Guardar()
        {
            return new Memento( this.Estado);
        }

        public void Restaurar(Memento m) {
            this.Estado = m.Estado;
        }
    }
}
