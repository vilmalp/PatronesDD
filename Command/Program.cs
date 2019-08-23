using System;
/*
 Patrón Command
 Promueve la encapsulación de la petición de alguna operación bajo un método 
 EL objetivo de este patrón es tener un enfoque orientado a comandos    
     */
namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuenta cuenta = new Cuenta(1, 200);

            DepositarImpl opDepositar = new DepositarImpl(cuenta, 100);
            RetirarImpl opRetirar = new RetirarImpl(cuenta, 50);

            Invoker ivk = new Invoker();
            ivk.RecibirOperacion(opDepositar);
            ivk.RecibirOperacion(opRetirar);
            ivk.RealizarOperaciones();

            Console.ReadKey();
        }
    }
}
