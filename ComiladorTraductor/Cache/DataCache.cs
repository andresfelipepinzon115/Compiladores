using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiladorTraductor.Cache
{
    public class DataCache
    {
        private static Dictionary<int, Line> programaFuente
           = new Dictionary<int, Line>();
        public static void limpiar()
        {
            programaFuente.Clear();
        }
        public static void AgregarLinea(string linea)
        {
            if (linea != null)
            {
                int numeroLinea = ObtenetProximaLinea();
                programaFuente.Add(numeroLinea, Line.Crear(numeroLinea, linea));
            }
        }

        public static void AgregarLineas(List<string> lineas)
        {
            foreach (string linea in lineas)
            {
                AgregarLinea(linea);
            }
        }

        private static int ObtenetProximaLinea()
        {
            return programaFuente.Count + 1;
        }
        public static Line ObtenerLinea(int numeroLinea)
        {
            int numeroUltimaLinea = ObtenetProximaLinea();
            Line lineaRetorno = Line.Crear(numeroUltimaLinea, "@EOF@");

            if (numeroLinea <= 0)
            {
                throw new Exception("Número de línea inválido");
            }
            else if (numeroLinea <= programaFuente.Count)
            {
                lineaRetorno = programaFuente[numeroLinea];
            }
            return lineaRetorno;
        }
    }
}
