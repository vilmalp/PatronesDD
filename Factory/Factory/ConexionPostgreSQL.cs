using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    class ConexionPostgreSQL: IConexion
    {
        private string stringConexion;
        
        public ConexionPostgreSQL()
        {
            this.stringConexion = "string de conexión a la base de datos PostgreSQL";
        }

        public void conectar()
        {
            Console.WriteLine("Se conectó a PostgreSQL");
        }

        public void desconectar()
        {
            Console.WriteLine("Se desconectó de PostgreSQL");
        }

        
    }
}
