using ComiladorTraductor.Cache;
using ComiladorTraductor.ManejadorErrores;
using ComiladorTraductor.Tablas;
using ComiladorTraductor.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiladorTraductor.AnalizadorLexico
{
    public class AnalizadorLexicoTexto
    {
        private string contenidoLineaActual = "";
        private int numeroLineaActual = 0;
        private int puntero = 0;
        private string caracterActual = "";
        private string lexema = "";
        private CategoriaGramatical categoria = CategoriaGramatical.DEFECTO;
        private string estadoActual = "q0";
        private int posicionInicial = 0;
        private bool continuarAnalisis = false;
        private ComponenteLexico componente = null;
        private TipoComponente tipo = TipoComponente.LITERAL;
        private string falla = "";
        private string causa = "";
        private string solucion = "";

        public AnalizadorLexicoTexto()
        {
            CargarNuevaLinea();
        }

        private void CargarNuevaLinea()
        {
            if (!"@EOF@".Equals(contenidoLineaActual))
            {
                numeroLineaActual = numeroLineaActual + 1;
                contenidoLineaActual = DataCache.ObtenerLinea(numeroLineaActual).Contenido;
                numeroLineaActual = DataCache.ObtenerLinea(numeroLineaActual).NumeroLinea;
                puntero = 1;
                posicionInicial = 0;
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
            if (!"@FL@".Equals(caracterActual))
            {
                puntero = puntero - 1;
            }

        }
        private void Concatenar()
        {

            lexema = lexema + caracterActual;

        }


        private void Resetear()
        {

            estadoActual = "q0";
            lexema = "";
            categoria = CategoriaGramatical.DEFECTO;
            continuarAnalisis = true;
            componente = null;
            tipo = TipoComponente.LITERAL;
            falla = "";
            causa = "";
            solucion = "";
        }

        public ComponenteLexico DevolverSiguienteComponente()
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
                    ProcesarEstado83();
                }
                else
                {
                    ProcesarEstado84();
                }

            }
            TablaMaestra.ObtenerTablaMaestra().Agregar(componente);
            return componente;
        }

        public void ProcesarEstado0()
        {
            LeerSiguienteCaracter();
           
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
                else if (UtilTexto.EsFinArchivo(caracterActual))
                {
                    estadoActual = "q82";
                }
                else if (UtilTexto.EsFinLinea(caracterActual))
                {
                    estadoActual = "q83";
                }
                else
                {
                    estadoActual = "q84";
                }

            }
        
        private void ProcesarEstado1()
        {
            categoria = CategoriaGramatical.EsLetraAa;
            FormarComponenteLexicoTexto();
        }
        private void ProcesarEstado2()
        {
            categoria = CategoriaGramatical.EsLetraBb;
            FormarComponenteLexicoTexto();
        }
        private void ProcesarEstado3()
        {
            categoria = CategoriaGramatical.EsLetraCc;
            FormarComponenteLexicoTexto();
        }
        private void ProcesarEstado4()
        {
            categoria = CategoriaGramatical.EsLetraDd;
            FormarComponenteLexicoTexto();
        }
        private void ProcesarEstado5()
        {
            categoria = CategoriaGramatical.EsLetraEe;
            FormarComponenteLexicoTexto();
        }
        private void ProcesarEstado6()
        {
            categoria = CategoriaGramatical.EsLetraFf;
            FormarComponenteLexicoTexto();
        }
        private void ProcesarEstado7()
        {
            categoria = CategoriaGramatical.EsLetraGg;
            FormarComponenteLexicoTexto();
        }
        private void ProcesarEstado8()
        {
            categoria = CategoriaGramatical.EsLetraHh;
            FormarComponenteLexicoTexto();
        }
        private void ProcesarEstado9()
        {
            categoria = CategoriaGramatical.EsLetraIi;
            FormarComponenteLexicoTexto();
        }
        private void ProcesarEstado10()
        {
            categoria = CategoriaGramatical.EsLetraJj;
            FormarComponenteLexicoTexto();
        }
        private void ProcesarEstado11()
        {
            categoria = CategoriaGramatical.EsLetraKk;
            FormarComponenteLexicoTexto();
        }
        private void ProcesarEstado12()
        {
            categoria = CategoriaGramatical.EsLetraLl;
            FormarComponenteLexicoTexto();
        }
        private void ProcesarEstado13()
        {
            categoria = CategoriaGramatical.EsLetraMm;
            FormarComponenteLexicoTexto();
        }
        private void ProcesarEstado14()
        {
            categoria = CategoriaGramatical.EsLetraNn;
            FormarComponenteLexicoTexto();
        }
        private void ProcesarEstado15()
        {
            categoria = CategoriaGramatical.EsLetraÑñ;
            FormarComponenteLexicoTexto();
        }
        private void ProcesarEstado16()
        {
            categoria = CategoriaGramatical.EsLetraOo;
            FormarComponenteLexicoTexto();
        }
        private void ProcesarEstado17()
        {
            categoria = CategoriaGramatical.EsLetraPp;
            FormarComponenteLexicoTexto();
        }
        private void ProcesarEstado18()
        {
            categoria = CategoriaGramatical.EsLetraQq;
            FormarComponenteLexicoTexto();
        }
        private void ProcesarEstado19()
        {
            categoria = CategoriaGramatical.EsLetraRr;
            FormarComponenteLexicoTexto();
        }
        private void ProcesarEstado20()
        {
            categoria = CategoriaGramatical.EsLetraSs;
            FormarComponenteLexicoTexto();
        }
        private void ProcesarEstado21()
        {
            categoria = CategoriaGramatical.EsLetraTt;
            FormarComponenteLexicoTexto();
        }
        private void ProcesarEstado22()
        {
            categoria = CategoriaGramatical.EsLetraUu;
            FormarComponenteLexicoTexto();
        }
        private void ProcesarEstado23()
        {
            categoria = CategoriaGramatical.EsLetraVv;
            FormarComponenteLexicoTexto();
        }
        private void ProcesarEstado24()
        {
            categoria = CategoriaGramatical.EsLetraWw;
            FormarComponenteLexicoTexto();
        }
        private void ProcesarEstado25()
        {
            categoria = CategoriaGramatical.EsLetraXx;
            FormarComponenteLexicoTexto();
        }
        private void ProcesarEstado26()
        {
            categoria = CategoriaGramatical.EsLetraYy;
            FormarComponenteLexicoTexto();
        }
        private void ProcesarEstado27()
        {
            categoria = CategoriaGramatical.EsLetraZz;
            FormarComponenteLexicoTexto();
        }
        private void ProcesarEstado28()
        {
            categoria = CategoriaGramatical.EsLetraA_TILDE;
            FormarComponenteLexicoTexto();
        }
        private void ProcesarEstado29()
        {
            categoria = CategoriaGramatical.EsLetraE_TILDE;
            FormarComponenteLexicoTexto();
        }
        private void ProcesarEstado30()
        {
            categoria = CategoriaGramatical.EsLetraI_TILDE;
            FormarComponenteLexicoTexto();
        }
        private void ProcesarEstado31()
        {
            categoria = CategoriaGramatical.EsLetraO_TILDE;
            FormarComponenteLexicoTexto();
        }
        private void ProcesarEstado32()
        {
            categoria = CategoriaGramatical.EsLetraU_TILDE;
            FormarComponenteLexicoTexto();
        }
        private void ProcesarEstado33()
        {
            categoria = CategoriaGramatical.EsLetraU_DIERESIS;
            FormarComponenteLexicoTexto();
        }
        private void ProcesarEstado34()
        {
            categoria = CategoriaGramatical.EsDiguito0;
            FormarComponenteLexicoTexto();
        }
        private void ProcesarEstado35()
        {
            categoria = CategoriaGramatical.EsDiguito1;
            FormarComponenteLexicoTexto();
        }
        private void ProcesarEstado36()
        {
            categoria = CategoriaGramatical.EsDiguito2;
            FormarComponenteLexicoTexto();
        }
        private void ProcesarEstado37()
        {
            categoria = CategoriaGramatical.EsDiguito3;
            FormarComponenteLexicoTexto();
        }
        private void ProcesarEstado38()
        {
            categoria = CategoriaGramatical.EsDiguito4;
            FormarComponenteLexicoTexto();
        }
        private void ProcesarEstado39()
        {
            categoria = CategoriaGramatical.EsDiguito5;
            FormarComponenteLexicoTexto();
        }
        private void ProcesarEstado40()
        {
            categoria = CategoriaGramatical.EsDiguito6;
            FormarComponenteLexicoTexto();
        }
        private void ProcesarEstado41()
        {
            categoria = CategoriaGramatical.EsDiguito7;
            FormarComponenteLexicoTexto();
        }
        private void ProcesarEstado42()
        {
            categoria = CategoriaGramatical.EsDiguito8;
            FormarComponenteLexicoTexto();
        }
        private void ProcesarEstado43()
        {
            categoria = CategoriaGramatical.EsDiguito9;
            FormarComponenteLexicoTexto();
        }
        private void ProcesarEstado44()
        {
            categoria = CategoriaGramatical.EsComa;
            FormarComponenteLexicoTexto();
        }
        private void ProcesarEstado45()
        {
            categoria = CategoriaGramatical.EsPuntoYComa;
            FormarComponenteLexicoTexto();
        }
        private void ProcesarEstado46()
        {
            categoria = CategoriaGramatical.EsPunto;
            FormarComponenteLexicoTexto();
        }
        private void ProcesarEstado47()
        {
            categoria = CategoriaGramatical.EsDosPuntos;
            FormarComponenteLexicoTexto();
        }
        private void ProcesarEstado48()
        {
            categoria = CategoriaGramatical.EsParentesisAbre;
            FormarComponenteLexicoTexto();
        }
        private void ProcesarEstado49()
        {
            categoria = CategoriaGramatical.EsParentesisCierra;
            FormarComponenteLexicoTexto();
        }
        private void ProcesarEstado50()
        {
            categoria = CategoriaGramatical.EsCorchetesAbre;
            FormarComponenteLexicoTexto();
        }
        private void ProcesarEstado51()
        {
            categoria = CategoriaGramatical.EsCorchetesCierra;
            FormarComponenteLexicoTexto();
        }
        private void ProcesarEstado52()
        {
            categoria = CategoriaGramatical.EsLlavesAbre;
            FormarComponenteLexicoTexto();
        }
        private void ProcesarEstado53()
        {
            categoria = CategoriaGramatical.EsLlavesCierra;
            FormarComponenteLexicoTexto();
        }
        private void ProcesarEstado54()
        {
            categoria = CategoriaGramatical.EsNumeral;
            FormarComponenteLexicoTexto();
        }
        private void ProcesarEstado55()
        {
            categoria = CategoriaGramatical.EsPeso;
            FormarComponenteLexicoTexto();
        }
        private void ProcesarEstado56()
        {
            categoria = CategoriaGramatical.EsUmpersand;
            FormarComponenteLexicoTexto();
        }
        private void ProcesarEstado57()
        {
            categoria = CategoriaGramatical.EsArroba;
            FormarComponenteLexicoTexto();
        }
        private void ProcesarEstado58()
        {
            categoria = CategoriaGramatical.EsSuma;
            FormarComponenteLexicoTexto();
        }
        private void ProcesarEstado59()
        {
            categoria = CategoriaGramatical.EsResta;
            FormarComponenteLexicoTexto();
        }
        private void ProcesarEstado60()
        {
            categoria = CategoriaGramatical.EsMultiplicacion;
            FormarComponenteLexicoTexto();
        }
        private void ProcesarEstado61()
        {
            categoria = CategoriaGramatical.EsDivision;
            FormarComponenteLexicoTexto();
        }
        private void ProcesarEstado62()
        {
            categoria = CategoriaGramatical.EsModulo;
            FormarComponenteLexicoTexto();
        }
        private void ProcesarEstado63()
        {
            categoria = CategoriaGramatical.EsAsignacion;
            FormarComponenteLexicoTexto();
        }
        private void ProcesarEstado64()
        {
            categoria = CategoriaGramatical.EsBarraInversa;
            FormarComponenteLexicoTexto();
        }
        private void ProcesarEstado65()
        {
            categoria = CategoriaGramatical.EsOr;
            FormarComponenteLexicoTexto();
        }
        private void ProcesarEstado66()
        {
            categoria = CategoriaGramatical.EsComillaDoble;
            FormarComponenteLexicoTexto();
        }
        private void ProcesarEstado67()
        {
            categoria = CategoriaGramatical.EsComillaSimple;
            FormarComponenteLexicoTexto();
        }
        private void ProcesarEstado68()
        {
            categoria = CategoriaGramatical.EsPotencia;
            FormarComponenteLexicoTexto();
        }
        private void ProcesarEstado69()
        {
            categoria = CategoriaGramatical.EsAdmiracionAbre;
            FormarComponenteLexicoTexto();
        }
        private void ProcesarEstado70()
        {
            categoria = CategoriaGramatical.EsAdmiracionCierra;
            FormarComponenteLexicoTexto();
        }
        private void ProcesarEstado71()
        {
            categoria = CategoriaGramatical.EsPreguntaAbre;
            FormarComponenteLexicoTexto();
        }
        private void ProcesarEstado72()
        {
            categoria = CategoriaGramatical.EsPreguntaCierra;
            FormarComponenteLexicoTexto();
        }
        private void ProcesarEstado73()
        {
            categoria = CategoriaGramatical.EsGionBajo;
            FormarComponenteLexicoTexto();
        }
        private void ProcesarEstado74()
        {
            categoria = CategoriaGramatical.EsMayorQue;
            FormarComponenteLexicoTexto();
        }
        private void ProcesarEstado75()
        {
            categoria = CategoriaGramatical.EsMenorQue;
            FormarComponenteLexicoTexto();
        }
        private void ProcesarEstado76()
        {
            categoria = CategoriaGramatical.EsAGuionBajo;
            FormarComponenteLexicoTexto();
        }
        private void ProcesarEstado77()
        {
            categoria = CategoriaGramatical.EsOGuionBajo;
            FormarComponenteLexicoTexto();
        }
        private void ProcesarEstado78()
        {
            categoria = CategoriaGramatical.EsTilde;
            FormarComponenteLexicoTexto();
        }
        private void ProcesarEstado79()
        {
            categoria = CategoriaGramatical.EsComillaBajaAbre;
            FormarComponenteLexicoTexto();
        }
        private void ProcesarEstado80()
        {
            categoria = CategoriaGramatical.EsComillaBajaCierra;
            FormarComponenteLexicoTexto();
        }
        private void ProcesarEstado81()
        {
            categoria = CategoriaGramatical.EsEspacioEnBlanco;
            FormarComponenteLexicoTexto();
        }
        private void ProcesarEstado82()
        {
            categoria = CategoriaGramatical.FIN_ARCHIVO;
           FormarComponenteLexicoTexto();
        }
        private void ProcesarEstado83()
        {
            Resetear();
            CargarNuevaLinea();
            
        }
        private void FormarComponenteLexicoTexto()
        {
            tipo = TipoComponente.LITERAL;
            Concatenar();
            FormarComponenteLexicoLiteral();
            continuarAnalisis = false;

        }
        private void ProcesarEstado84()
        {
            //ERROR SIMBOLO NO VALIDO
            falla = "Simbolo no valido";
            causa = " se recibió el simbolo no reconocido por el lenguaje  " + caracterActual;
            solucion = "de todos los simbolo en el lenguaje este no se encuentra intente nuevamente";
            ReportarErrorLexicoStopper();
        }
        private void FormarComponenteLexicoLiteral()
        {
            posicionInicial = puntero - lexema.Length;
            componente = ComponenteLexico.Crear(numeroLineaActual, posicionInicial, lexema, categoria, tipo);

        }

        private void ReportarErrorLexicoStopper()
        {
            posicionInicial = puntero - lexema.Length;
            Error error = Error.CrearErrorLexicoStopper(numeroLineaActual, puntero - lexema.Length, lexema, falla, causa, solucion);
            ManejadorTodosErrores.ObtenerManejadorDeErrores().ReportarError(error);
        }
    }
}
