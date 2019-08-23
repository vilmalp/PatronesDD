using System;

// Patrón Decorador
// Permite agregar funcionalidades a un objeto existente sin alterar su estructura, es decir, no hay
// necesidad de modificar el código de la clase base.

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuenta c = new Cuenta(1, "Vilma");

            ICuentaBancaria cuenta = new CuentaAhorro();
            ICuentaBancaria cuentaBlindada = new BlindajeDecorador(cuenta);

            cuenta.AbrirCuenta(c);
            cuentaBlindada.AbrirCuenta(c);

             Console.ReadKey();
        }
    }
}
