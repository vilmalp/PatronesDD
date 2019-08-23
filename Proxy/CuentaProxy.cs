using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy 
{
    class CuentaProxy : ICuenta
    {
        // private  CuentaBancoAImpl cuentaReal ;
        private ICuenta cuentaReal;
        public CuentaProxy(ICuenta  cuenta )
        {
            this.cuentaReal = cuenta;
        }

        public Cuenta DepositarDinero(Cuenta cta, double monto)
        {
            if (cuentaReal == null)
            {
                cuentaReal = new CuentaBancoAImpl();
                return cuentaReal.DepositarDinero(cta, monto);
            }
            else
            {
                return cuentaReal.DepositarDinero(cta, monto);
            }
        }

        public void MostrarSaldo(Cuenta cta)
        {
            if (cuentaReal == null)
            {
                cuentaReal = new CuentaBancoAImpl();
                cuentaReal.MostrarSaldo(cta);
            }
            else
            {
                cuentaReal.MostrarSaldo(cta);
            }
        }

        public Cuenta RetirarDinero(Cuenta cta, double monto)
        {
            if (cuentaReal == null)
            {
                cuentaReal = new CuentaBancoAImpl();
                return cuentaReal.RetirarDinero(cta, monto);
            }
            else
            {
                return cuentaReal.RetirarDinero(cta, monto);
            }
        }
    }
}
