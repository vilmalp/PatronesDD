using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class ConexionBDVacia: IConexionBD
    {
        private string stringConexion;
        
        public ConexionBDVacia()
        {
            this.stringConexion = "Conexión vacía";
        }

        public void conectar()
        {
            Console.WriteLine("NO SE ESPECIFICA PROVEEDOR");
        }

        public void desconectar()
        {
            Console.WriteLine("NO SE ESPECIFICA PROVEEDOR");
        }

        
    }
}
