using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    class AvionAPI
    {
        public void BuscarVuelos(string strFechaIda, string strFechaVuelta, string strOrigen, string strDestino)
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Vuelos encontrados para " + strDestino + " desde " + strOrigen);
            Console.WriteLine("Fecha ida " + strFechaIda + " Fecha vuelta " + strFechaVuelta);
            Console.WriteLine("-------------------------------");
        }
    }
}
