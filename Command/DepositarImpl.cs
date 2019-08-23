using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    class DepositarImpl : IOperacion
    {
        private Cuenta cuenta;
        private double monto;

        public DepositarImpl(Cuenta cta, double monto)
        {
            this.cuenta = cta;
            this.monto = monto;
        }

        public void Ejecutar()
        {
            this.cuenta.Depositar(this.monto);
        }
        
    }
}
