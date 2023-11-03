using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompiladoExtraClase.AnalizadorLexico;
using CompiladoExtraClase.ErrorManagement;
using CompiladoExtraClase.LexicalAnalysis;
using CompiladoExtraClase.Util;


namespace CompiladoExtraClase.AnalisisSintactico
{
    public class AnalizadorSintatico
    {
        int language = 0;
        private ComponenteLexico Componente;
        AnalizadorLexicoTexto AnalyzerText;
        AnalizadorLexicoNumero AnalyzerNum;
        AnalizadorLexicoPunto AnalyzerPoint;
        private string falla = "";
        private string causa = "";
        private string solucion = "";
        private string resultado = "";
        private Stack<CategoriaGramatical> translate = new Stack<CategoriaGramatical>();
        private Stack<CategoriaGramatical> auxiliar = new Stack<CategoriaGramatical>();

        public AnalizadorSintatico(int lang)
        {
            language = lang;
            switch (lang)
            {
                case 0:
                    AnalyzerText = new AnalizadorLexicoTexto();
                    break;
                case 1:
                    AnalyzerPoint = new AnalizadorLexicoPunto();
                    break;
                case 2:
                    AnalyzerNum = new AnalizadorLexicoNumero();
                    break;
            }

        }


        public void Analizar()
        {

            DevolverSiguienteComponenteLexico();
            translate.Push(Componente.Categoria);
            Entrada();
            if (ManejadorErrores.ObtenerManejadorDeErrores().HayErroresAnalisis())
            {
                resultado = "El proceso de compilación terminó con errores.\r\n";
            }
            else if (!CategoriaGramatical.FIN_ARCHIVO.Equals(Componente.Categoria))
            {
                resultado = "Aunque el programa no tiene errores, faltaron componentes por evaluar.\r\n";
            }
            else
            {
                resultado = "El programa se encuentra bien escrito.\r\n";
            }

        }

        public void Entrada()
        {
            if (!Componente.Categoria.Equals(CategoriaGramatical.FIN_ARCHIVO))
            {
                DevolverSiguienteComponenteLexico();
                translate.Push(Componente.Categoria);
                Entrada();
            }

        }


        private void DevolverSiguienteComponenteLexico()
        {
            switch (language)
            {
                case 0:
                    Componente = AnalyzerText.DevolverSiguienteComponente();
                    break;
                case 1:
                    Componente = AnalyzerPoint.DevolverSiguienteComponente();
                    break;
                case 2:
                    Componente = AnalyzerNum.DevolverSiguienteComponente();
                    break;
            }
        }

        public string Traducir(int op)
        {
            string resultado = "";
            int total = translate.Count;

            for (int i = 0; i < total; i++)
            {
                auxiliar.Push(translate.Pop());
            }

            if (op == 0)
            {

                for (int i = 0; i < total - 1; i++)
                {
                    CategoriaGramatical caracter = auxiliar.Pop();
                    resultado += Texto.texto[Convert.ToInt32(caracter)];
                }

            }
            if (op == 1)
            {
                for (int i = 0; i < total - 1; i++)
                {
                    CategoriaGramatical caracter = auxiliar.Pop();
                    resultado += Puntos.puntos[Convert.ToInt32(caracter)];
                    resultado += "  ";
                }
            }
            if (op == 2)
            {
                for (int i = 0; i < total - 1; i++)
                {
                    CategoriaGramatical caracter = auxiliar.Pop();
                    resultado += Numero.numeros[Convert.ToInt32(caracter)];
                    resultado += " ";
                }
            }

            return resultado;
        }
    }

}