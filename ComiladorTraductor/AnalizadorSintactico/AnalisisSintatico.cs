using ComiladorTraductor.AnalizadorLexico;
using ComiladorTraductor.ManejadorErrores;
using ComiladorTraductor.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiladorTraductor.AnalizadorSintactico
{
    public class AnalisisSintatico
    {
        private int traductor;
        private ComponenteLexico Componente;
        private AnalizadorLexicoTexto AnalyzerText;
        private AnalizadorLexicoNumero AnalyzerNum;
        private AnalizadorLexicoPunto AnalyzerPoint;
        private string resultado = "";
        private Stack<CategoriaGramatical> principal = new Stack<CategoriaGramatical>();
        private Stack<CategoriaGramatical> secundario = new Stack<CategoriaGramatical>();

        public AnalisisSintatico(int constructor)
        {
            traductor = constructor;
            InitializeLexicalAnalyzer(constructor);
        }

        private void InitializeLexicalAnalyzer(int constructor)
        {
            switch (constructor)
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
            principal.Push(Componente.Categoria);
            IngresoDtos();

            if (ManejadorTodosErrores.ObtenerManejadorDeErrores().HayErroresAnalisis())
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

        private void IngresoDtos()
        {
            while (!CategoriaGramatical.FIN_ARCHIVO.Equals(Componente.Categoria))
            {
                DevolverSiguienteComponenteLexico();
                principal.Push(Componente.Categoria);
            }
        }

        private void DevolverSiguienteComponenteLexico()
        {
            switch (traductor)
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

        public string Traducir(int numeroTraducion)
        {
            string traduccion = "";

            int n = principal.Count;

            while (secundario.Count < n)
            {
                secundario.Push(principal.Pop());
            }

            switch (numeroTraducion)
            {
                case 0: // Traducción de texto
                    traduccion = TranslateText(n);
                    break;
                case 1: // Traducción de puntos
                    traduccion = TranslatePuntos(n);
                    break;
                case 2: // Traducción de números
                    traduccion = TranslateNumeros(n);
                    break;
            }

            return traduccion;
        }

        private string TranslateText(int n)
        {
            StringBuilder resultBuilder = new StringBuilder();

            for (int i = 0; i < n - 1; i++)
            {
                CategoriaGramatical categoria = secundario.Pop();
                resultBuilder.Append(Texto.texto[(int)categoria]);
            }

            return resultBuilder.ToString();
        }

        private string TranslatePuntos(int n)
        {
            StringBuilder resultBuilder = new StringBuilder();

            for (int i = 0; i < n - 1; i++)
            {
                CategoriaGramatical categoria = secundario.Pop();

                if (CategoriaGramatical.FIN_LINEA.Equals(i))
                {
                    resultBuilder.Append(Puntos.puntos[(int)categoria]);
                    resultBuilder.AppendLine();
                }
                else
                {
                    resultBuilder.Append(Puntos.puntos[(int)categoria]);
                    resultBuilder.Append("  ");
                }
            }

            return resultBuilder.ToString();
        }

        private string TranslateNumeros(int n)
        {
            StringBuilder resultBuilder = new StringBuilder();

            for (int i = 0; i < n - 1; i++)
            {
                CategoriaGramatical categoria = secundario.Pop();

                if (CategoriaGramatical.FIN_LINEA.Equals(i))
                {
                    resultBuilder.Append(Numero.numeros[(int)categoria]);
                    resultBuilder.AppendLine();
                }
                else
                {
                    resultBuilder.Append(Numero.numeros[(int)categoria]);
                    resultBuilder.Append(" ");
                }
            }

            return resultBuilder.ToString();
        }
    }
}

