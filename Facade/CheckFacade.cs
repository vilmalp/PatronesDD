using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    class CheckFacade
    {
        private AvionAPI avionAPI;
        private HotelAPI hotelAPI;

        public CheckFacade()
        {
            avionAPI = new AvionAPI();
            hotelAPI = new HotelAPI();
        }

        public void Buscar(string strFechaIda, string strFechaVuelta, string strOrigen, string strDestino) {
            avionAPI.BuscarVuelos(strFechaIda, strFechaVuelta, strOrigen, strDestino);
            hotelAPI.BuscarHotel(strFechaIda, strFechaVuelta, strOrigen, strDestino);
        }

    }
}
