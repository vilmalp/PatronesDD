using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Strategy
{
    public class AntivirusSimple : AnalisisSimple
    {
        public override void Iniciar()
        {
            Console.WriteLine("Antivirus simple - Analisis simple iniciado.");
        }
        public override void SaltarZip()
        {
            try {
                Console.WriteLine("Analizando simple ... ");
                Thread.Sleep(2500);
                Console.WriteLine("No se pudo analizar archivos con extensión .zip");

            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);

            }
        }
        public override void Detener()
        {
            Console.WriteLine("Antivirus simple - Analisis simple finalizado.");

        }

    }
}
