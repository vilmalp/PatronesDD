using System;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            IConexion c1 = new ConexionMySQL("vilma", "topo", "localhost");
            IConexion c2 = new ConexionPostgre("facu", "pass01", "10.0.0.2");

            IPersonaDAO dao = new PersonaDAOImp(c2);
            dao.ListarTodos();
            Console.ReadKey();
        }
    }
}
