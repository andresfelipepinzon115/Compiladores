using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Translator.Cache
{
    public class Line

    {
        private int numeroLinea;
        private string contenido;

        private Line(int numeroLinea, string contenido)
        {
            NumeroLinea = numeroLinea;
            Contenido = contenido;
        }

        public static Line Crear(int numeroLinea, string contenido)
        {
            return new Line(numeroLinea, contenido);
        }

        public int NumeroLinea { get => numeroLinea; set => numeroLinea = value; }
        public string Contenido { get => contenido; set => contenido = value; }
    }
}
