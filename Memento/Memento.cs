using System;
using System.Collections.Generic;
using System.Text;

namespace Memento
{
    class Memento
    {
        public Memento(Juego juegoEstado)
        {
            this.Estado = juegoEstado;
        }
        public Juego Estado { get; set; }
    }
}
