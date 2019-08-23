using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class ConexionBDOracle : IConexionBD
    {
        private string stringConexion;

        public ConexionBDOracle()
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
