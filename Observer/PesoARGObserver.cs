using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    class PesoARGObserver :Observador 
    {
        private double ValorCambio = 57.40;
        public PesoARGObserver(Subject sbSujeto)
        {
            this.sujeto = sbSujeto;
            this.sujeto.Agregar(this);
        }

        public override void Actualizar()
        {
            Console.WriteLine("ARG: " + (sujeto.Estado * ValorCambio));
        }
    }
}
