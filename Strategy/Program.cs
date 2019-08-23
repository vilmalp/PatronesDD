using System;
//Es un patrón de diseño de comportamiento.
// Organiza el comportamiento que va a tener un objeto y este comportamiento puede cambiar dinamicamente
// en tiempo de ejecución 
// Este patrón de diseño está formado por tres componentes el contexto, la estrategia, la estrategia concreta
// El contexto es la clase que vamos a usar para crear el objeto
// 

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Contexto contexto = new Contexto(new AntivirusSimple());
            contexto.ejecutar();

            contexto = new Contexto(new AntivirusAvanzado());
            contexto.ejecutar();

            Console.ReadKey();
        }
    }
}
