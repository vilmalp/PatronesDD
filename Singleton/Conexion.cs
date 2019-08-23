using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    class Conexion
    {
        private static Conexion instancia;

        //Para evitar que se creen instancias con el operador new se declara el constructor private.
        private Conexion()
        {

        }

        // Se obtiene la instancia de la conexión solo por este método
        // La palabra reservada static hace posible el acceso sin la creación del objeto Conexión solo 
        // mediante Clase.metodo (Conexion.GetConexion())
        public static Conexion GetConexion()
        {
            if (instancia == null) {
                instancia = new Conexion();
            }
            return instancia;
        }

        public void Conectar()
        {
            Console.WriteLine("Se conectó a la base de datos.");
        }

        public void Desconectar()
        {
            Console.WriteLine("Se desconectó de la base de datos.");
        }
    }
}
