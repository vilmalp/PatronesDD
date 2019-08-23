using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class ConexionRESTCompras : IConexionREST
    {
        public void leerURL(string strUrl)
        {
            Console.WriteLine("ConexionRESTCompras: Conectándose a " + strUrl);
        }
    }
}
