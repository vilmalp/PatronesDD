using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class ConexionBDFactory : IAbstractFactory
    {
        public IConexionBD getConexionBD(string motor)
        {
            switch (motor)
            {
                case "MYSQL":
                    return new ConexionBDMySQL();
                case "ORACLE":
                    return new ConexionBDOracle();
                case "POSTGRESQL":
                    return new ConexionBDPostgreSQL();
                default:
                    return new ConexionBDVacia();
            }
        }

        public IConexionREST getConexionREST(string area)
        {
            return null;
        }
    }
}
