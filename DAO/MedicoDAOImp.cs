using System;
using System.Collections.Generic;
using System.Text;

namespace DAO
{
    class MedicoDAOImp : IMedicoDAO
    {
        public void Actualizar(Medico medico)
        {
            Console.WriteLine("Se actualizó en la Base de datos el médico con Nombre = " + medico.Nombre);
        }

        public void Eliminar(int id)
        {
            Console.WriteLine("Se eliminó el médico con ID = " + id);
        }

        public Medico LeerPorId(int id)
        {
            if (id == 1)
            { 
                Medico medico  = new Medico
                {
                    Id = 1,
                    Nombre = "Ramón"
                };
                return medico;
            }
            else
            { 
                Medico medico  = new Medico
                {
                    Id = 2,
                    Nombre = "Nancy"
                };
                return medico;
            }
        }

        public List<Medico> ListarTodos()
        {
            List<Medico> lista = new List<Medico>();

            Medico medico = new Medico
            {
                Id = 1,
                Nombre = "Ramón"
            };

            lista.Add(medico);

            medico = new Medico
            {
                Id = 2,
                Nombre = "Nancy"
            };

            lista.Add(medico);

            return lista;
        }

        public void Registrar(Medico medico)
        {
            Console.WriteLine("Se registró en la Base de datos el médico con Nombre = " + medico.Nombre);
        }

        public void Curar(Medico medico)
        {
            Console.WriteLine("El médico " + medico.Nombre + " está CURANDO.");
        }
    }
}
