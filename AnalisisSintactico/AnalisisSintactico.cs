using Compilador.AnalisisLexico;
using Compilador.GestorErrores;
using Compilador.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compilador.AnalisisSintactico
{
    public class AnalisisSintactico
    {

        public class AnalizadorSintatico
        {
            private int language = 0; // Variable que almacena el tipo de lenguaje (0: Texto, 1: Puntos, 2: Números)
            private ComponenteLexico Componente; // Componente léxico actual
            private AnalizadorLexico AnalyzerText; // Analizador léxico para texto
            private AnalizadorLexicoNumero AnalyzerNum; // Analizador léxico para números
            private AnalizadorLexicoPunto AnalyzerPoint; // Analizador léxico para puntos
            private string resultado = ""; // Mensaje de resultado
            private Stack<CategoriaGramatical> translate = new Stack<CategoriaGramatical>(); // Pila para categorías gramaticales
            private Stack<CategoriaGramatical> auxiliar = new Stack<CategoriaGramatical>(); // Pila auxiliar para traducción

            public AnalizadorSintatico(int lang)
            {
                // Constructor que inicializa el analizador sintáctico según el lenguaje seleccionado.
                language = lang;
                switch (lang)
                {
                    case 0:
                        AnalyzerText = new AnalizadorLexico();
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
                // Método principal que inicia el análisis.
                DevolverSiguienteComponenteLexico(); // Obtiene el primer componente léxico
                translate.Push(Componente.Categoria); // Agrega la categoría del primer componente a la pila
                Entrada(); // Inicia el análisis sintáctico
                resultado = ManejarErrores(); // Maneja los errores y obtiene el mensaje de resultado
            }

            private string ManejarErrores()
            {
                // Método que maneja los errores de análisis y devuelve un mensaje de resultado.
                if (ManejadorErrores.ObtenerManejadorErrores().HayErroresAnalisis())
                {
                    return "El proceso de compilación terminó con errores.\r\n";
                }
                else if (!CategoriaGramatical.FIN_ARCHIVO.Equals(Componente.Categoria))
                {
                    return "Aunque el programa no tiene errores, faltaron componentes por evaluar.\r\n";
                }
                else
                {
                    return "El programa se encuentra bien escrito.\r\n";
                }
            }

            public string Traducir(int op)
            {
                // Método que traduce las categorías gramaticales al formato seleccionado.
                Dictionary<int, string[]> traducciones = new Dictionary<int, string[]>
            {
                { 0, Texto.texto }, // Traducción para texto
                { 1, Punto.puntos }, // Traducción para puntos
                { 2, Numero.numeros } // Traducción para números
            };

                string resultado = "";
                int total = translate.Count;

                for (int i = 0; i < total - 1; i++)
                {
                    CategoriaGramatical caracter = auxiliar.Pop();
                    resultado += traducciones[op][Convert.ToInt32(caracter)];

                    if (op != 2)
                        resultado += (op == 1) ? "  " : " ";
                }

                return resultado;
            }

            private void DevolverSiguienteComponenteLexico()
            {
                // Método que obtiene el siguiente componente léxico según el lenguaje.
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

            private void Entrada()
            {
                // Método que representa la regla de la gramática y realiza el análisis.
                if (!Componente.Categoria.Equals(CategoriaGramatical.FIN_ARCHIVO))
                {
                    DevolverSiguienteComponenteLexico();
                    translate.Push(Componente.Categoria);
                    Entrada(); // Llamada recursiva para analizar el siguiente componente
                }
            }
        }


    }
}