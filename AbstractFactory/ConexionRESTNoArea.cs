using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class ConexionRESTNoArea : IConexionREST
    {
        public void leerURL(string strUrl)
        {
            Console.WriteLine("ConexionRESTNoArea: AREA NO ELEGIDA ");
        }
    }
}
