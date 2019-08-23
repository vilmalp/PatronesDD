using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class ConexionRESTFactory : IAbstractFactory
    {
        public IConexionBD getConexionBD(string motor)
        {
            return null;
        }

        public IConexionREST getConexionREST(string area)
        {
            switch (area)
            {
                case "COMPRAS":
                    return new ConexionRESTCompras();
                case "VENTAS":
                    return new ConexionRESTVentas();
                default:
                    return new ConexionRESTNoArea();
            }
        }
    }
}
