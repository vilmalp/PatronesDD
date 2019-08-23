using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class ConexionRESTVentas : IConexionREST
    {
        public void leerURL(string strUrl)
        {
            Console.WriteLine("ConexionRESTVentas: Conectándose a " + strUrl);
        }
    }
}
