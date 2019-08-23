using System;
/*
 Patrón Proxy 
 Es un patrón estructural que crea un envoltorio para un objeto remoto o un objeto sensible o un objeto pesado
 Encapsula la complejidad del objeto en un envoltorio
 El cliente interactúa con el envoltorio
 Luego el envoltorio delega al objeto el rol
 Tiene la flexibilidad de poder cambiar alguna implementación se puede crear un interaz
     
     */
namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuenta c = new Cuenta(1, "Vilma",100);

            ICuenta ctaProxy = new CuentaProxy(new CuentaBancoAImpl ());
            ctaProxy.MostrarSaldo(c);
            c = ctaProxy.DepositarDinero(c, 50);
            c = ctaProxy.RetirarDinero(c, 20);
            ctaProxy.MostrarSaldo(c);


            ICuenta ctaProxy2 = new CuentaProxy(new CuentaBancoBImpl());
            ctaProxy2.MostrarSaldo(c);
            c = ctaProxy2.DepositarDinero(c, 50);
            c = ctaProxy2.RetirarDinero(c, 20);
            ctaProxy2.MostrarSaldo(c);


            Console.ReadKey();
        }
    }
}
