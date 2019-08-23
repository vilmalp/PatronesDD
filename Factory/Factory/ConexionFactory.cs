using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    class ConexionFactory
    {
        public IConexion GetConexion(string motor)
        {
            switch (motor)
            {
                case "MYSQL":
                    return new ConexionMySQL();
                case "ORACLE":
                    return new ConexionOracle();
                case "POSTGRESQL":
                    return new ConexionPostgreSQL();
                default:
                    return new ConexionVacia();
            }
        }

    }
}
