using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Translator.LexicalAnalysis;

namespace Translator.AnalizadorSintactico
{
    public class SintacticalAnalyzer
    {
        private LexicalAnalyzer AnaLex = new LexicalAnalyzer();
        private  Componente;
        private string falla = "";
        private string causa = "";
        private string solucion = "";

        private bool EsCategoriaValida(CategoriaGramatical categoria)
        {
            return categoria.Equals(Componente.Categoria);
        }
    }
}
