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

            int total = principal.Count;

            while (secundario.Count < total)
            {
                secundario.Push(principal.Pop());
            }

            switch (numeroTraducion)
            {
                case 0: // Traducción de texto
                    traduccion = TranslateText(total);
                    break;
                case 1: // Traducción de puntos
                    traduccion = TranslatePuntos(total);
                    break;
                case 2: // Traducción de números
                    traduccion = TranslateNumeros(total);
                    break;
            }

            return traduccion;
        }

        private string TranslateText(int total)
        {
            StringBuilder resultBuilder = new StringBuilder();

            for (int i = 0; i < total - 1; i++)
            {
                CategoriaGramatical categoria = secundario.Pop();
                resultBuilder.Append(Texto.texto[Convert.ToInt32(categoria)]);
            }

            return resultBuilder.ToString();
        }

        private string TranslatePuntos(int total)
        {
            StringBuilder resultBuilder = new StringBuilder();

            for (int i = 0; i < total - 1; i++)
            {
                CategoriaGramatical categoria = secundario.Pop();

                if (CategoriaGramatical.FIN_LINEA.Equals(i))
                {
                    resultBuilder.Append(Puntos.puntos[Convert.ToInt32(categoria)]);
                    resultBuilder.AppendLine();
                }
                else
                {
                    resultBuilder.Append(Puntos.puntos[Convert.ToInt32(categoria)]);
                    resultBuilder.Append("  ");
                }
            }

            return resultBuilder.ToString();
        }

        private string TranslateNumeros(int total)
        {
            StringBuilder resultBuilder = new StringBuilder();

            for (int i = 0; i < total - 1; i++)
            {
                CategoriaGramatical categoria = secundario.Pop();

                if (CategoriaGramatical.FIN_LINEA.Equals(i))
                {
                    resultBuilder.Append(Numero.numeros[Convert.ToInt32(categoria)]);
                    resultBuilder.AppendLine();
                }
                else
                {
                    resultBuilder.Append(Numero.numeros[Convert.ToInt32(categoria)]);
                    resultBuilder.Append(" ");
                }
            }

            return resultBuilder.ToString();
        }
    }
}

