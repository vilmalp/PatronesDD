using System;

// Es uno de los patrones creacionales.
// Es una fábrica de fábricas. Si se necesita un objeto hay que indicar primero qué fábrica 
// va a producir este objeto y luego puedes obtener la instancia del objeto buscado
//https://sourcemaking.com/design_patterns/abstract_factory

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            // Identifico y obtengo la fábrica que voy a utilizar
            IAbstractFactory fabricaBD = FabricaProductor.getFactory("BD");
            // de la fábrica obtenida obtengo el objeto  de conexión que busco
            IConexionBD cxBD1 = fabricaBD.getConexionBD("MYSQL");

            cxBD1.conectar();

            IAbstractFactory fabricaREST = FabricaProductor.getFactory("REST");
            IConexionREST cxREST1 = fabricaREST.getConexionREST("COMPRAS");

            cxREST1.leerURL("esta es una url de prueba");

            Console.ReadKey();
        }
    }
}
