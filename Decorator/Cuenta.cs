using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class Cuenta
    {
        public int id { set; get; }
        public string cliente { set; get; }

        public Cuenta()
        {
                       
        }

        public Cuenta (int id, string cliente)
        {
            this.id = id;
            this.cliente = cliente;
        }
    }
}
