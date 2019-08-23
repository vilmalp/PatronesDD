using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy
{
    interface ICuenta
    {
        Cuenta RetirarDinero(Cuenta cta, double monto);
        Cuenta DepositarDinero(Cuenta cta, double monto);
        void MostrarSaldo(Cuenta cta);

    }
}
