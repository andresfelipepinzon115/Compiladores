using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compilador.GestorErrores
{
    public class Error
    {
        private int numeroLinea;
        private int posicionInicial;
        private int posicionFinal;
        private String lexema;
        private string falla;
        private string causa;
        private string solucion;
        private TipoError tipo;
        private CategoriaError categoria;

        private Error(int numeroLinea, int posicionInicial, int posicionFinal, string lexema, string falla, string causa, string solucion, TipoError tipo, CategoriaError categoria)
        {
            this.NumeroLinea = numeroLinea;
            this.PosicionInicial = posicionInicial;
            this.PosicionFinal = posicionFinal;
            this.Lexema = lexema;
            this.Falla = falla;
            this.Causa = causa;
            this.Solucion = solucion;
            this.Tipo = tipo;
            this.Categoria = categoria;
        }

        public int NumeroLinea { get => numeroLinea; set => numeroLinea = value; }
        public int PosicionInicial { get => posicionInicial; set => posicionInicial = value; }
        public int PosicionFinal { get => posicionFinal; set => posicionFinal = value; }
        public string Lexema { get => lexema; set => lexema = value; }
        public string Falla { get => falla; set => falla = value; }
        public string Causa { get => causa; set => causa = value; }
        public string Solucion { get => solucion; set => solucion = value; }
        public TipoError Tipo { get => tipo; set => tipo = value; }
        public CategoriaError Categoria { get => categoria; set => categoria = value; }

        public static Error CREAR_ERROR_LEXICO_STOPPER(
           int numeroLinea,
           int posicionInicial,
           string lexema,
           string falla,
           string causa,
           string solucion)

        {
            return new Error(numeroLinea, posicionInicial, posicionInicial + lexema.Length, lexema, falla, causa, solucion, TipoError.LEXICO, CategoriaError.STOPPER);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(".................................INICIO..............................................").Append("\r\n");
            sb.Append("Tipo: ").Append(Tipo).Append("\r\n");
            sb.Append("Categoria : ").Append(Categoria).Append("\r\n");
            sb.Append("Lexema: ").Append(Lexema).Append("\r\n");
            sb.Append("Numero Linea: ").Append(NumeroLinea).Append("\r\n");
            sb.Append("Posicion Inicial: ").Append(PosicionInicial).Append("\r\n");
            sb.Append("Posicion Final: ").Append(PosicionFinal).Append("\r\n");
            sb.Append("Falla: ").Append(Falla).Append("\r\n");
            sb.Append("Causa: ").Append(Causa).Append("\r\n");
            sb.Append("Solucion: ").Append(Solucion).Append("\r\n");
            sb.Append("..................................fIN................................................").Append("\r\n");

            return sb.ToString();
        }
    }
}
