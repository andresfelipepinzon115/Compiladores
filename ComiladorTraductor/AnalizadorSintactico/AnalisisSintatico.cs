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
        // Variables miembro
        int traductor = 0; // Tipo de análisis léxico (0: Texto, 1: Punto, 2: Número)
        private ComponenteLexico Componente; // Componente léxico actual
        AnalizadorLexicoTexto AnalyzerText; // Analizador léxico para texto
        AnalizadorLexicoNumero AnalyzerNum; // Analizador léxico para números
        AnalizadorLexicoPunto AnalyzerPoint; // Analizador léxico para puntos
        private string falla = ""; // Descripción de una falla (sin uso aparente en el código)
        private string causa = ""; // Descripción de la causa de una falla (sin uso aparente en el código)
        private string solucion = ""; // Descripción de la solución de una falla (sin uso aparente en el código)
        private string resultado = ""; // Resultado del análisis
        private Stack<CategoriaGramatical> translate = new Stack<CategoriaGramatical>(); // Pila para almacenar categorías gramaticales
        private Stack<CategoriaGramatical> auxiliar = new Stack<CategoriaGramatical>(); // Pila auxiliar

        // Constructor
        public AnalisisSintatico(int constructor)
        {
            traductor = constructor;

            // Inicializar el analizador léxico según el tipo de análisis
            switch (constructor)
            {
                case 0:
                    AnalyzerText = new AnalizadorLexicoTexto(); // Analizador de texto
                    break;
                case 1:
                    AnalyzerPoint = new AnalizadorLexicoPunto(); // Analizador de puntos
                    break;
                case 2:
                    AnalyzerNum = new AnalizadorLexicoNumero(); // Analizador de números
                    break;
            }
        }

        // Método para realizar el análisis sintáctico
        public void Analizar()
        {
            DevolverSiguienteComponenteLexico(); // Obtener el primer componente léxico
            translate.Push(Componente.Categoria); // Almacenar la categoría del primer componente
            IngresoDtos(); // Procesar componentes léxicos

            // Verificar si hay errores de análisis
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

        // Método para procesar componentes léxicos
        public void IngresoDtos()
        {
            while (!Componente.Categoria.Equals(CategoriaGramatical.FIN_ARCHIVO))
            {
                DevolverSiguienteComponenteLexico(); // Obtener el siguiente componente léxico
                translate.Push(Componente.Categoria); // Almacenar la categoría en la pila
            }
        }

        // Método para obtener el siguiente componente léxico
        private void DevolverSiguienteComponenteLexico()
        {
            // Obtener el siguiente componente léxico según el tipo de análisis
            switch (traductor)
            {
                case 0:
                    Componente = AnalyzerText.DevolverSiguienteComponente(); // Componente de texto
                    break;
                case 1:
                    Componente = AnalyzerPoint.DevolverSiguienteComponente(); // Componente de puntos
                    break;
                case 2:
                    Componente = AnalyzerNum.DevolverSiguienteComponente(); // Componente de números
                    break;
            }
        }

        // Método para traducir las categorías gramaticales
        /// <summary>
        /// Realiza la traducción de una secuencia de categorías gramaticales en un tipo de contenido específico.
        /// </summary>
        /// <param name="numeroTraducion">El número que representa el tipo de traducción a realizar:
        /// 0 para traducción de texto, 1 para traducción de puntos y 2 para traducción de números.</param>
        /// <returns>Una cadena de texto traducida según la opción especificada.</returns>
        public string Traducir(int numeroTraducion)
        {
            // Inicializar una cadena vacía para almacenar el resultado de la traducción.
            string resultado = "";

            // Obtener el número total de categorías gramaticales en la lista 'translate'.
            int total = translate.Count;

            // Volcar las categorías gramaticales a una pila auxiliar (reversa la lista original).
            for (int i = 0; i < total; i++)
            {
                auxiliar.Push(translate.Pop());
            }

            // Realizar la traducción según la opción especificada.
            switch (numeroTraducion)
            {
                case 0: // Traducción de texto
                    for (int i = 0; i < total - 1; i++)
                    {
                        // Obtener una categoría gramatical de la pila auxiliar.
                        CategoriaGramatical caracter = auxiliar.Pop();
                        // Traducir la categoría a su representación en texto y agregar al resultado.
                        resultado += Texto.texto[Convert.ToInt32(caracter)];
                    }
                    break;
                case 1: // Traducción de puntos
                    for (int i = 0; i < total - 1; i++)
                    {
                        // Obtener una categoría gramatical de la pila auxiliar.
                        CategoriaGramatical caracter = auxiliar.Pop();




                        if (CategoriaGramatical.FIN_LINEA.Equals(i))
                        {

                            resultado += Puntos.puntos[Convert.ToInt32(caracter)];
                            resultado += ("\n");

                        }
                        else
                        {
                            resultado += Puntos.puntos[Convert.ToInt32(caracter)];
                            // Agregar un espacio después de cada número traducido.
                            resultado += "  ";

                        }
                    }
                    break;
                case 2: // Traducción de números
                    for (int i = 0; i < total - 1; i++)
                    {
                        // Obtener una categoría gramatical de la pila auxiliar.
                        CategoriaGramatical caracter = auxiliar.Pop();
                       
                       
                        
                        
                        if (CategoriaGramatical.FIN_LINEA.Equals(i))
                        {

                            resultado += Numero.numeros[Convert.ToInt32(caracter)];
                            resultado += ("\n");
                            
                        }
                        else
                        {
                            resultado += Numero.numeros[Convert.ToInt32(caracter)];
                            // Agregar un espacio después de cada número traducido.
                            resultado += " ";
                         
                        }
                    }
                    break;
            }

            // Devolver la cadena de texto traducida.
            return resultado;
        }
    }
}
