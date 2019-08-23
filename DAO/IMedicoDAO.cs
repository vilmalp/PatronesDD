using System;
using System.Collections.Generic;
using System.Text;

namespace DAO
{
    //Esta interfaz estaría para las operaciones que no son comunes a todos y que son específicos de un médico
    interface IMedicoDAO : ICRUD<Medico>
    {

        void Curar(Medico medico);
     
    }
}
