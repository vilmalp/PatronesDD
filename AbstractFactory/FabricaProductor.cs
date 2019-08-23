using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class FabricaProductor 
    {
        public static IAbstractFactory getFactory(string strFactory)
        {
            switch (strFactory)
            {
                case "BD":
                    return new ConexionBDFactory();
                default:
                    return new ConexionRESTFactory();
            }

        }
    }
}
