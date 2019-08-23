using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    class Invoker
    {
        private List<IOperacion> operaciones = new List<IOperacion> ();

        public void RecibirOperacion(IOperacion operacion)
        {
            this.operaciones.Add(operacion);
        }

        public void RealizarOperaciones()
        {
            this.operaciones.ForEach(x => x.Ejecutar());
        }
    }
}
