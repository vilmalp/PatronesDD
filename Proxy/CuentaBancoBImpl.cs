using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy
{

    class CuentaBancoBImpl : ICuenta
    {
        public Cuenta DepositarDinero(Cuenta cta, double monto)
        {
            double saldoActual = cta.SaldoInicial + monto +0.20;
            cta.SaldoInicial = saldoActual;
            Console.WriteLine("Dinero depositado Saldo actual : " + cta.SaldoInicial);
            return cta;
        }

        public void MostrarSaldo(Cuenta cta)
        {
            Console.WriteLine("Su saldo actual es de :" + cta.SaldoInicial);
        }

        public Cuenta RetirarDinero(Cuenta cta, double monto)
        {
            double saldoActual = cta.SaldoInicial- monto;
            cta.SaldoInicial = saldoActual;
            Console.WriteLine("Dinero retirado Saldo actual : " + cta.SaldoInicial);
            return cta;
        }
    }
}
