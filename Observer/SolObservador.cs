using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    class SolObservador:Observador
    {
        private double ValorCambio = 3.25;
        public SolObservador(Subject sbSujeto)
        {
            this.sujeto = sbSujeto;
            this.sujeto.Agregar(this);
        }
         
        public override void Actualizar()
        {
            Console.WriteLine("PEN: " + (sujeto.Estado * ValorCambio));
        }

    }
}
