using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype_Deep
{
    class Animal : ICloneable
    {
       public int Patas { get; set; }
       public string Nombre { get; set; }

        public Detalles Caracteristicas { get; set; }


        public object Clone()
        {
            Animal clon = this.MemberwiseClone() as Animal;
            Detalles detalles = new Detalles();
            detalles.Color = this.Caracteristicas.Color;
            detalles.Raza = this.Caracteristicas.Raza;
            clon.Caracteristicas = detalles;
            return clon;
        }
    }
}
