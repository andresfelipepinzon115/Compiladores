using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compilador.AnalisisLexico
{
    public class ComponenteLexico
    {
        private int numeroLinea;
        private int posicionInicial;
        private int posicionFinal;
        private String lexema;
        private CategoriaGramatical categoria;
        private TipoComponente tipo;

        private ComponenteLexico(int numeroLinea, int posicionInicial, int posicionFinal, string lexema, CategoriaGramatical categoria, TipoComponente tipo)
        {
            this.NumeroLinea = numeroLinea;
            this.PosicionInicial = posicionInicial;
            this.PosicionFinal = posicionFinal;
            this.Lexema = lexema;
            this.Categoria = categoria;
            this.Tipo = tipo;
        }

        public int NumeroLinea { get => numeroLinea; set => numeroLinea = value; }
        public int PosicionInicial { get => posicionInicial; set => posicionInicial = value; }
        public int PosicionFinal { get => posicionFinal; set => posicionFinal = value; }
        public string Lexema { get => lexema; set => lexema = value; }
        public CategoriaGramatical Categoria { get => categoria; set => categoria = value; }
        internal TipoComponente Tipo { get => tipo; set => tipo = value; }

        public static ComponenteLexico CREAR_SIMBOLO(int numeroLinea, int posicionInicial, string lexema, CategoriaGramatical categoria, TipoComponente tipo)
        {
            return new ComponenteLexico(numeroLinea, posicionInicial, posicionInicial + lexema.Length, lexema, categoria, TipoComponente.SIMBOLO);
        }
        public static ComponenteLexico CREAR_

    } 


}
        