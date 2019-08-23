using System;
using System.Collections.Generic;
using System.Text;

namespace Memento
{
    class Juego
    {
        public string Nombre { get; set; }
        public int  Checkpoint { get; set; }

        public string Estado() {
            return "Juego NOMBRE = "+ this.Nombre+", CHECKPOINT = " + this.Checkpoint;
        }
    }
}
