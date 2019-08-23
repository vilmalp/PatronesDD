using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy 
{
    class Cuenta
    {
        public int IdCuenta  { set; get; }
        public string Cliente { set; get; }
        public double SaldoInicial { set; get; }

        public Cuenta(int idCuenta, string strCliente, double dbSaldoInicial)
        {
            this.IdCuenta = IdCuenta;
            this.Cliente = strCliente;
            this.SaldoInicial = dbSaldoInicial;
        }

        public Cuenta (int id, string cliente)
        {
            this.IdCuenta = id;
            this.Cliente = cliente;
        }
    }
}
