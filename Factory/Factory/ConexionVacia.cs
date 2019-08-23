using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    class ConexionVacia: IConexion
    {
        private string stringConexion;
        
        public ConexionVacia()
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
