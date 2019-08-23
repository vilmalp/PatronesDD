using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Strategy
{
    class AntivirusAvanzado : AnalisisAvanzado
    {
        public override void AnalizarKeyLogger()
        {
            try
            {
                Console.WriteLine("Analizando en busca de KeyLoggers ... ");
                Thread.Sleep(2500);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public override void AnalizarMemoria()
        {
            try
            {
                Console.WriteLine("Analizando Memoria RAM ... ");
                Thread.Sleep(2500);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public override void DescomprimirZip()
        {
            try
            {
                Console.WriteLine("Descomprimiendo archivos ZIP ... ");
                Thread.Sleep(2500);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public override void Detener()
        {
            Console.WriteLine("Antivirus avanzado - Analisis Avanzado finalizado.");
        }

        public override void Iniciar()
        {
            Console.WriteLine("Antivirus avanzado - Analisis Avanzado iniciado.");
        }
    }
}
