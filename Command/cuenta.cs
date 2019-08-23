using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    //Reciever/Request
    class Cuenta
    {
        public int Id { set; get; }
        public double Saldo { set; get; }

        public Cuenta(int id, double saldo)
        {
            this.Id = id;
            this.Saldo = saldo;
        }

        public void Retirar(double monto)
        {
            this.Saldo = this.Saldo - monto;
            Console.WriteLine("[COMANDO RETIRAR] Cuenta: " + Id + " Saldo: " + this.Saldo);
        }

        public void Depositar(double monto)
        {
            this.Saldo = this.Saldo + monto;
            Console.WriteLine("[COMANDO DEPOSITAR] Cuenta: " + Id + " Saldo: " + this.Saldo);
        }
    }
}
