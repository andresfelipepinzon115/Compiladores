﻿using ComiladorTraductor.Cache;
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
    public class AnalizadorLexicoNumero
    {
        private string contenidoLineaActual = "";
        private int numeroLineaActual = 0;
        private int puntero = 0;
        private string caracterActual = "";
        private string lexema = "";
        private CategoriaGramatical categoria = CategoriaGramatical.DEFECTO;
        private string estadoActual = "q0";
        private int posicionInicial = 0;
        private int posicionFinal = 0;
        private bool continuarAnalisis = false;
        private ComponenteLexico componente = null;
        private TipoComponente tipo = TipoComponente.LITERAL;
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
                posicionInicial = 0;
                posicionFinal = 0;
                DevorarEspaciosBlanco();

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


        private void Resetear()
        {

            estadoActual = "q0";
            lexema = "";
            categoria = CategoriaGramatical.DEFECTO;
            tipo = TipoComponente.LITERAL;
            posicionInicial = 0;
            posicionFinal = 0;
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
                else
                {
                    ProcesarEstado93();
                }
            }
            TablaMaestra.ObtenerTablaMaestra().Agregar(componente);
            return componente;

        }
        public void ProcesarEstado0()
        {

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
            else if (UtilTexto.EsFinArchivo(caracterActual))
            {
                estadoActual = "q91";
            }
            else if (UtilTexto.EsFinLinea(caracterActual))
            {
                estadoActual = "q92";
            }
            else
            {
                estadoActual = "q93";
            }
        }
        private void ProcesarEstado1()
        {
            posicionInicial = puntero;
            posicionFinal = puntero + lexema.Length;
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
            else
            {
                estadoActual = "q93";
            }
        }
        private void ProcesarEstado2()
        {
            categoria = CategoriaGramatical.EsLetraAa;
            FormarComponenteLexicoSimboloNumero();
        }
        private void ProcesarEstado3()
        {
            categoria = CategoriaGramatical.EsLetraBb;
            FormarComponenteLexicoSimboloNumero();
        }
        private void ProcesarEstado4()
        {
            categoria = CategoriaGramatical.EsLetraCc;
            FormarComponenteLexicoSimboloNumero();
        }
        private void ProcesarEstado5()
        {
            categoria = CategoriaGramatical.EsLetraDd;
            FormarComponenteLexicoSimboloNumero();
        }
        private void ProcesarEstado6()
        {
            categoria = CategoriaGramatical.EsLetraEe;
            FormarComponenteLexicoSimboloNumero();
        }
        private void ProcesarEstado7()
        {
            categoria = CategoriaGramatical.EsLetraFf;
            FormarComponenteLexicoSimboloNumero();
        }
        private void ProcesarEstado8()
        {
            categoria = CategoriaGramatical.EsLetraGg;
            FormarComponenteLexicoSimboloNumero();
        }
        private void ProcesarEstado9()
        {
            categoria = CategoriaGramatical.EsLetraHh;
            FormarComponenteLexicoSimboloNumero();
        }
        private void ProcesarEstado10()
        {
            categoria = CategoriaGramatical.EsLetraIi;
            FormarComponenteLexicoSimboloNumero();
        }


        private void ProcesarEstado11()
        {
            posicionInicial = puntero;
            posicionFinal = puntero + lexema.Length;
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
            else
            {
                estadoActual = "q93";
            }
        }
        private void ProcesarEstado12()
        {
            categoria = CategoriaGramatical.EsLetraJj;
            FormarComponenteLexicoSimboloNumero();
        }
        private void ProcesarEstado13()
        {
            categoria = CategoriaGramatical.EsLetraKk;
            FormarComponenteLexicoSimboloNumero();
        }
        private void ProcesarEstado14()
        {
            categoria = CategoriaGramatical.EsLetraLl;
            FormarComponenteLexicoSimboloNumero();
        }
        private void ProcesarEstado15()
        {
            categoria = CategoriaGramatical.EsLetraMm;
            FormarComponenteLexicoSimboloNumero();
        }
        private void ProcesarEstado16()
        {
            categoria = CategoriaGramatical.EsLetraNn;
            FormarComponenteLexicoSimboloNumero();
        }
        private void ProcesarEstado17()
        {
            categoria = CategoriaGramatical.EsLetraÑñ;
            FormarComponenteLexicoSimboloNumero();
        }
        private void ProcesarEstado18()
        {
            categoria = CategoriaGramatical.EsLetraOo;
            FormarComponenteLexicoSimboloNumero();
        }
        private void ProcesarEstado19()
        {
            categoria = CategoriaGramatical.EsLetraPp;
            FormarComponenteLexicoSimboloNumero();
        }
        private void ProcesarEstado20()
        {
            categoria = CategoriaGramatical.EsLetraQq;
            FormarComponenteLexicoSimboloNumero();
        }
        private void ProcesarEstado21()
        {
            posicionInicial = puntero;
            posicionFinal = puntero + lexema.Length;
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
            else
            {
                estadoActual = "q93";
            }
        }
        private void ProcesarEstado22()
        {
            categoria = CategoriaGramatical.EsLetraRr;
            FormarComponenteLexicoSimboloNumero();
        }
        private void ProcesarEstado23()
        {
            categoria = CategoriaGramatical.EsLetraSs;
            FormarComponenteLexicoSimboloNumero();
        }
        private void ProcesarEstado24()
        {
            categoria = CategoriaGramatical.EsLetraTt;
            FormarComponenteLexicoSimboloNumero();
        }
        private void ProcesarEstado25()
        {
            categoria = CategoriaGramatical.EsLetraUu;
            FormarComponenteLexicoSimboloNumero();
        }
        private void ProcesarEstado26()
        {
            categoria = CategoriaGramatical.EsLetraVv;
            FormarComponenteLexicoSimboloNumero();
        }
        private void ProcesarEstado27()
        {
            categoria = CategoriaGramatical.EsLetraWw;
            FormarComponenteLexicoSimboloNumero();
        }
        private void ProcesarEstado28()
        {
            categoria = CategoriaGramatical.EsLetraXx;
            FormarComponenteLexicoSimboloNumero();
        }
        private void ProcesarEstado29()
        {
            categoria = CategoriaGramatical.EsLetraYy;
            FormarComponenteLexicoSimboloNumero();
        }
        private void ProcesarEstado30()
        {
            categoria = CategoriaGramatical.EsLetraZz;
            FormarComponenteLexicoSimboloNumero();
        }

        private void ProcesarEstado31()
        {
            posicionInicial = puntero;
            posicionFinal = puntero + lexema.Length;
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
            else
            {
                estadoActual = "q93";
            }
        }
        private void ProcesarEstado32()
        {
            categoria = CategoriaGramatical.EsLetraA_TILDE;
            FormarComponenteLexicoSimboloNumero();
        }
        private void ProcesarEstado33()
        {
            categoria = CategoriaGramatical.EsLetraE_TILDE;
            FormarComponenteLexicoSimboloNumero();
        }
        private void ProcesarEstado34()
        {
            categoria = CategoriaGramatical.EsLetraI_TILDE;
            FormarComponenteLexicoSimboloNumero();
        }
        private void ProcesarEstado35()
        {
            categoria = CategoriaGramatical.EsLetraO_TILDE;
            FormarComponenteLexicoSimboloNumero();
        }
        private void ProcesarEstado36()
        {
            categoria = CategoriaGramatical.EsLetraU_TILDE;
            FormarComponenteLexicoSimboloNumero();
        }
        private void ProcesarEstado37()
        {
            categoria = CategoriaGramatical.EsLetraU_DIERESIS;
            FormarComponenteLexicoSimboloNumero();
        }
        private void ProcesarEstado38()
        {
            categoria = CategoriaGramatical.EsDiguito0;
            FormarComponenteLexicoSimboloNumero();
        }
        private void ProcesarEstado39()
        {
            categoria = CategoriaGramatical.EsDiguito1;
            FormarComponenteLexicoSimboloNumero();
        }
        private void ProcesarEstado40()
        {
            categoria = CategoriaGramatical.EsDiguito2;
            FormarComponenteLexicoSimboloNumero();
        }

        private void ProcesarEstado41()
        {
            posicionInicial = puntero;
            posicionFinal = puntero + lexema.Length;
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
            else
            {
                estadoActual = "q93";
            }
        }
        private void ProcesarEstado42()
        {
            categoria = CategoriaGramatical.EsDiguito3;
            FormarComponenteLexicoSimboloNumero();
        }
        private void ProcesarEstado43()
        {
            categoria = CategoriaGramatical.EsDiguito4;
            FormarComponenteLexicoSimboloNumero();
        }
        private void ProcesarEstado44()
        {
            categoria = CategoriaGramatical.EsDiguito5;
            FormarComponenteLexicoSimboloNumero();
        }
        private void ProcesarEstado45()
        {
            categoria = CategoriaGramatical.EsDiguito6;
            FormarComponenteLexicoSimboloNumero();
        }
        private void ProcesarEstado46()
        {
            categoria = CategoriaGramatical.EsDiguito7;
            FormarComponenteLexicoSimboloNumero();
        }
        private void ProcesarEstado47()
        {
            categoria = CategoriaGramatical.EsDiguito8;
            FormarComponenteLexicoSimboloNumero();
        }
        private void ProcesarEstado48()
        {
            categoria = CategoriaGramatical.EsDiguito9;
            FormarComponenteLexicoSimboloNumero();
        }
        private void ProcesarEstado49()
        {
            categoria = CategoriaGramatical.EsComa;
            FormarComponenteLexicoSimboloNumero();
        }
        private void ProcesarEstado50()
        {
            categoria = CategoriaGramatical.EsPuntoYComa;
            FormarComponenteLexicoSimboloNumero();
        }

        private void ProcesarEstado51()
        {
            posicionInicial = puntero;
            posicionFinal = puntero + lexema.Length;
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
            else
            {
                estadoActual = "q93";
            }
        }
        private void ProcesarEstado52()
        {
            categoria = CategoriaGramatical.EsPunto;
            FormarComponenteLexicoSimboloNumero();
        }
        private void ProcesarEstado53()
        {
            categoria = CategoriaGramatical.EsDosPuntos;
            FormarComponenteLexicoSimboloNumero();
        }
        private void ProcesarEstado54()
        {
            categoria = CategoriaGramatical.EsParentesisAbre;
            FormarComponenteLexicoSimboloNumero();
        }
        private void ProcesarEstado55()
        {
            categoria = CategoriaGramatical.EsParentesisCierra;
            FormarComponenteLexicoSimboloNumero();
        }
        private void ProcesarEstado56()
        {
            categoria = CategoriaGramatical.EsCorchetesAbre;
            FormarComponenteLexicoSimboloNumero();
        }
        private void ProcesarEstado57()
        {
            categoria = CategoriaGramatical.EsCorchetesCierra;
            FormarComponenteLexicoSimboloNumero();
        }
        private void ProcesarEstado58()
        {
            categoria = CategoriaGramatical.EsLlavesAbre;
            FormarComponenteLexicoSimboloNumero();
        }
        private void ProcesarEstado59()
        {
            categoria = CategoriaGramatical.EsLlavesCierra;
            FormarComponenteLexicoSimboloNumero();
        }
        private void ProcesarEstado60()
        {
            categoria = CategoriaGramatical.EsNumeral;
            FormarComponenteLexicoSimboloNumero();
        }
        private void ProcesarEstado61()
        {
            posicionInicial = puntero;
            posicionFinal = puntero + lexema.Length;
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
            else
            {
                estadoActual = "q93";
            }
        }
        private void ProcesarEstado62()
        {
            categoria = CategoriaGramatical.EsPeso;
            FormarComponenteLexicoSimboloNumero();
        }
        private void ProcesarEstado63()
        {
            categoria = CategoriaGramatical.EsUmpersand;
            FormarComponenteLexicoSimboloNumero();
        }
        private void ProcesarEstado64()
        {
            categoria = CategoriaGramatical.EsArroba;
            FormarComponenteLexicoSimboloNumero();
        }
        private void ProcesarEstado65()
        {
            categoria = CategoriaGramatical.EsSuma;
            FormarComponenteLexicoSimboloNumero();
        }
        private void ProcesarEstado66()
        {
            categoria = CategoriaGramatical.EsResta;
            FormarComponenteLexicoSimboloNumero();
        }
        private void ProcesarEstado67()
        {
            categoria = CategoriaGramatical.EsMultiplicacion;
            FormarComponenteLexicoSimboloNumero();
        }
        private void ProcesarEstado68()
        {
            categoria = CategoriaGramatical.EsDivision;
            FormarComponenteLexicoSimboloNumero();
        }
        private void ProcesarEstado69()
        {
            categoria = CategoriaGramatical.EsModulo;
            FormarComponenteLexicoSimboloNumero();
        }
        private void ProcesarEstado70()
        {
            categoria = CategoriaGramatical.EsAsignacion;
            FormarComponenteLexicoSimboloNumero();
        }

        private void ProcesarEstado71()
        {
            posicionInicial = puntero;
            posicionFinal = puntero + lexema.Length;
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
            else
            {
                estadoActual = "q93";
            }
        }
        private void ProcesarEstado72()
        {
            categoria = CategoriaGramatical.EsBarraInversa;
            FormarComponenteLexicoSimboloNumero();
        }
        private void ProcesarEstado73()
        {
            categoria = CategoriaGramatical.EsOr;
            FormarComponenteLexicoSimboloNumero();
        }
        private void ProcesarEstado74()
        {
            categoria = CategoriaGramatical.EsComillaDoble;
            FormarComponenteLexicoSimboloNumero();
        }
        private void ProcesarEstado75()
        {
            categoria = CategoriaGramatical.EsComillaSimple;
            FormarComponenteLexicoSimboloNumero();
        }
        private void ProcesarEstado76()
        {
            categoria = CategoriaGramatical.EsPotencia;
            FormarComponenteLexicoSimboloNumero();
        }
        private void ProcesarEstado77()
        {
            categoria = CategoriaGramatical.EsAdmiracionAbre;
            FormarComponenteLexicoSimboloNumero();
        }
        private void ProcesarEstado78()
        {
            categoria = CategoriaGramatical.EsAdmiracionCierra;
            FormarComponenteLexicoSimboloNumero();
        }
        private void ProcesarEstado79()
        {
            categoria = CategoriaGramatical.EsPreguntaAbre;
            FormarComponenteLexicoSimboloNumero();
        }
        private void ProcesarEstado80()
        {
            categoria = CategoriaGramatical.EsPreguntaCierra;
            FormarComponenteLexicoSimboloNumero();
        }
        private void ProcesarEstado81()
        {
            posicionInicial = puntero;
            posicionFinal = puntero + lexema.Length;
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
            else
            {
                estadoActual = "q93";
            }
        }
        private void ProcesarEstado82()
        {
            categoria = CategoriaGramatical.EsGionBajo;
            FormarComponenteLexicoSimboloNumero();
        }
        private void ProcesarEstado83()
        {
            categoria = CategoriaGramatical.EsMayorQue;
            FormarComponenteLexicoSimboloNumero();
        }
        private void ProcesarEstado84()
        {
            categoria = CategoriaGramatical.EsMenorQue;
            FormarComponenteLexicoSimboloNumero();
        }
        private void ProcesarEstado85()
        {
            categoria = CategoriaGramatical.EsAGuionBajo;
            FormarComponenteLexicoSimboloNumero();
        }
        private void ProcesarEstado86()
        {
            categoria = CategoriaGramatical.EsOGuionBajo;
            FormarComponenteLexicoSimboloNumero();
        }
        private void ProcesarEstado87()
        {
            categoria = CategoriaGramatical.EsTilde;
            FormarComponenteLexicoSimboloNumero();
        }
        private void ProcesarEstado88()
        {
            categoria = CategoriaGramatical.EsComillaBajaAbre;
            FormarComponenteLexicoSimboloNumero();
        }
        private void ProcesarEstado89()
        {
            categoria = CategoriaGramatical.EsComillaBajaCierra;
            FormarComponenteLexicoSimboloNumero();
        }
        private void ProcesarEstado90()
        {
            categoria = CategoriaGramatical.EsEspacioEnBlanco;
            FormarComponenteLexicoSimboloNumero();
        }
        private void ProcesarEstado91()
        {
            lexema = "@EOF@";
            categoria = CategoriaGramatical.FIN_ARCHIVO;
            FormarComponenteLexicoLiteral();
            continuarAnalisis = false;

        }
        private void ProcesarEstado92()
        {
            categoria = CategoriaGramatical.FIN_LINEA;
            Resetear();
            CargarNuevaLinea();

        }
        private void ProcesarEstado93()
        {
            //ERROR SIMBOLO NO VALIDO
            falla = "Simbolo no valido";
            causa = " se recibió el simbolo no reconocido por el lenguaje  " + caracterActual;
            solucion = "Asegurese que en la posicion esperada  se encuentre un numero entero que vaya de 1 a 9";
            ReportarErrorLexicoStopper();
        }

        private void FormarComponenteLexicoSimboloNumero()
        {
           
            Concatenar();
            FormarComponenteLexicoLiteral();
            EspacioEntreNumeros();
            continuarAnalisis = false;
        }

        private void FormarComponenteLexicoLiteral()
        {
            if ("@EOF@".Equals(caracterActual))
            {
                posicionInicial = 1;
                posicionFinal = posicionInicial + 1;
            }
            else if ("@FL@".Equals(caracterActual))
            {
                posicionInicial = 1;
                posicionFinal = posicionInicial + (lexema.Length - 4);
            }
            else
            {
                posicionInicial = puntero - lexema.Length;
                posicionFinal = posicionInicial + lexema.Length;
            }
            componente = ComponenteLexico.Crear(numeroLineaActual, posicionInicial, posicionFinal, lexema, categoria, tipo);

        }

        private void ReportarErrorLexicoStopper()
        {
            posicionInicial = puntero - lexema.Length;
            posicionFinal = posicionInicial + lexema.Length;
            Error error = Error.CrearErrorLexicoStopper(numeroLineaActual, posicionInicial, posicionFinal, lexema, falla, causa, solucion);
            ManejadorTodosErrores.ObtenerManejadorDeErrores().ReportarError(error);
        }
        private void DevorarEspaciosBlanco()
        {
            LeerSiguienteCaracter();
            while (" ".Equals(caracterActual))
            {
                LeerSiguienteCaracter();
            }
        }
        private void ErrorEspacios()
        {
            falla = "el caracter que se encuentra no es el esperado";
            causa = "Se esperaba un solo espacio y por ende se encontro " + caracterActual;
            solucion = "Corrija los espacios para que esto funcionen ";
            ReportarErrorLexicoStopper();
        }
        private void EspacioEntreNumeros()
        {
            LeerSiguienteCaracter();
            if (UtilTexto.EsEspacioEnBlanco(caracterActual))
            {
                LeerSiguienteCaracter();

            }
            else if (!UtilTexto.EsFinArchivo(caracterActual) && !UtilTexto.EsFinLinea(caracterActual))
            {
                ErrorEspacios();
            }
        }
    }
}
