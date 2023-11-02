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
        int recorrido = 0;
        private AnalizadorLexico lexico = new AnalizadorLexico();
        private AnalizadorLexicoNumero lexicoNumero = new AnalizadorLexicoNumero();
        private AnalizadorLexicoPunto lexicoPunto = new AnalizadorLexicoPunto();
        private ComponenteLexico Componente;
        private string falla = "";
        private string causa = "";
        private string solucion = "";
        private string resultado = "";
        private Stack<CategoriaGramatical> translate = new Stack<CategoriaGramatical>();
        private Stack<CategoriaGramatical> auxiliar = new Stack<CategoriaGramatical>();

        public AnalisisSintactico(int recorridoLexico)
        {
            recorrido = recorridoLexico;
            switch (recorridoLexico)
            {
                case 0:
                    lexico = new AnalizadorLexico();
                    break;
                case 1:
                    lexicoNumero = new AnalizadorLexicoNumero();
                    break;
                case 2:
                    lexicoPunto = new AnalizadorLexicoPunto();
                    break;
            }

        }

        public void Analizar()
        {

            DevolverSiguienteComponenteLexico();
            translate.Push(Componente.Categoria);
            Entrada();
            if (ManejadorErrores.ObtenerManejadorErrores().HayErroresAnalisis())
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
            switch (recorrido)
            {
                case 0:
                    Componente = lexico.DevolverSiguienteComponente();
                    break;
                case 1:
                    Componente = lexicoPunto.DevolverSiguienteComponente();
                    break;
                case 2:
                    Componente = lexicoNumero.DevolverSiguienteComponente();
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
                    resultado += Util.Texto.texto[Convert.ToInt32(caracter)];
                }
            }
            if (op == 1)
            {
                for (int i = 0; i < total - 1; i++)
                {
                    CategoriaGramatical caracter = auxiliar.Pop();
                    resultado += Util.Punto.puntos[Convert.ToInt32(caracter)];
                    resultado += "  ";
                }
            }
            if (op == 2)
            {
                for (int i = 0; i < total - 1; i++)
                {
                    CategoriaGramatical caracter = auxiliar.Pop();
                    resultado += Util.Numero.numeros[Convert.ToInt32(caracter)];
                    resultado += " ";
                }
            }

            return resultado;
        }


    }
}