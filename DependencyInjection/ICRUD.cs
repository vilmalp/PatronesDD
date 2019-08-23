using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection
{
    interface ICRUD<T>
    {
        List<T> ListarTodos();
        T LeerPorId(int id);
        void Registrar(T t);
        void Actualizar(T t);
        void Eliminar(int id);
    }
}
