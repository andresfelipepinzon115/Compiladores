using Compilador.Cache;
using Compilador.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compilador.AnalisisLexico
{
    public class AnalizadorLexicoNumero
    {

        private int numeroLineaActual = 0;
        private string contenidoLineaActual = "";
        private int puntero = 0;
        private string caracterActual = "";
        private string lexema = "";
        private CategoriaGramatical categoria;
        private string estadoActual = "";
        private int posicionInicial = 0;
        private bool continuarAnalisis = true;
        private ComponenteLexico componente = null;
        private string falla = "";
        private string causa = "";
        private string solucion = "";


        public AnalizadorLexicoNumero()
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
            if (!"@EOF@".Equals(caracterActual))
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
            posicionInicial = 0;
            caracterActual = "";
            continuarAnalisis = true;
            componente = null;
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
                else if ("q84".Equals(estadoActual))
                {
                    ProcesarEstado84();
                }
                else if ("q85".Equals(estadoActual))
                {
                    ProcesarEstado85();
                }
                else if ("q86".Equals(estadoActual))
                {
                    ProcesarEstado86();
                }
                else if ("q87".Equals(estadoActual))
                {
                    ProcesarEstado87();
                }
                else if ("q88".Equals(estadoActual))
                {
                    ProcesarEstado88();
                }
                else if ("q89".Equals(estadoActual))
                {
                    ProcesarEstado89();
                }
                else if ("q90".Equals(estadoActual))
                {
                    ProcesarEstado90();
                }
                else if ("q91".Equals(estadoActual))
                {
                    ProcesarEstado91();
                }
                else if ("q92".Equals(estadoActual))
                {
                    ProcesarEstado92();
                }
            }
           
        }
        public void ProcesarEstado0()
        {
            DevorarEspaciosBlanco();
            if (UtilTexto.EsDigito1(caracterActual))
            {
                estadoActual = "q1";
            }
            else if (UtilTexto.EsDigito2(caracterActual))
            {
                estadoActual = "q11";
            }
            else if (UtilTexto.EsDigito3(caracterActual))
            {
                estadoActual = "q21";
            }
            else if (UtilTexto.EsDigito4(caracterActual))
            {
                estadoActual = "q31";
            }
            else if (UtilTexto.EsDigito5(caracterActual))
            {
                estadoActual = "q41";
            }
            else if (UtilTexto.EsDigito6(caracterActual))
            {
                estadoActual = "q51";
            }
            else if (UtilTexto.EsDigito7(caracterActual))
            {
                estadoActual = "q61";
            }
            else if (UtilTexto.EsDigito8(caracterActual))
            {
                estadoActual = "q71";
            }
            else if (UtilTexto.EsDigito9(caracterActual))
            {
                estadoActual = "q81";
            }
            else
            {

            }
        }
        private void ProcesarEstado1()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (UtilTexto.EsDigito1(caracterActual))
            {
                estadoActual = "q2";
            }
            else if (UtilTexto.EsDigito2(caracterActual))
            {
                estadoActual = "q3";
            }
            else if (UtilTexto.EsDigito3(caracterActual))
            {
                estadoActual = "q4";
            }
            else if (UtilTexto.EsDigito4(caracterActual))
            {
                estadoActual = "q5";
            }
            else if (UtilTexto.EsDigito5(caracterActual))
            {
                estadoActual = "q6";
            }
            else if (UtilTexto.EsDigito6(caracterActual))
            {
                estadoActual = "q7";
            }
            else if (UtilTexto.EsDigito7(caracterActual))
            {
                estadoActual = "q8";
            }
            else if (UtilTexto.EsDigito8(caracterActual))
            {
                estadoActual = "q9";
            }
            else if (UtilTexto.EsDigito9(caracterActual))
            {
                estadoActual = "q10";
            }
            else if (UtilTexto.EsFinArchivo(caracterActual))
            {
                estadoActual = "q91";
            }
            else if (UtilTexto.EsFinLinea(caracterActual))
            {
                estadoActual = "q92";
            }
        }
        private void ProcesarEstado2()
        {
            DevolverPuntero();
            categoria = CategoriaGramatical.EsLetraAa;
            continuarAnalisis = false;
        }
        private void ProcesarEstado3()
        {
            DevolverPuntero();
            categoria = CategoriaGramatical.EsLetraBb;
            continuarAnalisis = false;
        }
        private void ProcesarEstado4()
        {
            DevolverPuntero();
            categoria = CategoriaGramatical.EsLetraCc;
            continuarAnalisis = false;
        }
        private void ProcesarEstado5()
        {
            DevolverPuntero();
            categoria = CategoriaGramatical.EsLetraDd;
            continuarAnalisis = false;
        }
        private void ProcesarEstado6()
        {
            DevolverPuntero();
            categoria = CategoriaGramatical.EsLetraEe;
            continuarAnalisis = false;
        }
        private void ProcesarEstado7()
        {
            DevolverPuntero();
            categoria = CategoriaGramatical.EsLetraFf;
            continuarAnalisis = false;
        }
        private void ProcesarEstado8()
        {
            DevolverPuntero();
            categoria = CategoriaGramatical.EsLetraGg;
            continuarAnalisis = false;
        }
        private void ProcesarEstado9()
        {
            DevolverPuntero();
            categoria = CategoriaGramatical.EsLetraHh;
            continuarAnalisis = false;
        }
        private void ProcesarEstado10()
        {
            DevolverPuntero();
            categoria = CategoriaGramatical.EsLetraIi;
            continuarAnalisis = false;
        }


        private void ProcesarEstado11()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (UtilTexto.EsDigito1(caracterActual))
            {
                estadoActual = "q12";
            }
            else if (UtilTexto.EsDigito2(caracterActual))
            {
                estadoActual = "q13";
            }
            else if (UtilTexto.EsDigito3(caracterActual))
            {
                estadoActual = "q14";
            }
            else if (UtilTexto.EsDigito4(caracterActual))
            {
                estadoActual = "q15";
            }
            else if (UtilTexto.EsDigito5(caracterActual))
            {
                estadoActual = "q16";
            }
            else if (UtilTexto.EsDigito6(caracterActual))
            {
                estadoActual = "q17";
            }
            else if (UtilTexto.EsDigito7(caracterActual))
            {
                estadoActual = "q18";
            }
            else if (UtilTexto.EsDigito8(caracterActual))
            {
                estadoActual = "q19";
            }
            else if (UtilTexto.EsDigito9(caracterActual))
            {
                estadoActual = "q20";
            }
        }
        private void ProcesarEstado12()
        {
            DevolverPuntero();
            categoria = CategoriaGramatical.EsLetraJj;
            continuarAnalisis = false;
        }
        private void ProcesarEstado13()
        {
            DevolverPuntero();
            categoria = CategoriaGramatical.EsLetraKk;
            continuarAnalisis = false;
        }
        private void ProcesarEstado14()
        {
            DevolverPuntero();
            categoria = CategoriaGramatical.EsLetraLl;
            continuarAnalisis = false;
        }
        private void ProcesarEstado15()
        {
            DevolverPuntero();
            categoria = CategoriaGramatical.EsLetraMm;
            continuarAnalisis = false;
        }
        private void ProcesarEstado16()
        {
            DevolverPuntero();
            categoria = CategoriaGramatical.EsLetraNn;
            continuarAnalisis = false;
        }
        private void ProcesarEstado17()
        {
            DevolverPuntero();
            categoria = CategoriaGramatical.EsLetraÑñ;
            continuarAnalisis = false;
        }
        private void ProcesarEstado18()
        {
            DevolverPuntero();
            categoria = CategoriaGramatical.EsLetraOo;
            continuarAnalisis = false;
        }
        private void ProcesarEstado19()
        {
            DevolverPuntero();
            categoria = CategoriaGramatical.EsLetraPp;
            continuarAnalisis = false;
        }
        private void ProcesarEstado20()
        {
            DevolverPuntero();
            categoria = CategoriaGramatical.EsLetraQq;
            continuarAnalisis = false;
        } 
        private void ProcesarEstado21()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (UtilTexto.EsDigito1(caracterActual))
            {
                estadoActual = "q22";
            }
            else if (UtilTexto.EsDigito2(caracterActual))
            {
                estadoActual = "q23";
            }
            else if (UtilTexto.EsDigito3(caracterActual))
            {
                estadoActual = "q24";
            }
            else if (UtilTexto.EsDigito4(caracterActual))
            {
                estadoActual = "q25";
            }
            else if (UtilTexto.EsDigito5(caracterActual))
            {
                estadoActual = "q26";
            }
            else if (UtilTexto.EsDigito6(caracterActual))
            {
                estadoActual = "q27";
            }
            else if (UtilTexto.EsDigito7(caracterActual))
            {
                estadoActual = "q28";
            }
            else if (UtilTexto.EsDigito8(caracterActual))
            {
                estadoActual = "q29";
            }
            else if (UtilTexto.EsDigito9(caracterActual))
            {
                estadoActual = "q30";
            }
        }
        private void ProcesarEstado22()
        {
            DevolverPuntero();
            categoria = CategoriaGramatical.EsLetraRr;
            continuarAnalisis = false;
        }
        private void ProcesarEstado23()
        {
            DevolverPuntero();
            categoria = CategoriaGramatical.EsLetraSs;
            continuarAnalisis = false;
        }
        private void ProcesarEstado24()
        {
            DevolverPuntero();
            categoria = CategoriaGramatical.EsLetraTt;
            continuarAnalisis = false;
        }
        private void ProcesarEstado25()
        {
            DevolverPuntero();
            categoria = CategoriaGramatical.EsLetraUu;
            continuarAnalisis = false;
        }
        private void ProcesarEstado26()
        {
            DevolverPuntero();
            categoria = CategoriaGramatical.EsLetraVv;
            continuarAnalisis = false;
        }
        private void ProcesarEstado27()
        {
            DevolverPuntero();
            categoria = CategoriaGramatical.EsLetraWw;
            continuarAnalisis = false;
        }
        private void ProcesarEstado28()
        {
            DevolverPuntero();
            categoria = CategoriaGramatical.EsLetraXx;
            continuarAnalisis = false;
        }
        private void ProcesarEstado29()
        {
            DevolverPuntero();
            categoria = CategoriaGramatical.EsLetraYy;
            continuarAnalisis = false;
        }
        private void ProcesarEstado30()
        {
            DevolverPuntero();
            categoria = CategoriaGramatical.EsLetraZz;
            continuarAnalisis = false;
        }

        private void ProcesarEstado31()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (UtilTexto.EsDigito1(caracterActual))
            {
                estadoActual = "q32";
            }
            else if (UtilTexto.EsDigito2(caracterActual))
            {
                estadoActual = "q33";
            }
            else if (UtilTexto.EsDigito3(caracterActual))
            {
                estadoActual = "q34";
            }
            else if (UtilTexto.EsDigito4(caracterActual))
            {
                estadoActual = "q35";
            }
            else if (UtilTexto.EsDigito5(caracterActual))
            {
                estadoActual = "q36";
            }
            else if (UtilTexto.EsDigito6(caracterActual))
            {
                estadoActual = "q37";
            }
            else if (UtilTexto.EsDigito7(caracterActual))
            {
                estadoActual = "q38";
            }
            else if (UtilTexto.EsDigito8(caracterActual))
            {
                estadoActual = "q39";
            }
            else if (UtilTexto.EsDigito9(caracterActual))
            {
                estadoActual = "q40";
            }
        }
        private void ProcesarEstado32()
        {
            DevolverPuntero();
            categoria = CategoriaGramatical.EsLetraA_TILDE;
            continuarAnalisis = false;
        }
        private void ProcesarEstado33()
        {
            DevolverPuntero();
            categoria = CategoriaGramatical.EsLetraE_TILDE;
            continuarAnalisis = false;
        }
        private void ProcesarEstado34()
        {
            DevolverPuntero();
            categoria = CategoriaGramatical.EsLetraI_TILDE;
            continuarAnalisis = false;
        }
        private void ProcesarEstado35()
        {
            DevolverPuntero();
            categoria = CategoriaGramatical.EsLetraO_TILDE;
            continuarAnalisis = false;
        }
        private void ProcesarEstado36()
        {
            DevolverPuntero();
            categoria = CategoriaGramatical.EsLetraU_TILDE;
            continuarAnalisis = false;
        }
        private void ProcesarEstado37()
        {
            DevolverPuntero();
            categoria = CategoriaGramatical.EsLetraU_DIERESIS;
            continuarAnalisis = false;
        }
        private void ProcesarEstado38()
        {
            DevolverPuntero();
            categoria = CategoriaGramatical.EsDiguito0;
            continuarAnalisis = false;
        }
        private void ProcesarEstado39()
        {
            DevolverPuntero();
            categoria = CategoriaGramatical.EsDiguito1;
            continuarAnalisis = false;
        }
        private void ProcesarEstado40()
        {
            DevolverPuntero();
            categoria = CategoriaGramatical.EsDiguito2;
            continuarAnalisis = false;
        }

        private void ProcesarEstado41()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (UtilTexto.EsDigito1(caracterActual))
            {
                estadoActual = "q42";
            }
            else if (UtilTexto.EsDigito2(caracterActual))
            {
                estadoActual = "q43";
            }
            else if (UtilTexto.EsDigito3(caracterActual))
            {
                estadoActual = "q44";
            }
            else if (UtilTexto.EsDigito4(caracterActual))
            {
                estadoActual = "q45";
            }
            else if (UtilTexto.EsDigito5(caracterActual))
            {
                estadoActual = "q46";
            }
            else if (UtilTexto.EsDigito6(caracterActual))
            {
                estadoActual = "q47";
            }
            else if (UtilTexto.EsDigito7(caracterActual))
            {
                estadoActual = "q48";
            }
            else if (UtilTexto.EsDigito8(caracterActual))
            {
                estadoActual = "q49";
            }
            else if (UtilTexto.EsDigito9(caracterActual))
            {
                estadoActual = "q50";
            }
        }
        private void ProcesarEstado42()
        {
            DevolverPuntero();
            categoria = CategoriaGramatical.EsDiguito3;
            continuarAnalisis = false;
        }
        private void ProcesarEstado43()
        {
            DevolverPuntero();
            categoria = CategoriaGramatical.EsDiguito4;
            continuarAnalisis = false;
        }
        private void ProcesarEstado44()
        {
            DevolverPuntero();
            categoria = CategoriaGramatical.EsDiguito5;
            continuarAnalisis = false;
        }
        private void ProcesarEstado45()
        {
            DevolverPuntero();
            categoria = CategoriaGramatical.EsDiguito6;
            continuarAnalisis = false;
        }
        private void ProcesarEstado46()
        {
            DevolverPuntero();
            categoria = CategoriaGramatical.EsDiguito7;
            continuarAnalisis = false;
        }
        private void ProcesarEstado47()
        {
            DevolverPuntero();
            categoria = CategoriaGramatical.EsDiguito8;
            continuarAnalisis = false;
        }
        private void ProcesarEstado48()
        {
            DevolverPuntero();
            categoria = CategoriaGramatical.EsDiguito9;
            continuarAnalisis = false;
        }
        private void ProcesarEstado49()
        {
            DevolverPuntero();
            categoria = CategoriaGramatical.EsComa;
            continuarAnalisis = false;
        }
        private void ProcesarEstado50()
        {
            DevolverPuntero();
            categoria = CategoriaGramatical.EsPuntoYComa;
            continuarAnalisis = false;
        }

        private void ProcesarEstado51()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (UtilTexto.EsDigito1(caracterActual))
            {
                estadoActual = "q52";
            }
            else if (UtilTexto.EsDigito2(caracterActual))
            {
                estadoActual = "q53";
            }
            else if (UtilTexto.EsDigito3(caracterActual))
            {
                estadoActual = "q54";
            }
            else if (UtilTexto.EsDigito4(caracterActual))
            {
                estadoActual = "q55";
            }
            else if (UtilTexto.EsDigito5(caracterActual))
            {
                estadoActual = "q56";
            }
            else if (UtilTexto.EsDigito6(caracterActual))
            {
                estadoActual = "q57";
            }
            else if (UtilTexto.EsDigito7(caracterActual))
            {
                estadoActual = "q58";
            }
            else if (UtilTexto.EsDigito8(caracterActual))
            {
                estadoActual = "q59";
            }
            else if (UtilTexto.EsDigito9(caracterActual))
            {
                estadoActual = "q60";
            }
        }
        private void ProcesarEstado52()
        {
            DevolverPuntero();
            categoria = CategoriaGramatical.EsPunto;
            continuarAnalisis = false;
        }
        private void ProcesarEstado53()
        {
            DevolverPuntero();
            categoria = CategoriaGramatical.EsDosPuntos;
            continuarAnalisis = false;
        }
        private void ProcesarEstado54()
        {
            DevolverPuntero();
            categoria = CategoriaGramatical.EsParentesisAbre;
            continuarAnalisis = false;
        }
        private void ProcesarEstado55()
        {
            DevolverPuntero();
            categoria = CategoriaGramatical.EsParentesisCierra;
            continuarAnalisis = false;
        }
        private void ProcesarEstado56()
        {
            DevolverPuntero();
            categoria = CategoriaGramatical.EsCorchetesAbre;
            continuarAnalisis = false;
        }
        private void ProcesarEstado57()
        {
            DevolverPuntero();
            categoria = CategoriaGramatical.EsCorchetesCierra;
            continuarAnalisis = false;
        }
        private void ProcesarEstado58()
        {
            DevolverPuntero();
            categoria = CategoriaGramatical.EsLlavesAbre;
            continuarAnalisis = false;
        }
        private void ProcesarEstado59()
        {
            DevolverPuntero();
            categoria = CategoriaGramatical.EsLlavesCierra;
            continuarAnalisis = false;
        }
        private void ProcesarEstado60()
        {
            DevolverPuntero();
            categoria = CategoriaGramatical.EsNumeral;
            continuarAnalisis = false;
        }
        private void ProcesarEstado61()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (UtilTexto.EsDigito1(caracterActual))
            {
                estadoActual = "q62";
            }
            else if (UtilTexto.EsDigito2(caracterActual))
            {
                estadoActual = "q63";
            }
            else if (UtilTexto.EsDigito3(caracterActual))
            {
                estadoActual = "q64";
            }
            else if (UtilTexto.EsDigito4(caracterActual))
            {
                estadoActual = "q65";
            }
            else if (UtilTexto.EsDigito5(caracterActual))
            {
                estadoActual = "q66";
            }
            else if (UtilTexto.EsDigito6(caracterActual))
            {
                estadoActual = "q67";
            }
            else if (UtilTexto.EsDigito7(caracterActual))
            {
                estadoActual = "q68";
            }
            else if (UtilTexto.EsDigito8(caracterActual))
            {
                estadoActual = "q69";
            }
            else if (UtilTexto.EsDigito9(caracterActual))
            {
                estadoActual = "q70";
            }
        }
        private void ProcesarEstado62()
        {
            DevolverPuntero();
            categoria = CategoriaGramatical.EsPeso;
            continuarAnalisis = false;
        }
        private void ProcesarEstado63()
        {
            DevolverPuntero();
            categoria = CategoriaGramatical.EsUmpersand;
            continuarAnalisis = false;
        }
        private void ProcesarEstado64()
        {
            DevolverPuntero();
            categoria = CategoriaGramatical.EsArroba;
            continuarAnalisis = false;
        }
        private void ProcesarEstado65()
        {
            DevolverPuntero();
            categoria = CategoriaGramatical.EsSuma;
            continuarAnalisis = false;
        }
        private void ProcesarEstado66()
        {
            DevolverPuntero();
            categoria = CategoriaGramatical.EsResta;
            continuarAnalisis = false;
        }
        private void ProcesarEstado67()
        {
            DevolverPuntero();
            categoria = CategoriaGramatical.EsMultiplicacion;
            continuarAnalisis = false;
        }
        private void ProcesarEstado68()
        {
            DevolverPuntero();
            categoria = CategoriaGramatical.EsDivision;
            continuarAnalisis = false;
        }
        private void ProcesarEstado69()
        {
            DevolverPuntero();
            categoria = CategoriaGramatical.EsModulo;
            continuarAnalisis = false;
        }
        private void ProcesarEstado70()
        {
            DevolverPuntero();
            categoria = CategoriaGramatical.EsAsignacion;
            continuarAnalisis = false;
        }

        private void ProcesarEstado71()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (UtilTexto.EsDigito1(caracterActual))
            {
                estadoActual = "q72";
            }
            else if (UtilTexto.EsDigito2(caracterActual))
            {
                estadoActual = "q73";
            }
            else if (UtilTexto.EsDigito3(caracterActual))
            {
                estadoActual = "q74";
            }
            else if (UtilTexto.EsDigito4(caracterActual))
            {
                estadoActual = "q75";
            }
            else if (UtilTexto.EsDigito5(caracterActual))
            {
                estadoActual = "q76";
            }
            else if (UtilTexto.EsDigito6(caracterActual))
            {
                estadoActual = "q77";
            }
            else if (UtilTexto.EsDigito7(caracterActual))
            {
                estadoActual = "q78";
            }
            else if (UtilTexto.EsDigito8(caracterActual))
            {
                estadoActual = "q79";
            }
            else if (UtilTexto.EsDigito9(caracterActual))
            {
                estadoActual = "q80";
            }
        }
        private void ProcesarEstado72()
        {
            DevolverPuntero();
            categoria = CategoriaGramatical.EsBarraInversa;
            continuarAnalisis = false;
        }
        private void ProcesarEstado73()
        {
            DevolverPuntero();
            categoria = CategoriaGramatical.EsOr;
            continuarAnalisis = false;
        }
        private void ProcesarEstado74()
        {
            DevolverPuntero();
            categoria = CategoriaGramatical.EsComillaDoble;
            continuarAnalisis = false;
        }
        private void ProcesarEstado75()
        {
            DevolverPuntero();
            categoria = CategoriaGramatical.EsComillaSimple;
            continuarAnalisis = false;
        }
        private void ProcesarEstado76()
        {
            DevolverPuntero();
            categoria = CategoriaGramatical.EsPotencia;
            continuarAnalisis = false;
        }
        private void ProcesarEstado77()
        {
            DevolverPuntero();
            categoria = CategoriaGramatical.EsAdmiracionAbre;
            continuarAnalisis = false;
        }
        private void ProcesarEstado78()
        {
            DevolverPuntero();
            categoria = CategoriaGramatical.EsAdmiracionCierra;
            continuarAnalisis = false;
        }
        private void ProcesarEstado79()
        {
            DevolverPuntero();
            categoria = CategoriaGramatical.EsPreguntaAbre;
            continuarAnalisis = false;
        }
        private void ProcesarEstado80()
        {
            DevolverPuntero();
            categoria = CategoriaGramatical.EsPreguntaCierra;
            continuarAnalisis = false;
        }
        private void ProcesarEstado81()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (UtilTexto.EsDigito1(caracterActual))
            {
                estadoActual = "q82";
            }
            else if (UtilTexto.EsDigito2(caracterActual))
            {
                estadoActual = "q83";
            }
            else if (UtilTexto.EsDigito3(caracterActual))
            {
                estadoActual = "q84";
            }
            else if (UtilTexto.EsDigito4(caracterActual))
            {
                estadoActual = "q85";
            }
            else if (UtilTexto.EsDigito5(caracterActual))
            {
                estadoActual = "q86";
            }
            else if (UtilTexto.EsDigito6(caracterActual))
            {
                estadoActual = "q87";
            }
            else if (UtilTexto.EsDigito7(caracterActual))
            {
                estadoActual = "q88";
            }
            else if (UtilTexto.EsDigito8(caracterActual))
            {
                estadoActual = "q89";
            }
            else if (UtilTexto.EsDigito9(caracterActual))
            {
                estadoActual = "q90";
            }
        }
        private void ProcesarEstado82()
        {
            DevolverPuntero();
            categoria = CategoriaGramatical.EsGionBajo;
            continuarAnalisis = false;
        }
        private void ProcesarEstado83()
        {
            DevolverPuntero();
            categoria = CategoriaGramatical.EsMayorQue;
            continuarAnalisis = false;
        }
        private void ProcesarEstado84()
        {
            DevolverPuntero();
            categoria = CategoriaGramatical.EsMenorQue;
            continuarAnalisis = false;
        }
        private void ProcesarEstado85()
        {
            DevolverPuntero();
            categoria = CategoriaGramatical.EsAGuionBajo;
            continuarAnalisis = false;
        }
        private void ProcesarEstado86()
        {
            DevolverPuntero();
            categoria = CategoriaGramatical.EsOGuionBajo;
            continuarAnalisis = false;
        }
        private void ProcesarEstado87()
        {
            DevolverPuntero();
            categoria = CategoriaGramatical.EsTilde;
            continuarAnalisis = false;
        }
        private void ProcesarEstado88()
        {
            DevolverPuntero();
            categoria = CategoriaGramatical.EsComillaBajaAbre;
            continuarAnalisis = false;
        }
        private void ProcesarEstado89()
        {
            DevolverPuntero();
            categoria = CategoriaGramatical.EsComillaBajaCierra;
            continuarAnalisis = false;
        }
        private void ProcesarEstado90()
        {
            DevolverPuntero();
            categoria = CategoriaGramatical.EsEspacioEnBlanco;
            continuarAnalisis = false;
        }
        private void ProcesarEstado91()
        {
            categoria = CategoriaGramatical.FIN_ARCHIVO;
            lexema = "@EOF@";
            //FormarComponenteLexicoLiteral();
            continuarAnalisis = false;
        }
        private void ProcesarEstado92()
        {
            CargarNuevaLinea();
            Resetear();
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
        private void ReportarErrorLexicoRecuperable()
        {
            posicionInicial = puntero - lexema.Length;
            Error error = Error.CREAR_ERROR_LEXICO_RECUPERABLE(numeroLineaActual, posicionInicial, lexema, falla, causa, solucion);
            ManejadorErrores.ObtenerManejadorErrores().ReportarError(error);

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
