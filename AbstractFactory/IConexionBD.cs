using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    interface IConexionBD
    {
        void conectar();
        void desconectar();
    }
}
