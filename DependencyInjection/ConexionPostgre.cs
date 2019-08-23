﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection
{
    class ConexionPostgre : IConexion
    {
        private string usuario;
        private string clave;
        private string host;

        public ConexionPostgre(string user,string pass,string hst)
        {
            this.usuario = user;
            this.clave = pass;
            this.host = hst;
       
        }

        public void Conectar()
        {
            Console.WriteLine("Conectando con PostgeSql...");
        }
    }
}
