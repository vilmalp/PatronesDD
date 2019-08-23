using System;
/*
 Patron DAO
 Abstrae la lógica de acceso de un conjunto de operaciones.
 Se utiliza mucho para acceder a las operaciones de acceso a las bases de datos.
     */

namespace DAO
{
    class Program
    {
        static void Main(string[] args)
        {
            ICRUD<Persona> dao = new PersonaDAOImp();
            dao.ListarTodos().ForEach(x => Console.WriteLine("Nombre = " + x.Nombre));

            Persona persona = new Persona
            {
                Id=3,
                Nombre = "Alejandro"
            };

            dao.Registrar(persona);

            ICRUD<Medico> dao2 = new MedicoDAOImp();
            dao2.ListarTodos().ForEach(x => Console.WriteLine("Nombre = " + x.Nombre));

            Console.ReadKey();
        }
    }
}
