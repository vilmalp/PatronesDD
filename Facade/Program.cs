using System;
// Patrón Fachada
// Es un patrón estructural cuyo objetivo es ocultad la complejidad que pueda tener la aplicación y que
// el cliente tenga un punto de acceso 

// En este ejercicio se quiere hacer la reserva de un vuelo y hotel
namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckFacade cliente1 = new CheckFacade();
            cliente1.Buscar("20/02/2020", "20/03/2020", "Buenos Aires", "Cancun");

            Console.ReadKey();
        }
    }
}
