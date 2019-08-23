using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class BlindajeDecorador : CuentaDecorador 
    {
        public BlindajeDecorador(ICuentaBancaria cuentaBancaria ): base(cuentaBancaria) {
            
        }
        public override void AbrirCuenta(Cuenta cta)
        {
            cuentaDecorada.AbrirCuenta(cta);
            AgregarBlindaje(cta);
        }

        public void AgregarBlindaje(Cuenta cta)
        {
            Console.WriteLine("Se agregó blindaje a la cuenta del cliente " + cta.cliente);

        }
    }
}
