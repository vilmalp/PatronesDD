using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    class ConexionMySQL: IConexion
    {
        private string stringConexion;
        
        public ConexionMySQL()
        {
            this.stringConexion = "string de conexión a la base de datos MySQL";
        }

        public void conectar()
        {
            Console.WriteLine("Se conectó a MySQL");
        }

        public void desconectar()
        {
            Console.WriteLine("Se desconectó de MySQL");
        }

        
    }
}
