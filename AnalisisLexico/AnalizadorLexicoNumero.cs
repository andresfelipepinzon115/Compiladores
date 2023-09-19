using Compilador.Util;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compilador.AnalisisLexico
{
    public class AnalizadorLexico
    {
        private int numeroLineaActual = 0;
        private string contenidoLineaActual = "";
        private int puntero = 0;

        private string estadoActual = "";
        private String caracterActual;
        public string categoria = "";
        private string lexema = "";
        private int posicionInicial = 0;
        private int posicionFinal = 0;
        private bool continuarAnalisis = false;
        private String resultado = "";
        private StreamWriter textOut;

        public AnalizadorLexico(StreamWriter textOut)
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
        private void DevolverPuntero()
        {
            puntero = puntero - 1;

        }
        private void Resetear()
        {
            estadoActual = "q0";
            lexema = "";
            caracterActual = "";
            categoria = "";
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

                }else if("q1".Equals(estadoActual)
                {
                    procesarEstado1()
                }else if ("q11".Equals(estadoActual))
                {
                    ProcesarEstado11();
                }else if ("21".Equals(estadoActual))
                {
                    ProcesarEstado21();
                }else if ("31".Equals(estadoActual))
                {
                    ProcesarEstado31();
                }else if ("41".Equals(estadoActual))
                {
                    ProcesarEstado41();
                }else if ("51".Equals(estadoActual))
                {
                    ProcesarEstado51();
                }else if ("61".Equals(estadoActual))
                {
                    ProcesarEstado61();
                }else if ("71".Equals(estadoActual))
                {
                    ProcesarEstado71();
                }else if ("81".Equals(estadoActual))
                {
                    ProcesarEstado81();
                }

            }
            return lexema;
        }

        public string ProcesarEstado0()
        {
            DevorarEspaciosBlanco();
            while (!"@EOF@".Equals(caracterActual))
            {
                if (UtilNumero.EsNumero1(caracterActual))
                {
                    estadoActual = "q1";
                    resultado = FormarComponeneteLexico();

                    Console.WriteLine("Resultado: " + resultado);
                }
                else if (UtilNumero.EsNumero2(caracterActual))
                {
                    estadoActual = "q11";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilNumero.EsNumero3(caracterActual))
                {
                    estadoActual = "q21";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilNumero.EsNumero4(caracterActual))
                {
                    estadoActual = "q31";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilNumero.EsNumero5(caracterActual))
                {
                    estadoActual = "q41";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilNumero.EsNumero6(caracterActual))
                {
                    estadoActual = "q51";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilNumero.EsNumero7(caracterActual))
                {
                    estadoActual = "q61";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilNumero.EsNumero8(caracterActual))
                {
                    estadoActual = "q71";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilNumero.EsNumero9(caracterActual))
                {
                    estadoActual = "q81";
                    resultado = FormarComponeneteLexico();
                }
               
                else if ("@EOF@".Equals(caracterActual))
                {
                    categoria = "FIN ARCHIVO";
                    resultado = FormarComponeneteLexico();
                    continuarAnalisis = false;
                }
                else if ("@FL@".Equals(caracterActual))
                {
                    CargarNuevaLinea();
                }

            }
            return resultado;
        }
        private void procesarEstado1()
        {
            concatenar();
            LeerSiguienteCaracter();
            if (UtilNumero.EsNumero1(caracterActual))
            {
                estadoActual = "q2";
                resultado = FormarComponeneteLexico();            
            }
            if (UtilNumero.EsNumero2(caracterActual))
            {
                estadoActual = "q3";
                resultado = FormarComponeneteLexico();
            }
            if (UtilNumero.EsNumero3(caracterActual))
            {
                estadoActual = "q4";
                resultado = FormarComponeneteLexico();
            }
            if (UtilNumero.EsNumero4(caracterActual))
            {
                estadoActual = "q5";
                resultado = FormarComponeneteLexico();
            }
            if (UtilNumero.EsNumero5(caracterActual))
            {
                estadoActual = "q6";
                resultado = FormarComponeneteLexico();
            }
            if (UtilNumero.EsNumero6(caracterActual))
            {
                estadoActual = "q7";
                resultado = FormarComponeneteLexico();
            }
            if (UtilNumero.EsNumero7(caracterActual))
            {
                estadoActual = "q8";
                resultado = FormarComponeneteLexico();
            }
            if (UtilNumero.EsNumero8(caracterActual))
            {
                estadoActual = "q9";
                resultado = FormarComponeneteLexico();
            }
            if (UtilNumero.EsNumero9(caracterActual))
            {
                estadoActual = "q10";
                resultado = FormarComponeneteLexico();
            }

        }
        public string ProcesarEstado11()
        {
            concatenar();
            LeerSiguienteCaracter();
            DevorarEspaciosBlanco();
            while (!"@EOF@".Equals(caracterActual))
            {
                if (UtilNumero.EsNumero1(caracterActual))
                {
                    estadoActual = "q12";
                    resultado = FormarComponeneteLexico();

                    Console.WriteLine("Resultado: " + resultado);
                }
                else if (UtilNumero.EsNumero2(caracterActual))
                {
                    estadoActual = "q13";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilNumero.EsNumero3(caracterActual))
                {
                    estadoActual = "q14";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilNumero.EsNumero4(caracterActual))
                {
                    estadoActual = "q15";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilNumero.EsNumero5(caracterActual))
                {
                    estadoActual = "q16";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilNumero.EsNumero6(caracterActual))
                {
                    estadoActual = "q17";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilNumero.EsNumero7(caracterActual))
                {
                    estadoActual = "q18";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilNumero.EsNumero8(caracterActual))
                {
                    estadoActual = "q19";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilNumero.EsNumero9(caracterActual))
                {
                    estadoActual = "q20";
                    resultado = FormarComponeneteLexico();
                }

            }
            return resultado;
        }

        public string ProcesarEstado21()
        {
            concatenar();
            LeerSiguienteCaracter();
            DevorarEspaciosBlanco();
            while (!"@EOF@".Equals(caracterActual))
            {
                if (UtilNumero.EsNumero1(caracterActual))
                {
                    estadoActual = "q22";
                    resultado = FormarComponeneteLexico();

                    Console.WriteLine("Resultado: " + resultado);
                }
                else if (UtilNumero.EsNumero2(caracterActual))
                {
                    estadoActual = "q23";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilNumero.EsNumero3(caracterActual))
                {
                    estadoActual = "q24";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilNumero.EsNumero4(caracterActual))
                {
                    estadoActual = "q25";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilNumero.EsNumero5(caracterActual))
                {
                    estadoActual = "q26";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilNumero.EsNumero6(caracterActual))
                {
                    estadoActual = "q27";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilNumero.EsNumero7(caracterActual))
                {
                    estadoActual = "q28";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilNumero.EsNumero8(caracterActual))
                {
                    estadoActual = "q29";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilNumero.EsNumero9(caracterActual))
                {
                    estadoActual = "q30";
                    resultado = FormarComponeneteLexico();
                }

            }
            return resultado;
        }

        public string ProcesarEstado31()
        {
            concatenar();
            LeerSiguienteCaracter();
            DevorarEspaciosBlanco();
            while (!"@EOF@".Equals(caracterActual))
            {
                if (UtilNumero.EsNumero1(caracterActual))
                {
                    estadoActual = "q32";
                    resultado = FormarComponeneteLexico();

                    Console.WriteLine("Resultado: " + resultado);
                }
                else if (UtilNumero.EsNumero2(caracterActual))
                {
                    estadoActual = "q33";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilNumero.EsNumero3(caracterActual))
                {
                    estadoActual = "q34";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilNumero.EsNumero4(caracterActual))
                {
                    estadoActual = "q35";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilNumero.EsNumero5(caracterActual))
                {
                    estadoActual = "q36";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilNumero.EsNumero6(caracterActual))
                {
                    estadoActual = "q37";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilNumero.EsNumero7(caracterActual))
                {
                    estadoActual = "q38";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilNumero.EsNumero8(caracterActual))
                {
                    estadoActual = "q39";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilNumero.EsNumero9(caracterActual))
                {
                    estadoActual = "q40";
                    resultado = FormarComponeneteLexico();
                }

            }
            return resultado;
        }

        public string ProcesarEstado41()
        {
            concatenar();
            LeerSiguienteCaracter();
            DevorarEspaciosBlanco();
            while (!"@EOF@".Equals(caracterActual))
            {
                if (UtilNumero.EsNumero1(caracterActual))
                {
                    estadoActual = "q42";
                    resultado = FormarComponeneteLexico();

                    Console.WriteLine("Resultado: " + resultado);
                }
                else if (UtilNumero.EsNumero2(caracterActual))
                {
                    estadoActual = "q43";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilNumero.EsNumero3(caracterActual))
                {
                    estadoActual = "q44";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilNumero.EsNumero4(caracterActual))
                {
                    estadoActual = "q45";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilNumero.EsNumero5(caracterActual))
                {
                    estadoActual = "q46";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilNumero.EsNumero6(caracterActual))
                {
                    estadoActual = "q47";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilNumero.EsNumero7(caracterActual))
                {
                    estadoActual = "q48";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilNumero.EsNumero8(caracterActual))
                {
                    estadoActual = "q49";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilNumero.EsNumero9(caracterActual))
                {
                    estadoActual = "q50";
                    resultado = FormarComponeneteLexico();
                }

            }
            return resultado;
        }

        public string ProcesarEstado51()
        {
            concatenar();
            LeerSiguienteCaracter();
            DevorarEspaciosBlanco();
            while (!"@EOF@".Equals(caracterActual))
            {
                if (UtilNumero.EsNumero1(caracterActual))
                {
                    estadoActual = "q52";
                    resultado = FormarComponeneteLexico();

                    Console.WriteLine("Resultado: " + resultado);
                }
                else if (UtilNumero.EsNumero2(caracterActual))
                {
                    estadoActual = "q53";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilNumero.EsNumero3(caracterActual))
                {
                    estadoActual = "q54";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilNumero.EsNumero4(caracterActual))
                {
                    estadoActual = "q55";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilNumero.EsNumero5(caracterActual))
                {
                    estadoActual = "q56";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilNumero.EsNumero6(caracterActual))
                {
                    estadoActual = "q57";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilNumero.EsNumero7(caracterActual))
                {
                    estadoActual = "q58";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilNumero.EsNumero8(caracterActual))
                {
                    estadoActual = "q59";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilNumero.EsNumero9(caracterActual))
                {
                    estadoActual = "q60";
                    resultado = FormarComponeneteLexico();
                }

            }
            return resultado;
        }

        public string ProcesarEstado61()
        {
            concatenar();
            LeerSiguienteCaracter();
            DevorarEspaciosBlanco();
            while (!"@EOF@".Equals(caracterActual))
            {
                if (UtilNumero.EsNumero1(caracterActual))
                {
                    estadoActual = "q62";
                    resultado = FormarComponeneteLexico();

                    Console.WriteLine("Resultado: " + resultado);
                }
                else if (UtilNumero.EsNumero2(caracterActual))
                {
                    estadoActual = "q63";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilNumero.EsNumero3(caracterActual))
                {
                    estadoActual = "q64";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilNumero.EsNumero4(caracterActual))
                {
                    estadoActual = "q65";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilNumero.EsNumero5(caracterActual))
                {
                    estadoActual = "q66";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilNumero.EsNumero6(caracterActual))
                {
                    estadoActual = "q67";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilNumero.EsNumero7(caracterActual))
                {
                    estadoActual = "q68";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilNumero.EsNumero8(caracterActual))
                {
                    estadoActual = "q69";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilNumero.EsNumero9(caracterActual))
                {
                    estadoActual = "q70";
                    resultado = FormarComponeneteLexico();
                }

            }
            return resultado;
        }

        public string ProcesarEstado71()
        {
            concatenar();
            LeerSiguienteCaracter();
            DevorarEspaciosBlanco();
            while (!"@EOF@".Equals(caracterActual))
            {
                if (UtilNumero.EsNumero1(caracterActual))
                {
                    estadoActual = "q72";
                    resultado = FormarComponeneteLexico();

                    Console.WriteLine("Resultado: " + resultado);
                }
                else if (UtilNumero.EsNumero2(caracterActual))
                {
                    estadoActual = "q73";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilNumero.EsNumero3(caracterActual))
                {
                    estadoActual = "q74";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilNumero.EsNumero4(caracterActual))
                {
                    estadoActual = "q75";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilNumero.EsNumero5(caracterActual))
                {
                    estadoActual = "q76";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilNumero.EsNumero6(caracterActual))
                {
                    estadoActual = "q77";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilNumero.EsNumero7(caracterActual))
                {
                    estadoActual = "q78";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilNumero.EsNumero8(caracterActual))
                {
                    estadoActual = "q79";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilNumero.EsNumero9(caracterActual))
                {
                    estadoActual = "q80";
                    resultado = FormarComponeneteLexico();
                }

            }
            return resultado;
        }

        public string ProcesarEstado81()
        {
            concatenar();
            LeerSiguienteCaracter();
            DevorarEspaciosBlanco();
            while (!"@EOF@".Equals(caracterActual))
            {
                if (UtilNumero.EsNumero1(caracterActual))
                {
                    estadoActual = "q82";
                    resultado = FormarComponeneteLexico();

                    Console.WriteLine("Resultado: " + resultado);
                }
                else if (UtilNumero.EsNumero2(caracterActual))
                {
                    estadoActual = "q83";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilNumero.EsNumero3(caracterActual))
                {
                    estadoActual = "q84";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilNumero.EsNumero4(caracterActual))
                {
                    estadoActual = "q85";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilNumero.EsNumero5(caracterActual))
                {
                    estadoActual = "q86";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilNumero.EsNumero6(caracterActual))
                {
                    estadoActual = "q87";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilNumero.EsNumero7(caracterActual))
                {
                    estadoActual = "q88";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilNumero.EsNumero8(caracterActual))
                {
                    estadoActual = "q89";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilNumero.EsNumero9(caracterActual))
                {
                    estadoActual = "q90";
                    resultado = FormarComponeneteLexico();
                }

            }
            return resultado;
        }
        private void concatenar()
        {
            lexema = lexema + estadoActual  
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
            string informacion = $"categoria: {categoria}\n";
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