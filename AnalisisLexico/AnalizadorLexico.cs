using Compilador.GestorErrores;
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
        public CategoriaGramatical categoria;
        private string lexema = "";
        private int posicionInicial = 0;
        private int posicionFinal = 0;
        private bool continuarAnalisis = true;
        private String resultado = "";
        private StreamWriter textOut;
        private ComponenteLexico componente = null;
        private string falla = "";
        private string causa = "";
        private string solucion = "";

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
            categoria= CategoriaGramatical.DEFECTO;
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
                    ProcesarEstado7();
                }
                else if ("q8".Equals(estadoActual))
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
                else if ("q40".Equals(estadoActual))
                {
                    ProcesarEstado40();
                }
                else if ("q41".Equals(estadoActual))
                {
                    ProcesarEstado41();
                }
                else if ("q42".Equals(estadoActual))
                {
                    ProcesarEstado42();
                }
                else if ("q43".Equals(estadoActual))
                {
                    ProcesarEstado43();
                }
                else if ("q44".Equals(estadoActual))
                {
                    ProcesarEstado44();
                }
                else if ("q45".Equals(estadoActual))
                {
                    ProcesarEstado45();
                }
                else if ("q46".Equals(estadoActual))
                {
                    ProcesarEstado46();
                }
                else if ("q47".Equals(estadoActual))
                {
                    ProcesarEstado47();
                }
                else if ("q48".Equals(estadoActual))
                {
                    ProcesarEstado48();
                }
                else if ("q49".Equals(estadoActual))
                {
                    ProcesarEstado49();
                }
                else if ("q50".Equals(estadoActual))
                {
                    ProcesarEstado50();
                }
                else if ("q51".Equals(estadoActual))
                {
                    ProcesarEstado51();
                }
                else if ("q52".Equals(estadoActual))
                {
                    ProcesarEstado52();
                }
                else if ("q53".Equals(estadoActual))
                {
                    ProcesarEstado53();
                }
                else if ("q54".Equals(estadoActual))
                {
                    ProcesarEstado54();
                }
                else if ("q55".Equals(estadoActual))
                {
                    ProcesarEstado55();
                }
                else if ("q56".Equals(estadoActual))
                {
                    ProcesarEstado56();
                }
                else if ("q57".Equals(estadoActual))
                {
                    ProcesarEstado57();
                }
                else if ("q58".Equals(estadoActual))
                {
                    ProcesarEstado58();
                }
                else if ("q59".Equals(estadoActual))
                {
                    ProcesarEstado59();
                }
                else if ("q60".Equals(estadoActual))
                {
                    ProcesarEstado60();
                }
                else if ("q61".Equals(estadoActual))
                {
                    ProcesarEstado61();
                }
                else if ("q62".Equals(estadoActual))
                {
                    ProcesarEstado62();
                }
                else if ("q63".Equals(estadoActual))
                {
                    ProcesarEstado63();
                }
                else if ("q64".Equals(estadoActual))
                {
                    ProcesarEstado64();
                }
                else if ("q65".Equals(estadoActual))
                {
                    ProcesarEstado65();
                }
                else if ("q66".Equals(estadoActual))
                {
                    ProcesarEstado66();
                }
                else if ("q67".Equals(estadoActual))
                {
                    ProcesarEstado67();
                }
                else if ("q68".Equals(estadoActual))
                {
                    ProcesarEstado68();
                }
                else if ("q69".Equals(estadoActual))
                {
                    ProcesarEstado69();
                }
                else if ("q70".Equals(estadoActual))
                {
                    ProcesarEstado70();
                }
                else if ("q71".Equals(estadoActual))
                {
                    ProcesarEstado71();
                }
                else if ("q72".Equals(estadoActual))
                {
                    ProcesarEstado72();
                }
                else if ("q73".Equals(estadoActual))
                {
                    ProcesarEstado73();
                }
                else if ("q74".Equals(estadoActual))
                {
                    ProcesarEstado74();
                }
                else if ("q75".Equals(estadoActual))
                {
                    ProcesarEstado75();
                }
                else if ("q76".Equals(estadoActual))
                {
                    ProcesarEstado76();
                }
                else if ("q77".Equals(estadoActual))
                {
                    ProcesarEstado77();
                }
                else if ("q78".Equals(estadoActual))
                {
                    ProcesarEstado78();
                }
                else if ("q79".Equals(estadoActual))
                {
                    ProcesarEstado79();
                }
                else if ("q80".Equals(estadoActual))
                {
                    ProcesarEstado80();
                }
                else if ("q81".Equals(estadoActual))
                {
                    ProcesarEstado81();
                }
                else if ("q82".Equals(estadoActual))
                {
                    ProcesarEstado82();
                }
                else if ("q83".Equals(estadoActual))
                {
                    ProcesarEOF();
                }

            }
            return lexema;
        }
        
        public void ProcesarEstado0()
        {
            DevorarEspaciosBlanco();
            while (!"@EOF@".Equals(caracterActual))
            {
                if (UtilTexto.EsLetraAa(caracterActual))
                {
                    estadoActual = "q1";

                }
                else if (UtilTexto.EsLetraBb(caracterActual))
                {
                    estadoActual = "q2";
                }
                else if (UtilTexto.EsLetraCc(caracterActual))
                {
                    estadoActual = "q3";
                }
                else if (UtilTexto.EsLetraDd(caracterActual))
                {
                    estadoActual = "q4";
                }
                else if (UtilTexto.EsLetraEe(caracterActual))
                {
                    estadoActual = "q5";
                }
                else if (UtilTexto.EsLetraFf(caracterActual))
                {
                    estadoActual = "q6";
                }
                else if (UtilTexto.EsLetraGg(caracterActual))
                {
                    estadoActual = "q7";
                }
                else if (UtilTexto.EsLetraHh(caracterActual))
                {
                    estadoActual = "q8";
                }
                else if (UtilTexto.EsLetraIi(caracterActual))
                {
                    estadoActual = "q9";
                }
                else if (UtilTexto.EsLetraJj(caracterActual))
                {
                    estadoActual = "q10";
                }
                else if (UtilTexto.EsLetraKk(caracterActual))
                {
                    estadoActual = "q11";
                }
                else if (UtilTexto.EsLetraLl(caracterActual))
                {
                    estadoActual = "q12";
                }
                else if (UtilTexto.EsLetraMm(caracterActual))
                {
                    estadoActual = "q13";
                }
                else if (UtilTexto.EsLetraNn(caracterActual))
                {
                    estadoActual = "q14";
                }
                else if (UtilTexto.EsLetraÑñ(caracterActual))
                {
                    estadoActual = "q15";
                }
                else if (UtilTexto.EsLetraOo(caracterActual))
                {
                    estadoActual = "q16";
                }
                else if (UtilTexto.EsLetraPp(caracterActual))
                {
                    estadoActual = "q17";
                }
                else if (UtilTexto.EsLetraQq(caracterActual))
                {
                    estadoActual = "q18";
                }
                else if (UtilTexto.EsLetraRr(caracterActual))
                {
                    estadoActual = "q19";
                }
                else if (UtilTexto.EsLetraSs(caracterActual))
                {
                    estadoActual = "q20";
                }
                else if (UtilTexto.EsLetraTt(caracterActual))
                {
                    estadoActual = "q21";
                }
                else if (UtilTexto.EsLetraUu(caracterActual))
                {
                    estadoActual = "q22";
                }
                else if (UtilTexto.EsLetraVv(caracterActual))
                {
                    estadoActual = "q23";
                }
                else if (UtilTexto.EsLetraWw(caracterActual))
                {
                    estadoActual = "q24";
                }
                else if (UtilTexto.EsLetraXx(caracterActual))
                {
                    estadoActual = "q25";
                }
                else if (UtilTexto.EsLetraYy(caracterActual))
                {
                    estadoActual = "q26";
                }
                else if (UtilTexto.EsLetraZz(caracterActual))
                {
                    estadoActual = "q27";
                }
                else if (UtilTexto.EsLetraÁá(caracterActual))
                {
                    estadoActual = "q28";
                }
                else if (UtilTexto.EsLetraÉé(caracterActual))
                {
                    estadoActual = "q29";
                }
                else if (UtilTexto.EsLetraÍí(caracterActual))
                {
                    estadoActual = "q30";
                }
                else if (UtilTexto.EsLetraÓó(caracterActual))
                {
                    estadoActual = "q31";
                }
                else if (UtilTexto.EsLetraÚú(caracterActual))
                {
                    estadoActual = "q32";
                }
                else if (UtilTexto.EsLetraÜü(caracterActual))
                {
                    estadoActual = "q33";
                }
                else if (UtilTexto.EsDigito0(caracterActual))
                {
                    estadoActual = "q34";
                }
                else if (UtilTexto.EsDigito1(caracterActual))
                {
                    estadoActual = "q35";
                }
                else if (UtilTexto.EsDigito2(caracterActual))
                {
                    estadoActual = "q36";
                }
                else if (UtilTexto.EsDigito3(caracterActual))
                {
                    estadoActual = "q37";
                }
                else if (UtilTexto.EsDigito4(caracterActual))
                {
                    estadoActual = "q38";
                }
                else if (UtilTexto.EsDigito5(caracterActual))
                {
                    estadoActual = "q39";
                }
                else if (UtilTexto.EsDigito6(caracterActual))
                {
                    estadoActual = "q40";
                }
                else if (UtilTexto.EsDigito7(caracterActual))
                {
                    estadoActual = "q41";
                }
                else if (UtilTexto.EsDigito8(caracterActual))
                {
                    estadoActual = "q42";
                }
                else if (UtilTexto.EsDigito9(caracterActual))
                {
                    estadoActual = "q43";
                }
                else if (UtilTexto.EsComa(caracterActual))
                {
                    estadoActual = "q44";
                }
                else if (UtilTexto.EsPuntoYComa(caracterActual))
                {
                    estadoActual = "q45";
                }
                else if (UtilTexto.EsPunto(caracterActual))
                {
                    estadoActual = "q46";
                }
                else if (UtilTexto.EsDosPuntos(caracterActual))
                {
                    estadoActual = "q47";
                }
                else if (UtilTexto.EsParentesisAbre(caracterActual))
                {
                    estadoActual = "q48";
                }
                else if (UtilTexto.EsParentesisCierra(caracterActual))
                {
                    estadoActual = "q49";
                }
                else if (UtilTexto.EsCorchetesAbre(caracterActual))
                {
                    estadoActual = "q50";
                }
                else if (UtilTexto.EsCorchetesCierra(caracterActual))
                {
                    estadoActual = "q51";

                }
                else if (UtilTexto.EsLlavesAbre(caracterActual))
                {
                    estadoActual = "q52";

                }
                else if (UtilTexto.EsLlavesCierra(caracterActual))
                {
                    estadoActual = "q53";

                }
                else if (UtilTexto.EsNumeral(caracterActual))
                {
                    estadoActual = "q54";

                }
                else if (UtilTexto.EsPeso(caracterActual))
                {
                    estadoActual = "q55";
                }
                else if (UtilTexto.EsUmpersand(caracterActual))
                {
                    estadoActual = "q56";
                }
                else if (UtilTexto.EsArroba(caracterActual))
                {
                    estadoActual = "q57";
                }
                else if (UtilTexto.EsSuma(caracterActual))
                {
                    estadoActual = "q58";
                }
                else if (UtilTexto.EsResta(caracterActual))
                {
                    estadoActual = "q59";
                }
                else if (UtilTexto.EsMult(caracterActual))
                {
                    estadoActual = "q60";
                }
                else if (UtilTexto.EsDiv(caracterActual))
                {
                    estadoActual = "q61";
                }
                else if (UtilTexto.EsModulo(caracterActual))
                {
                    estadoActual = "q62";
                }
                else if (UtilTexto.EsAsignacion(caracterActual))
                {
                    estadoActual = "q63";
                  
                }
                else if (UtilTexto.EsBarraInversa(caracterActual))
                {
                    estadoActual = "q64";
              
                }
                else if (UtilTexto.EsOr(caracterActual))
                {
                    estadoActual = "q65";
                 
                }
                else if (UtilTexto.EsComillaDoble(caracterActual))
                {
                    estadoActual = "q66";
                  
                }
                else if (UtilTexto.EsComillaSimple(caracterActual))
                {
                    estadoActual = "q67";
                   
                }
                else if (UtilTexto.EsPotencia(caracterActual))
                {
                    estadoActual = "q68";
                    
                }
                else if (UtilTexto.EsAdmiracionAbre(caracterActual))
                {
                    estadoActual = "q69";
                    
                }
                else if (UtilTexto.EsAdmiracionCierra(caracterActual))
                {
                    estadoActual = "q70";
                   
                }
                else if (UtilTexto.EsPreguntaAbre(caracterActual))
                {
                    estadoActual = "q71";
                   
                }
                else if (UtilTexto.EsPreguntaCierra(caracterActual))
                {
                    estadoActual = "q72";
                    
                }
                else if (UtilTexto.EsGuionBajo(caracterActual))
                {
                    estadoActual = "q73";
                    
                }
                else if (UtilTexto.EsMayorQue(caracterActual))
                {
                    estadoActual = "q74";
                    
                }
                else if (UtilTexto.EsMenorQue(caracterActual))
                {
                    estadoActual = "q75";
                    
                }
                else if (UtilTexto.EsAGuionBajo(caracterActual))
                {
                    estadoActual = "q76";
                    
                }
                else if (UtilTexto.EsOGuionBajo(caracterActual))
                {
                    estadoActual = "q77";
                    
                }
                else if (UtilTexto.EsTilde(caracterActual))
                {
                    estadoActual = "q78";
                   
                }
                else if (UtilTexto.EsComillaBajaAbre(caracterActual))
                {
                    estadoActual = "q79";
                    
                }
                else if (UtilTexto.EsComillaBajaCierra(caracterActual))
                {
                    estadoActual = "q80";
                   
                }
                else if (UtilTexto.EsEspacioEnBlanco(caracterActual))
                {
                    estadoActual = "q81";
                   
                }
                else if (UtilTexto.EsComillaSimple(caracterActual))
                {
                    estadoActual = "q67";
                  
                }
                else if ("@EOF@".Equals(caracterActual))
                {
                    
                }
                else if ("@FL@".Equals(caracterActual))
                {
                    
                }

            }
        }
        private void ProcesarEstado1()
        {
            DevolverPuntero();
            categoria = CategoriaGramatical.EsLetraAa;
            continuarAnalisis = false;
        }

        private void FormarComponenteLexicoSimbolo()
        {
            posicionInicial = puntero - lexema.Length;
            componente = ComponenteLexico.CREAR_SIMBOLO(numeroLineaActual, posicionInicial, lexema, categoria);

        }
        private void FormarComponenteLexicoDummy()
        {
            posicionInicial = puntero - lexema.Length;
            componente = ComponenteLexico.CREAR_DUMMY(numeroLineaActual, posicionInicial, lexema, categoria);

        }
        private void FormarComponenteLexicoLiteral()
        {
            posicionInicial = puntero - lexema.Length;
            componente = ComponenteLexico.CREAR_LITERAL(numeroLineaActual, posicionInicial, lexema, categoria);

        }
        private void FormarComponenteLexicoPalabraReservada()
        {
            posicionInicial = puntero - lexema.Length;
            componente = ComponenteLexico.CREAR_PALABRA_RESERVADA(numeroLineaActual, posicionInicial, lexema, categoria);

        }
        private void ReportarErrorLexicoStopper()
        {
            posicionInicial = puntero - lexema.Length;
            Error error = Error.CREAR_ERROR_LEXICO_STOPPER(numeroLineaActual, posicionInicial, lexema, falla, causa, solucion);
            ManejadorErrores.ObtenerManejadorErrores().ReportarError(error);
        }
        private void DevorarEspaciosBlanco()
        {
            while ("".Equals(caracterActual.Trim()) || " ".Equals(caracterActual))
            {
                LeerSiguienteCaracter();
            }
        }
    }

}
