using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    abstract class Observador
    {
        protected Subject sujeto;
        public abstract void Actualizar();
    } 
}
