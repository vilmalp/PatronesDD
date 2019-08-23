using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    interface IAbstractFactory
    {
        IConexionBD getConexionBD(string motor);
        IConexionREST getConexionREST(string area);
    }
}
