using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    class ConexionOracle : IConexion
    {
        private string stringConexion;

        public ConexionOracle()
        {
            this.stringConexion = "string de conexión a la base de datos Oracle";
        }

        public void conectar()
        {
            Console.WriteLine("Se conectó a Oracle");
        }

        public void desconectar()
        {
            Console.WriteLine("Se desconectó de Oracle");
        }

    }
}
