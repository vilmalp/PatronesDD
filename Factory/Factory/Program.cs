using System;

// Es uno de los patrones creacionales.
// Devuelve instancias de una clase dependiendo de un identificador
//https://sourcemaking.com/design_patterns/factory_method
//https://www.tutorialspoint.com/design_pattern/factory_pattern.htm
namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            ConexionFactory cf = new ConexionFactory();
            
            IConexion a = cf.GetConexion("MYSQL");
            a.conectar();
            a.desconectar();

            IConexion b = cf.GetConexion("ORACLE");
            b.conectar();
            b.desconectar();

            IConexion c = cf.GetConexion("POSTGRESQL");
            c.conectar();
            c.desconectar();

            IConexion d = cf.GetConexion("");
            d.conectar();
            d.desconectar();

            Console.ReadKey();
        }
    }
}
