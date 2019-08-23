using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    class RetirarImpl : IOperacion
    {
        private Cuenta Cuenta;
        private double Monto;

        public RetirarImpl(Cuenta cta, double monto)
        {
            this.Cuenta = cta;
            this.Monto = monto;
        }

        public void Ejecutar()
        {
            this.Cuenta.Retirar(this.Monto);
        }
    }
}
