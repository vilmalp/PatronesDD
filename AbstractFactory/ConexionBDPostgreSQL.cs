using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class ConexionBDPostgreSQL: IConexionBD
    {
        private string stringConexion;
        
        public ConexionBDPostgreSQL()
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
