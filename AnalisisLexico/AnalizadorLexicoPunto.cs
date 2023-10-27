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
                else if ("q10".Equals(estadoActual))
                {
                    ProcesarEstado10();
                }
                else if ("q11".Equals(estadoActual))
                {
                    ProcesarEstado11();
                }
                else if ("q12".Equals(estadoActual))
                {
                    ProcesarEstado12();
                }
                else if ("q13".Equals(estadoActual))
                {
                    ProcesarEstado13();
                }
                else if ("q14".Equals(estadoActual))
                {
                    ProcesarEstado14();
                }
                else if ("q15".Equals(estadoActual))
                {
                    ProcesarEstado15();
                }
                else if ("q16".Equals(estadoActual))
                {
                    ProcesarEstado16();
                }
                else if ("q17".Equals(estadoActual))
                {
                    ProcesarEstado17();
                }
                else if ("q18".Equals(estadoActual))
                {
                    ProcesarEstado18();
                }
                else if ("q19".Equals(estadoActual))
                {
                    ProcesarEstado19();
                }
                else if ("q20".Equals(estadoActual))
                {
                    ProcesarEstado20();
                }
                else if ("q21".Equals(estadoActual))
                {
                    ProcesarEstado21();
                }
                else if ("q22".Equals(estadoActual))
                {
                    ProcesarEstado22();
                }
                else if ("q23".Equals(estadoActual))
                {
                    ProcesarEstado23();
                }
                else if ("q24".Equals(estadoActual))
                {
                    ProcesarEstado24();
                }
                else if ("q25".Equals(estadoActual))
                {
                    ProcesarEstado25();
                }
                else if ("q26".Equals(estadoActual))
                {
                    ProcesarEstado26();
                }
                else if ("q27".Equals(estadoActual))
                {
                    ProcesarEstado27();
                }
                else if ("q28".Equals(estadoActual))
                {
                    ProcesarEstado28();
                }
                else if ("q29".Equals(estadoActual))
                {
                    ProcesarEstado29();
                }
                else if ("q30".Equals(estadoActual))
                {
                    ProcesarEstado30();
                }
                else if ("q31".Equals(estadoActual))
                {
                    ProcesarEstado31();
                }
                else if ("q32".Equals(estadoActual))
                {
                    ProcesarEstado32();
                }
                else if ("q33".Equals(estadoActual))
                {
                    ProcesarEstado33();
                }
                else if ("q34".Equals(estadoActual))
                {
                    ProcesarEstado34();
                }
                else if ("q35".Equals(estadoActual))
                {
                    ProcesarEstado35();
                }
                else if ("q36".Equals(estadoActual))
                {
                    ProcesarEstado36();
                }
                else if ("q37".Equals(estadoActual))
                {
                    ProcesarEstado37();
                }
                else if ("q38".Equals(estadoActual))
                {
                    ProcesarEstado38();
                }
                else if ("q39".Equals(estadoActual))
                {
                    ProcesarEstado39();
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
                estadoActual = "q102";
            }
            
        }
        public void ProcesarEstado12()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (UtilTexto.EsPunto(caracterActual))
            {
                estadoActual = "q13";
            }
            else
            {
                estadoActual = "q103";
            }

        }
        public void ProcesarEstado13()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (UtilTexto.EsPunto(caracterActual))
            {
                estadoActual = "q14";
            }
            else
            {
                estadoActual = "q104";
            }

        }
        public void ProcesarEstado14()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (UtilTexto.EsPunto(caracterActual))
            {
                estadoActual = "q15";
            }
            else
            {
                estadoActual = "q105";
            }

        }
        public void ProcesarEstado15()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (UtilTexto.EsPunto(caracterActual))
            {
                estadoActual = "q16";
            }
            else
            {
                estadoActual = "q106";
            }

        }
        public void ProcesarEstado16()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (UtilTexto.EsPunto(caracterActual))
            {
                estadoActual = "q17";
            }
            else
            {
                estadoActual = "q107";
            }

        }
        public void ProcesarEstado17()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (UtilTexto.EsPunto(caracterActual))
            {
                estadoActual = "q18";
            }
            else
            {
                estadoActual = "q108";
            }

        }
        public void ProcesarEstado18()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (UtilTexto.EsPunto(caracterActual))
            {
                estadoActual = "q19";
            }
            else
            {
                estadoActual = "q109";
            }

        }
        public void ProcesarEstado19()
        {
            Concatenar();
            DevolverPuntero();
            categoria = CategoriaGramatical.EsEspacioEnBlanco;
            continuarAnalisis = false;

        }
        public void ProcesarEstado20()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (UtilTexto.EsPunto(caracterActual))
            {
                estadoActual = "q21";
            }

        }
        public void ProcesarEstado21()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (UtilTexto.EsPunto(caracterActual))
            {
                estadoActual = "q22";
            }
            else
            {
                estadoActual = "q111";
            }

        }
        public void ProcesarEstado22()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (UtilTexto.EsPunto(caracterActual))
            {
                estadoActual = "q23";
            }
            else
            {
                estadoActual = "q112";
            }

        }
        public void ProcesarEstado23()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (UtilTexto.EsPunto(caracterActual))
            {
                estadoActual = "q24";
            }
            else
            {
                estadoActual = "q113";
            }

        }
        public void ProcesarEstado24()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (UtilTexto.EsPunto(caracterActual))
            {
                estadoActual = "q25";
            }
            else
            {
                estadoActual = "q114";
            }

        }
        public void ProcesarEstado25()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (UtilTexto.EsPunto(caracterActual))
            {
                estadoActual = "q26";
            }
            else
            {
                estadoActual = "q115";
            }

        }
        public void ProcesarEstado26()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (UtilTexto.EsPunto(caracterActual))
            {
                estadoActual = "q27";
            }
            else
            {
                estadoActual = "q116";
            }

        }
        public void ProcesarEstado27()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (UtilTexto.EsPunto(caracterActual))
            {
                estadoActual = "q28";
            }
            else
            {
                estadoActual = "q117";
            }

        }
        public void ProcesarEstado28()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (UtilTexto.EsPunto(caracterActual))
            {
                estadoActual = "q29";
            }
            else
            {
                estadoActual = "q118";
            }

        }
        public void ProcesarEstado29()
        {
            Concatenar();
            DevolverPuntero();
            categoria = CategoriaGramatical.EsEspacioEnBlanco;
            continuarAnalisis = false;

        }
        public void ProcesarEstado30()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (UtilTexto.EsPunto(caracterActual))
            {
                estadoActual = "q31";
            }

        }
        public void ProcesarEstado31()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (UtilTexto.EsPunto(caracterActual))
            {
                estadoActual = "q32";
            }
            else
            {
                estadoActual = "q120";
            }

        }
        public void ProcesarEstado32()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (UtilTexto.EsPunto(caracterActual))
            {
                estadoActual = "q33";
            }
            else
            {
                estadoActual = "q121";
            }

        }
        public void ProcesarEstado33()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (UtilTexto.EsPunto(caracterActual))
            {
                estadoActual = "q34";
            }
            else
            {
                estadoActual = "q122";
            }

        }
        public void ProcesarEstado34()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (UtilTexto.EsPunto(caracterActual))
            {
                estadoActual = "q35";
            }
            else
            {
                estadoActual = "q123";
            }

        }
        public void ProcesarEstado35()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (UtilTexto.EsPunto(caracterActual))
            {
                estadoActual = "q36";
            }
            else
            {
                estadoActual = "q124";
            }

        }
        public void ProcesarEstado36()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (UtilTexto.EsPunto(caracterActual))
            {
                estadoActual = "q37";
            }
            else
            {
                estadoActual = "q125";
            }

        }
        public void ProcesarEstado37()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (UtilTexto.EsPunto(caracterActual))
            {
                estadoActual = "q38";
            }
            else
            {
                estadoActual = "q126";
            }

        }
        public void ProcesarEstado38()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (UtilTexto.EsPunto(caracterActual))
            {
                estadoActual = "q39";
            }
            else
            {
                estadoActual = "q127";
            }

        }
        public void ProcesarEstado39()
        {
            Concatenar();
            DevolverPuntero();
            categoria = CategoriaGramatical.EsAsignacion;
            continuarAnalisis = false;

        }
        public void ProcesarEstado102()
        {
            DevolverPuntero();
            categoria = CategoriaGramatical.EsGionBajo;
            continuarAnalisis = false; 

        }
        public void ProcesarEstado103()
        {
            DevolverPuntero();
            categoria = CategoriaGramatical.EsMayorQue;
            continuarAnalisis = false;

        }
        public void ProcesarEstado104()
        {
            DevolverPuntero();
            categoria = CategoriaGramatical.EsMenorQue;
            continuarAnalisis = false;

        }
        public void ProcesarEstado105()
        {
            DevolverPuntero();
            categoria = CategoriaGramatical.EsAGuionBajo;
            continuarAnalisis = false;

        }
        public void ProcesarEstado106()
        {
            DevolverPuntero();
            categoria = CategoriaGramatical.EsOGuionBajo;
            continuarAnalisis = false;

        }
        public void ProcesarEstado107()
        {
            DevolverPuntero();
            categoria = CategoriaGramatical.EsTilde;
            continuarAnalisis = false;

        }
        public void ProcesarEstado108()
        {
            DevolverPuntero();
            categoria = CategoriaGramatical.EsComillaBajaAbre;
            continuarAnalisis = false;

        }
        public void ProcesarEstado109()
        {
            DevolverPuntero();
            categoria = CategoriaGramatical.EsComillaBajaCierra;
            continuarAnalisis = false;

        }
        public void ProcesarEstado111()
        {
            DevolverPuntero();
            categoria = CategoriaGramatical.EsBarraInversa;
            continuarAnalisis = false;

        }
        public void ProcesarEstado112()
        {
            DevolverPuntero();
            categoria = CategoriaGramatical.EsOr;
            continuarAnalisis = false;

        }
        public void ProcesarEstado113()
        {
            DevolverPuntero();
            categoria = CategoriaGramatical.EsComillaDoble;
            continuarAnalisis = false;

        }
        public void ProcesarEstado114()
        {
            DevolverPuntero();
            categoria = CategoriaGramatical.EsComillaSimple;
            continuarAnalisis = false;

        }
        public void ProcesarEstado115()
        {
            DevolverPuntero();
            categoria = CategoriaGramatical.EsPotencia;
            continuarAnalisis = false;

        }
        public void ProcesarEstado116()
        {
            DevolverPuntero();
            categoria = CategoriaGramatical.EsAdmiracionAbre;
            continuarAnalisis = false;

        }
        public void ProcesarEstado117()
        {
            DevolverPuntero();
            categoria = CategoriaGramatical.EsAdmiracionCierra;
            continuarAnalisis = false;

        }
        public void ProcesarEstado118()
        {
            DevolverPuntero();
            categoria = CategoriaGramatical.EsPreguntaAbre;
            continuarAnalisis = false;

        }
        public void ProcesarEstado119()
        {
            DevolverPuntero();
            categoria = CategoriaGramatical.EsPreguntaCierra;
            continuarAnalisis = false;

        }
        public void ProcesarEstado120()
        {
            DevolverPuntero();
            categoria = CategoriaGramatical.EsPeso;
            continuarAnalisis = false;

        }
        public void ProcesarEstado121()
        {
            DevolverPuntero();
            categoria = CategoriaGramatical.EsUmpersand;
            continuarAnalisis = false;

        }
        public void ProcesarEstado122()
        {
            DevolverPuntero();
            categoria = CategoriaGramatical.EsArroba;
            continuarAnalisis = false;

        }
        public void ProcesarEstado123()
        {
            DevolverPuntero();
            categoria = CategoriaGramatical.EsSuma;
            continuarAnalisis = false;

        }
        public void ProcesarEstado124()
        {
            DevolverPuntero();
            categoria = CategoriaGramatical.EsResta;
            continuarAnalisis = false;

        }
        public void ProcesarEstado125()
        {
            DevolverPuntero();
            categoria = CategoriaGramatical.EsMultiplicacion;
            continuarAnalisis = false;

        }
        public void ProcesarEstado126()
        {
            DevolverPuntero();
            categoria = CategoriaGramatical.EsDivision;
            continuarAnalisis = false;

        }
        public void ProcesarEstado127()
        {
            DevolverPuntero();
            categoria = CategoriaGramatical.EsModulo;
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


