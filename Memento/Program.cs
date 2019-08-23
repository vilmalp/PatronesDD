using System;
/*
 Promueve el guardado de un estado de alguna operación que estas trabajando. Se crea un check point para restaurar 
 ese estado en el momento que lo necesitemos.
     
     */
namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombreJuego = "Mario Bross";

            Juego juego = new Juego();
            juego.Nombre = nombreJuego;
            juego.Checkpoint = 1;

            Caretaker caretaker = new Caretaker();
            Originator originator = new Originator();

            juego = new Juego();
            juego.Nombre = nombreJuego;
            juego.Checkpoint = 2;

            originator.Estado = juego;

            juego = new Juego();
            juego.Nombre = nombreJuego;
            juego.Checkpoint = 3;

            originator.Estado = juego;

            caretaker.AddMemento(originator.Guardar()); //Estado posición 0

            juego = new Juego();
            juego.Nombre = nombreJuego;
            juego.Checkpoint = 4;

            originator.Estado = juego;

            caretaker.AddMemento(originator.Guardar()); //Estado posición 1

            juego = new Juego();
            juego.Nombre = nombreJuego;
            juego.Checkpoint = 5;

            originator.Estado = juego;
            originator.Restaurar(caretaker.GetMemento(0));

            juego = originator.Estado;

            Console.WriteLine(juego.Estado());

            Console.ReadKey();
        
        }
    }
}
