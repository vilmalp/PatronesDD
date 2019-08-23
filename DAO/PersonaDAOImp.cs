using System;
using System.Collections.Generic;
using System.Text;

namespace DAO
{
    class PersonaDAOImp : IPersonaDAO
    {
        public void Actualizar(Persona persona)
        {
            Console.WriteLine("Se actualizó en la Base de datos la persona con Nombre = " + persona.Nombre);
        }

        public void Eliminar(int id)
        {
            Console.WriteLine("Se eliminó la persona con ID = " + id);
        }

        public Persona LeerPorId(int id)
        {
            if (id == 1)
            { 
                Persona per = new Persona
                {
                    Id = 1,
                    Nombre = "Facundo"
                };
                return per;
            }
            else
            { 
                Persona per = new Persona
                {
                    Id = 2,
                    Nombre = "Vilma"
                };
                return per;
            }
        }

        public List<Persona> ListarTodos()
        {
            List<Persona> lista = new List<Persona>();

            Persona per = new Persona
            {
                Id = 1,
                Nombre = "Facundo"
            };

            lista.Add(per);

            per = new Persona
            {
                Id = 2,
                Nombre = "Vilma"
            };

            lista.Add(per);

            return lista;
        }

        public void Registrar(Persona persona)
        {
            Console.WriteLine("Se registró en la Base de datos la persona con Nombre = " + persona.Nombre);
        }
    }
}
