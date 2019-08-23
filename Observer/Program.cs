using System;

namespace Observer
{
    /*
     Patrón Observador.
     Está formado por tres clases : el sujeto que es el objeto en observación , el observador y el cliente 
     el que va a utilizar las otras clases 
     El sujeto tiene un estado que cuando cambia ese estado notifica a una lista de observadores que cambió
     ese estado para los observadores puedan ejecutar alguna acción

    En este ejmplo se modela que cuando una divisa cambia su valor notifica a las otras divisas que deben actualizar su
    valor
         */
    class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new Subject();

            new SolObservador(subject);
            new PesoARGObserver(subject);
            new PesoMXObservador(subject);

            Console.WriteLine("Si desea cambiar 10 dólares obtendrá:");
            subject.Estado = 10;
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Si desea cambiar 100 dólares obtendrá:");
            subject.Estado = 100;

            Console.ReadKey();

        }
    }
}
