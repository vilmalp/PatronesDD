using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class CuentaCorriente : ICuentaBancaria
    {
        public void AbrirCuenta(Cuenta cta)
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Se abrió una cuenta de corriente.");
            Console.WriteLine("Para el cliente " + cta.cliente);
        }

    }
}
