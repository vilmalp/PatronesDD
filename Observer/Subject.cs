using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    class Subject
    {
        private List<Observador> observardores = new List<Observador>();

        private int _Estado;
        public int Estado {

            get { return this._Estado; }

            set {

                this._Estado = value;
                NotificarTodosObservadores();
            } }

        public void Agregar (Observador observador)
        {
            observardores.Add(observador);
        }

        public void NotificarTodosObservadores()
        {
            observardores.ForEach(x => x.Actualizar());
        }
    }
}
