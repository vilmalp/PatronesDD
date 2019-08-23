using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    class HotelAPI
    {
        public void BuscarHotel(string strFechaEntrada, string strFechaSalida, string strOrigen, string strDestino)
        { 
        Console.WriteLine("-------------------------------");
            Console.WriteLine("Hoteles encontrados");
            Console.WriteLine("Entrada " + strFechaEntrada + " Salida " + strFechaSalida);
            Console.WriteLine("Hotel A");
            Console.WriteLine("Hotel B");
            Console.WriteLine("Hotel C");
            Console.WriteLine("-------------------------------");
        }
    }
}
