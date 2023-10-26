using Compilador.Util;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compilador.AnalisisLexico
{
    internal class AnalizadorLexicoPunto
    {


        private int numeroLineaActual = 0;
        private string contenidoLineaActual = "";
        private int puntero = 0;
        private string estadoActual = "";
        private String caracterActual;
        public CategoriaGramatical categoria;
        private string lexema = "";
        private int posicionInicial = 0;
        private int posicionFinal = 0;
        private bool continuarAnalisis = false;
        private String resultado = "";
        private StreamWriter textOut;

        public AnalizadorLexicoPunto(StreamWriter textOut)
        {
            this.textOut = textOut;
            CargarNuevaLinea();
        }

        private void CargarNuevaLinea()
        {
            if ("@EOF@".Equals(contenidoLineaActual))
            {
                numeroLineaActual = numeroLineaActual + 1;
                contenidoLineaActual = Cache.DataCache.ObtenerLinea(numeroLineaActual).Contenido;
                numeroLineaActual = Cache.DataCache.ObtenerLinea(numeroLineaActual).NumeroLinea;
                puntero = 1;
            }

        }
        private void LeerSiguienteCaracter()
        {
            if ("@EOF@".Equals(contenidoLineaActual))
            {
                caracterActual = "@EOF@";
            }
            else if (puntero > contenidoLineaActual.Length)
            {
                caracterActual = "@FL@";
            }
            else
            {
                caracterActual = contenidoLineaActual.Substring(puntero - 1, 1);
                puntero = puntero + 1;

            }


        }
        private void Concatenar()
        {
            lexema = lexema + caracterActual;
        }
        private void DevolverPuntero()
        {
            puntero = puntero - 1;

        }
        private void Resetear()
        {
            estadoActual = "q0";
            lexema = "";
            caracterActual = "";
            categoria = CategoriaGramatical.DEFECTO;
            continuarAnalisis = true;
        }
        public String DevolverSiguienteComponente()
        {
            Resetear();

            while (continuarAnalisis)
            {
                if ("q0".Equals(estadoActual))
                {
                    ProcesarEstado0();
                }
                else if ("q1".Equals(estadoActual))
                {
                    ProcesarEstado1();
                }
                else if ("q2".Equals(estadoActual))
                {
                    ProcesarEstado2();
                }
                else if ("q3".Equals(estadoActual))
                {
                    ProcesarEstado3();
                }
                else if ("q4".Equals(estadoActual))
                {
                    ProcesarEstado4();
                }
                else if ("q5".Equals(estadoActual))
                {
                    ProcesarEstado5();
                }
                else if ("q6".Equals(estadoActual))
                {
                    ProcesarEstado6();
                }
                else if ("q7".Equals(estadoActual))
                {
                    ProcesarEstado8();
                }
                else if ("q9".Equals(estadoActual))
                {
                    ProcesarEstado9();
                }
                else if ("q10".Equals(estadoActual))
                {
                    ProcesarEstado10();
                }


            }
            return lexema;
        }

        public void ProcesarEstado0()
        {
            DevorarEspaciosBlanco();
            if (UtilTexto.EsPunto(caracterActual))
            {
                estadoActual = "q1";
            }
        }
        public void ProcesarEstado1()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (UtilTexto.EsPunto(caracterActual))
            {
                estadoActual = "q2";
            }
            else if (UtilTexto.EsEspacioEnBlanco(caracterActual))
            {
                estadoActual = "q90";
            }
        }
        public void ProcesarEstado2()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (UtilTexto.EsPunto(caracterActual))
            {
                estadoActual = "q3";
            }
            else if (UtilTexto.EsEspacioEnBlanco(caracterActual))
            {
                estadoActual = "q80";
            }
        }
        public void ProcesarEstado3()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (UtilTexto.EsPunto(caracterActual))
            {
                estadoActual = "q4";
            }
            else if (UtilTexto.EsEspacioEnBlanco(caracterActual))
            {
                estadoActual = "q70";
            }
        }
        public void ProcesarEstado4()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (UtilTexto.EsPunto(caracterActual))
            {
                estadoActual = "q5";
            }
            else if (UtilTexto.EsEspacioEnBlanco(caracterActual))
            {
                estadoActual = "q60";
            }
        }
        public void ProcesarEstado5()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (UtilTexto.EsPunto(caracterActual))
            {
                estadoActual = "q6";
            }
            else if (UtilTexto.EsEspacioEnBlanco(caracterActual))
            {
                estadoActual = "q50";
            }
        }
        public void ProcesarEstado6()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (UtilTexto.EsPunto(caracterActual))
            {
                estadoActual = "q7";
            }
            else if (UtilTexto.EsEspacioEnBlanco(caracterActual))
            {
                estadoActual = "q40";
            }
        }

        public void ProcesarEstado7()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (UtilTexto.EsPunto(caracterActual))
            {
                estadoActual = "q8";
            }
            else if (UtilTexto.EsEspacioEnBlanco(caracterActual))
            {
                estadoActual = "q30";
            }
        }
        public void ProcesarEstado8()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (UtilTexto.EsPunto(caracterActual))
            {
                estadoActual = "q9";
            }
            else if (UtilTexto.EsEspacioEnBlanco(caracterActual))
            {
                estadoActual = "q20";
            }
        }
        public void ProcesarEstado9()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (UtilTexto.EsEspacioEnBlanco(caracterActual))
            {
                estadoActual = "q10";
            }
        }
        public void ProcesarEstado10()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (UtilTexto.EsPunto(caracterActual))
            {
                estadoActual = "q11";
            }
            
        }
        public void ProcesarEstado11()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (UtilTexto.EsPunto(caracterActual))
            {
                estadoActual = "q12";
            }
            else
            {
                estadoActual = "102";
            }

        }
        public void ProcesarEstado102()
        {
            DevolverPuntero();
            categoria = CategoriaGramatical.EsGionBajo;
            continuarAnalisis = false; 

        }
        public string GetResultado()
        {
            return resultado;
        }


        private void DevorarEspaciosBlanco()
        {
            while (" ".Equals(caracterActual) || "\t".Equals(caracterActual))
            {
                LeerSiguienteCaracter();
            }
        }
        private string FormarComponeneteLexico()
        {
            posicionInicial = puntero - lexema.Length;
            posicionFinal = puntero - 1;

            // Construir una cadena que contenga la información
            CategoriaGramatical informacion = $"categoria: {categoria}\n";
            informacion += $"Lexema: {lexema}\n";
            informacion += $"Numero linea: {numeroLineaActual}\n";
            informacion += $"Posicion final: {posicionFinal}";

            // Devolver la cadena construida
            return informacion;
            Resetear();
            LeerSiguienteCaracter();
        }


    }

}


