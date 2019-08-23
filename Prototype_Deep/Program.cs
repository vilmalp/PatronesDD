using System;

//Es un patrón creacional
// El objetivo es crear una nueva instancia con los valores clonados o copiados de otra instancia
// sin pasar por la asignacion de los valores uno por uno.
// Y si se modifican los valores del primer objeto no varía en el segundo ya que es otro objeto
// hay dos tipos de clonanciones la superficial y la profunda. La superficial solo clona los atributos que
//son tipos básicos no objetos, en profundidad también se clonan los objetos complejos
namespace Prototype_Deep
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal() { Nombre = "Oveja Dolly", Patas = 4 };
            animal.Caracteristicas = new Detalles();
            animal.Caracteristicas.Color = "Blanca";
            animal.Caracteristicas.Raza = "Oveja";

            Animal animalClonado = animal.Clone() as Animal;
            animalClonado.Caracteristicas.Color = "Negro";
            animalClonado.Nombre= "Oveja negra";

            Console.WriteLine("Original");
            Console.WriteLine(animal.Caracteristicas.Color);
            Console.WriteLine(animal.Nombre);

            Console.WriteLine("Clonado");
            Console.WriteLine(animalClonado.Caracteristicas.Color);
            Console.WriteLine(animalClonado.Nombre);

            Console.ReadKey();
        }
    }
}
