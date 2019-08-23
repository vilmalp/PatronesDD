using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    class PesoMXObservador: Observador
    {
        private double ValorCambio = 19.07;
        public PesoMXObservador(Subject sbSujeto)
        {
            this.sujeto = sbSujeto;
            this.sujeto.Agregar(this);
        }

        public override void Actualizar()
        {
            Console.WriteLine("MX: " + (sujeto.Estado * ValorCambio));
        }
    }
}
