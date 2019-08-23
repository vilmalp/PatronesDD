using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    abstract class AnalisisAvanzado : IEstrategia
    {

        public void Analizar()
        {
            Iniciar();
            AnalizarMemoria();
            AnalizarKeyLogger();
            DescomprimirZip();
            Detener();
    }

        public abstract void Iniciar();
        public abstract void AnalizarMemoria();
        public abstract void AnalizarKeyLogger();
        public abstract void DescomprimirZip();
        public abstract void Detener();
    }
}
