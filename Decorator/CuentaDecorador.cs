using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    abstract class CuentaDecorador : ICuentaBancaria
    {
        protected ICuentaBancaria cuentaDecorada;

        public CuentaDecorador(ICuentaBancaria cuentaDecorada) {
            this.cuentaDecorada = cuentaDecorada;
        }

        public virtual void AbrirCuenta(Cuenta cta) {
            this.cuentaDecorada.AbrirCuenta(cta);
        }   
    }
}
