using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    class Animal : ICloneable
    {
       public int Patas { get; set; }
       public string Nombre { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
