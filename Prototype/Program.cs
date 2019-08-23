using System;

//Es un patrón creacional
// El objetivo es crear una nueva instancia con los valores clonados o copiados de otra instancia
// sin pasar por la asignacion de los valores uno por uno.
// Y si se modifican los valores del primer objeto no varía en el segundo ya que es otro objeto
// hay dos tipos de clonanciones la superficial y la profunda. La superficial solo clona los atributos que
//son tipos básicos no objetos, en profundidad también se clonan los objetos complejos
namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal() { Nombre="Oveja Dolly", Patas=4};
            Animal animalClonado = animal.Clone() as Animal;
            animalClonado.Patas = 5;

            Console.WriteLine("El primer animal tiene " + animal.Patas.ToString() + " Patas");
            Console.WriteLine("El animal clonado tiene " + animalClonado.Patas.ToString() + " Patas");
            Console.ReadKey();

        }
    }
}
