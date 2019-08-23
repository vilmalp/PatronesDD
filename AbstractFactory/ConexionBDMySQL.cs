using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class ConexionBDMySQL: IConexionBD
    {
        private string stringConexion;
        
        public ConexionBDMySQL()
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
