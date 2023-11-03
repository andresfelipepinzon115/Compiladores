using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompiladoExtraClase.Cache;
using CompiladoExtraClase.ErrorManagement;
using CompiladoExtraClase.TablaComponentes;
using CompiladoExtraClase.Util;


namespace CompiladoExtraClase.LexicalAnalysis
{
    public class AnalizadorLexicoPunto
    {
        private string contenidoLineaActual = "";
        private int numeroLineaActual = 0;
        private int puntero = 0;
        private string caracterActual = "";
        private string lexema = "";
        private string estadoActual = "q0";
        private int posicionInicial = 0;
        //private int posicionFinal = 0;
        private bool continuarAnalisis = false;
        public string test = "";
        private CategoriaGramatical categoria = CategoriaGramatical.DEFECTO;
        private ComponenteLexico componente = null;
        private TipoComponente tipo = TipoComponente.LITERAL;
        private string falla = "";
        private string causa = "";
        private string solucion = "";



        public AnalizadorLexicoPunto()
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
            posicionInicial = 0;
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
                else if ("q93".Equals(estadoActual))
                {
                    ProcesarEstado93();
                }
                else if ("q94".Equals(estadoActual))
                {
                    ProcesarEstado94();
                }
                else if ("q95".Equals(estadoActual))
                {
                    ProcesarEstado95();
                }
                else if ("q96".Equals(estadoActual))
                {
                    ProcesarEstado96();
                }
                else if ("q97".Equals(estadoActual))
                {
                    ProcesarEstado97();
                }
                else if ("q98".Equals(estadoActual))
                {
                    ProcesarEstado98();
                }
                else if ("q99".Equals(estadoActual))
                {
                    ProcesarEstado99();
                }
                else if ("q100".Equals(estadoActual))
                {
                    ProcesarEstado100();
                }
                else if ("q101".Equals(estadoActual))
                {
                    ProcesarEstado101();
                }
                else if ("q102".Equals(estadoActual))
                {
                    ProcesarEstado102();
                }
                else if ("q103".Equals(estadoActual))
                {
                    ProcesarEstado103();
                }
                else if ("q104".Equals(estadoActual))
                {
                    ProcesarEstado104();
                }
                else if ("q105".Equals(estadoActual))
                {
                    ProcesarEstado105();
                }
                else if ("q106".Equals(estadoActual))
                {
                    ProcesarEstado106();
                }
                else if ("q107".Equals(estadoActual))
                {
                    ProcesarEstado107();
                }
                else if ("q108".Equals(estadoActual))
                {
                    ProcesarEstado108();
                }
                else if ("q109".Equals(estadoActual))
                {
                    ProcesarEstado109();
                }
                else if ("q111".Equals(estadoActual))
                {
                    ProcesarEstado111();
                }
                else if ("q112".Equals(estadoActual))
                {
                    ProcesarEstado112();
                }
                else if ("q113".Equals(estadoActual))
                {
                    ProcesarEstado113();
                }
                else if ("q114".Equals(estadoActual))
                {
                    ProcesarEstado114();
                }
                else if ("q115".Equals(estadoActual))
                {
                    ProcesarEstado115();
                }
                else if ("q116".Equals(estadoActual))
                {
                    ProcesarEstado116();
                }
                else if ("q117".Equals(estadoActual))
                {
                    ProcesarEstado117();
                }
                else if ("q118".Equals(estadoActual))
                {
                    ProcesarEstado118();
                }
                else if ("q119".Equals(estadoActual))
                {
                    ProcesarEstado119();
                }
                else if ("q120".Equals(estadoActual))
                {
                    ProcesarEstado120();
                }
                else if ("q121".Equals(estadoActual))
                {
                    ProcesarEstado121();
                }
                else if ("q122".Equals(estadoActual))
                {
                    ProcesarEstado122();
                }
                else if ("q123".Equals(estadoActual))
                {
                    ProcesarEstado123();
                }
                else if ("q124".Equals(estadoActual))
                {
                    ProcesarEstado124();
                }
                else if ("q125".Equals(estadoActual))
                {
                    ProcesarEstado125();
                }
                else if ("q126".Equals(estadoActual))
                {
                    ProcesarEstado126();
                }
                else if ("q127".Equals(estadoActual))
                {
                    ProcesarEstado127();
                }

                else if ("q129".Equals(estadoActual))
                {
                    ProcesarEstado129();
                }
                else if ("q130".Equals(estadoActual))
                {
                    ProcesarEstado130();
                }
                else if ("q131".Equals(estadoActual))
                {
                    ProcesarEstado131();
                }
                else if ("q132".Equals(estadoActual))
                {
                    ProcesarEstado132();
                }
                else if ("q133".Equals(estadoActual))
                {
                    ProcesarEstado133();
                }
                else if ("q134".Equals(estadoActual))
                {
                    ProcesarEstado134();
                }
                else if ("q135".Equals(estadoActual))
                {
                    ProcesarEstado135();
                }
                else if ("q136".Equals(estadoActual))
                {
                    ProcesarEstado136();
                }
                else if ("q138".Equals(estadoActual))
                {
                    ProcesarEstado138();
                }
                else if ("q139".Equals(estadoActual))
                {
                    ProcesarEstado139();
                }
                else if ("q140".Equals(estadoActual))
                {
                    ProcesarEstado140();
                }
                else if ("q141".Equals(estadoActual))
                {
                    ProcesarEstado141();
                }
                else if ("q142".Equals(estadoActual))
                {
                    ProcesarEstado142();
                }
                else if ("q143".Equals(estadoActual))
                {
                    ProcesarEstado143();
                }
                else if ("q144".Equals(estadoActual))
                {
                    ProcesarEstado144();
                }
                else if ("q145".Equals(estadoActual))
                {
                    ProcesarEstado145();
                }
                else if ("q147".Equals(estadoActual))
                {
                    ProcesarEstado147();
                }
                else if ("q148".Equals(estadoActual))
                {
                    ProcesarEstado148();
                }
                else if ("q149".Equals(estadoActual))
                {
                    ProcesarEstado149();
                }
                else if ("q150".Equals(estadoActual))
                {
                    ProcesarEstado150();
                }
                else if ("q151".Equals(estadoActual))
                {
                    ProcesarEstado151();
                }
                else if ("q152".Equals(estadoActual))
                {
                    ProcesarEstado152();
                }
                else if ("q153".Equals(estadoActual))
                {
                    ProcesarEstado153();
                }
                else if ("q154".Equals(estadoActual))
                {
                    ProcesarEstado154();
                }
                else if ("q156".Equals(estadoActual))
                {
                    ProcesarEstado156();
                }
                else if ("q157".Equals(estadoActual))
                {
                    ProcesarEstado157();
                }
                else if ("q158".Equals(estadoActual))
                {
                    ProcesarEstado158();
                }
                else if ("q159".Equals(estadoActual))
                {
                    ProcesarEstado159();
                }
                else if ("q160".Equals(estadoActual))
                {
                    ProcesarEstado160();
                }
                else if ("q161".Equals(estadoActual))
                {
                    ProcesarEstado161();
                }
                else if ("q162".Equals(estadoActual))
                {
                    ProcesarEstado162();
                }
                else if ("q163".Equals(estadoActual))
                {
                    ProcesarEstado163();
                }
                else if ("q165".Equals(estadoActual))
                {
                    ProcesarEstado165();
                }
                else if ("q166".Equals(estadoActual))
                {
                    ProcesarEstado166();
                }
                else if ("q167".Equals(estadoActual))
                {
                    ProcesarEstado167();
                }
                else if ("q168".Equals(estadoActual))
                {
                    ProcesarEstado168();
                }
                else if ("q169".Equals(estadoActual))
                {
                    ProcesarEstado169();
                }
                else if ("q170".Equals(estadoActual))
                {
                    ProcesarEstado170();
                }
                else if ("q171".Equals(estadoActual))
                {
                    ProcesarEstado171();
                }
                else if ("q172".Equals(estadoActual))
                {
                    ProcesarEstado172();
                }
                else if ("q174".Equals(estadoActual))
                {
                    ProcesarEstado174();
                }
                else if ("q175".Equals(estadoActual))
                {
                    ProcesarEstado175();
                }
                else if ("q176".Equals(estadoActual))
                {
                    ProcesarEstado176();
                }
                else if ("q177".Equals(estadoActual))
                {
                    ProcesarEstado177();
                }
                else if ("q178".Equals(estadoActual))
                {
                    ProcesarEstado178();
                }
                else if ("q179".Equals(estadoActual))
                {
                    ProcesarEstado179();
                }
                else if ("q180".Equals(estadoActual))
                {
                    ProcesarEstado180();
                }
                else if ("q181".Equals(estadoActual))
                {
                    ProcesarEstado181();
                }
                else if ("q182".Equals(estadoActual))
                {
                    ProcesarEstado182();
                }
                else if ("q183".Equals(estadoActual))
                {
                    ProcesarEstado183();
                }

            }
            TablaMaestra.ObtenerTablaMaestra().Agregar(componente);
            return componente;
        }

        public void ProcesarEstado0()
        {
            DevorarEspaciosBlanco();
            if (UtilTexto.EsPunto(caracterActual))
            {
                estadoActual = "q1";
            }
            else if (UtilTexto.EsFinArchivo(caracterActual))
            {
                estadoActual = "q100";
            }
            else if (UtilTexto.EsFinLinea(caracterActual))
            {
                estadoActual = "q101";
            }
            else
            {
                estadoActual = "q183";
            }
        }
        public void ProcesarEstado1()
        {
            
            LeerSiguienteCaracter();
            if (UtilTexto.EsPunto(caracterActual))
            {
                estadoActual = "q2";
            }
            else if (UtilTexto.EsEspacioEnBlanco(caracterActual))
            {
                estadoActual = "q90";
            }
            else
            {
                estadoActual = "q183";
            }
        }
        public void ProcesarEstado2()
        {
            
            LeerSiguienteCaracter();
            if (UtilTexto.EsPunto(caracterActual))
            {
                estadoActual = "q3";
            }
            else if (UtilTexto.EsEspacioEnBlanco(caracterActual))
            {
                estadoActual = "q80";
            }
            else
            {
                estadoActual = "q183";
            }
        }
        public void ProcesarEstado3()
        {
            
            LeerSiguienteCaracter();
            if (UtilTexto.EsPunto(caracterActual))
            {
                estadoActual = "q4";
            }
            else if (UtilTexto.EsEspacioEnBlanco(caracterActual))
            {
                estadoActual = "q70";
            }
            else
            {
                estadoActual = "q183";
            }
        }
        public void ProcesarEstado4()
        {
            
            LeerSiguienteCaracter();
            if (UtilTexto.EsPunto(caracterActual))
            {
                estadoActual = "q5";
            }
            else if (UtilTexto.EsEspacioEnBlanco(caracterActual))
            {
                estadoActual = "q60";
            }
            else
            {
                estadoActual = "q183";
            }
        }
        public void ProcesarEstado5()
        {
            
            LeerSiguienteCaracter();
            if (UtilTexto.EsPunto(caracterActual))
            {
                estadoActual = "q6";
            }
            else if (UtilTexto.EsEspacioEnBlanco(caracterActual))
            {
                estadoActual = "q50";
            }
            else
            {
                estadoActual = "q183";
            }
        }
        public void ProcesarEstado6()
        {
           
            LeerSiguienteCaracter();
            if (UtilTexto.EsPunto(caracterActual))
            {
                estadoActual = "q7";
            }
            else if (UtilTexto.EsEspacioEnBlanco(caracterActual))
            {
                estadoActual = "q40";
            }
            else
            {
                estadoActual = "q183";
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
            else
            {
                estadoActual = "q183";
            }
        }
        public void ProcesarEstado8()
        {
            
            LeerSiguienteCaracter();
            if (UtilTexto.EsPunto(caracterActual))
            {
                estadoActual = "q9";
            }
            else if (UtilTexto.EsEspacioEnBlanco(caracterActual))
            {
                estadoActual = "q20";
            }
            else
            {
                estadoActual = "q183";
            }
        }
        public void ProcesarEstado9()
        {
            
            LeerSiguienteCaracter();
            if (UtilTexto.EsEspacioEnBlanco(caracterActual))
            {
                estadoActual = "q10";
            }
            else
            {
                estadoActual = "q183";
            }
        }
        public void ProcesarEstado10()
        {
            
            LeerSiguienteCaracter();
            if (UtilTexto.EsPunto(caracterActual))
            {
                estadoActual = "q11";
            }
            else
            {
                estadoActual = "q182";
            }

        }
        public void ProcesarEstado11()
        {
            
            LeerSiguienteCaracter();
            if (UtilTexto.EsPunto(caracterActual))
            {
                estadoActual = "q12";
            }
            else if (!UtilTexto.EsPunto(caracterActual) && !UtilTexto.EsVacio(caracterActual))
            {
                estadoActual = "q182";
            }
            else
            {
                estadoActual = "q102";
            }

        }
        public void ProcesarEstado12()
        {
            
            LeerSiguienteCaracter();
            if (UtilTexto.EsPunto(caracterActual))
            {
                estadoActual = "q13";
            }
            else if (!UtilTexto.EsPunto(caracterActual) && !UtilTexto.EsVacio(caracterActual))
            {
                estadoActual = "q182";
            }
            else
            {
                estadoActual = "q103";
            }

        }
        public void ProcesarEstado13()
        {
           
            LeerSiguienteCaracter();
            if (UtilTexto.EsPunto(caracterActual))
            {
                estadoActual = "q14";
            }
            else if (!UtilTexto.EsPunto(caracterActual) && !UtilTexto.EsVacio(caracterActual))
            {
                estadoActual = "q182";
            }
            else
            {
                estadoActual = "q104";
            }

        }
        public void ProcesarEstado14()
        {
           
            LeerSiguienteCaracter();
            if (UtilTexto.EsPunto(caracterActual))
            {
                estadoActual = "q15";
            }
            else if (!UtilTexto.EsPunto(caracterActual) && !UtilTexto.EsVacio(caracterActual))
            {
                estadoActual = "q182";
            }
            else
            {
                estadoActual = "q105";
            }

        }
        public void ProcesarEstado15()
        {
            
            LeerSiguienteCaracter();
            if (UtilTexto.EsPunto(caracterActual))
            {
                estadoActual = "q16";
            }
            else if (!UtilTexto.EsPunto(caracterActual) && !UtilTexto.EsVacio(caracterActual))
            {
                estadoActual = "q182";
            }
            else
            {
                estadoActual = "q106";
            }

        }
        public void ProcesarEstado16()
        {
            
            LeerSiguienteCaracter();
            if (UtilTexto.EsPunto(caracterActual))
            {
                estadoActual = "q17";
            }
            else if (!UtilTexto.EsPunto(caracterActual) && !UtilTexto.EsVacio(caracterActual))
            {
                estadoActual = "q182";
            }
            else
            {
                estadoActual = "q107";
            }

        }
        public void ProcesarEstado17()
        {
            LeerSiguienteCaracter();
            if (UtilTexto.EsPunto(caracterActual))
            {
                estadoActual = "q18";
            }
            else if (!UtilTexto.EsPunto(caracterActual) && !UtilTexto.EsVacio(caracterActual))
            {
                estadoActual = "q182";
            }
            else
            {
                estadoActual = "q108";
            }

        }
        public void ProcesarEstado18()
        {
            LeerSiguienteCaracter();
            if (UtilTexto.EsPunto(caracterActual))
            {
                estadoActual = "q19";
            }
            else if (!UtilTexto.EsPunto(caracterActual) && !UtilTexto.EsVacio(caracterActual))
            {
                estadoActual = "q182";
            }
            else
            {
                estadoActual = "q109";
            }

        }
        public void ProcesarEstado19()
        {
            categoria = CategoriaGramatical.EsEspacioEnBlanco;
            FormarComponenteLexicoSimboloPunto();
        }
        public void ProcesarEstado20()
        {
            LeerSiguienteCaracter();
            if (UtilTexto.EsPunto(caracterActual))
            {
                estadoActual = "q21";
            }
            else
            {
                estadoActual = "q182";
            }

        }
        public void ProcesarEstado21()
        {
            LeerSiguienteCaracter();
            if (UtilTexto.EsPunto(caracterActual))
            {
                estadoActual = "q22";
            }
            else if (!UtilTexto.EsPunto(caracterActual) && !UtilTexto.EsVacio(caracterActual))
            {
                estadoActual = "q182";
            }
            else
            {
                estadoActual = "q111";
            }

        }
        public void ProcesarEstado22()
        {
            LeerSiguienteCaracter();
            if (UtilTexto.EsPunto(caracterActual))
            {
                estadoActual = "q23";
            }
            else if (!UtilTexto.EsPunto(caracterActual) && !UtilTexto.EsVacio(caracterActual))
            {
                estadoActual = "q182";
            }
            else
            {
                estadoActual = "q112";
            }

        }
        public void ProcesarEstado23()
        {
            LeerSiguienteCaracter();
            if (UtilTexto.EsPunto(caracterActual))
            {
                estadoActual = "q24";
            }
            else if (!UtilTexto.EsPunto(caracterActual) && !UtilTexto.EsVacio(caracterActual))
            {
                estadoActual = "q182";
            }
            else
            {
                estadoActual = "q113";
            }

        }
        public void ProcesarEstado24()
        {
            LeerSiguienteCaracter();
            if (UtilTexto.EsPunto(caracterActual))
            {
                estadoActual = "q25";
            }
            else if (!UtilTexto.EsPunto(caracterActual) && !UtilTexto.EsVacio(caracterActual))
            {
                estadoActual = "q182";
            }
            else
            {
                estadoActual = "q114";
            }

        }
        public void ProcesarEstado25()
        {
            LeerSiguienteCaracter();
            if (UtilTexto.EsPunto(caracterActual))
            {
                estadoActual = "q26";
            }
            else if (!UtilTexto.EsPunto(caracterActual) && !UtilTexto.EsVacio(caracterActual))
            {
                estadoActual = "q182";
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
            else if (!UtilTexto.EsPunto(caracterActual) && !UtilTexto.EsVacio(caracterActual))
            {
                estadoActual = "q182";
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
            else if (!UtilTexto.EsPunto(caracterActual) && !UtilTexto.EsVacio(caracterActual))
            {
                estadoActual = "q182";
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
            else if (!UtilTexto.EsPunto(caracterActual) && !UtilTexto.EsVacio(caracterActual))
            {
                estadoActual = "q182";
            }
            else
            {
                estadoActual = "q118";
            }

        }
        public void ProcesarEstado29()
        {
            categoria = CategoriaGramatical.EsEspacioEnBlanco;
            FormarComponenteLexicoSimboloPunto();
        }
        public void ProcesarEstado30()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (UtilTexto.EsPunto(caracterActual))
            {
                estadoActual = "q31";
            }
            else
            {
                estadoActual = "q182";
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
            else if (!UtilTexto.EsPunto(caracterActual) && !UtilTexto.EsVacio(caracterActual))
            {
                estadoActual = "q182";
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
            else if (!UtilTexto.EsPunto(caracterActual) && !UtilTexto.EsVacio(caracterActual))
            {
                estadoActual = "q182";
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
            else if (!UtilTexto.EsPunto(caracterActual) && !UtilTexto.EsVacio(caracterActual))
            {
                estadoActual = "q182";
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
            else if (!UtilTexto.EsPunto(caracterActual) && !UtilTexto.EsVacio(caracterActual))
            {
                estadoActual = "q182";
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
            else if (!UtilTexto.EsPunto(caracterActual) && !UtilTexto.EsVacio(caracterActual))
            {
                estadoActual = "q182";
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
            else if (!UtilTexto.EsPunto(caracterActual) && !UtilTexto.EsVacio(caracterActual))
            {
                estadoActual = "q182";
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
            else if (!UtilTexto.EsPunto(caracterActual) && !UtilTexto.EsVacio(caracterActual))
            {
                estadoActual = "q182";
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
            else if (!UtilTexto.EsPunto(caracterActual) && !UtilTexto.EsVacio(caracterActual))
            {
                estadoActual = "q182";
            }
            else
            {
                estadoActual = "q127";
            }

        }
        public void ProcesarEstado39()
        {
            categoria = CategoriaGramatical.EsAsignacion;
            FormarComponenteLexicoSimboloPunto();
        }
        public void ProcesarEstado40()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (UtilTexto.EsPunto(caracterActual))
            {
                estadoActual = "q41";
            }
            else
            {
                estadoActual = "q182";
            }

        }
        public void ProcesarEstado41()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (UtilTexto.EsPunto(caracterActual))
            {
                estadoActual = "q42";
            }
            else if (!UtilTexto.EsPunto(caracterActual) && !UtilTexto.EsVacio(caracterActual))
            {
                estadoActual = "q182";
            }
            else
            {
                estadoActual = "q129";
            }

        }
        public void ProcesarEstado42()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (UtilTexto.EsPunto(caracterActual))
            {
                estadoActual = "q43";
            }
            else if (!UtilTexto.EsPunto(caracterActual) && !UtilTexto.EsVacio(caracterActual))
            {
                estadoActual = "q182";
            }
            else
            {
                estadoActual = "q130";
            }

        }
        public void ProcesarEstado43()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (UtilTexto.EsPunto(caracterActual))
            {
                estadoActual = "q44";
            }
            else if (!UtilTexto.EsPunto(caracterActual) && !UtilTexto.EsVacio(caracterActual))
            {
                estadoActual = "q182";
            }
            else
            {
                estadoActual = "q131";
            }

        }
        public void ProcesarEstado44()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (UtilTexto.EsPunto(caracterActual))
            {
                estadoActual = "q45";
            }
            else if (!UtilTexto.EsPunto(caracterActual) && !UtilTexto.EsVacio(caracterActual))
            {
                estadoActual = "q182";
            }
            else
            {
                estadoActual = "q132";
            }

        }
        public void ProcesarEstado45()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (UtilTexto.EsPunto(caracterActual))
            {
                estadoActual = "q46";
            }
            else if (!UtilTexto.EsPunto(caracterActual) && !UtilTexto.EsVacio(caracterActual))
            {
                estadoActual = "q182";
            }
            else
            {
                estadoActual = "q133";
            }

        }
        public void ProcesarEstado46()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (UtilTexto.EsPunto(caracterActual))
            {
                estadoActual = "q47";
            }
            else if (!UtilTexto.EsPunto(caracterActual) && !UtilTexto.EsVacio(caracterActual))
            {
                estadoActual = "q182";
            }
            else
            {
                estadoActual = "q134";
            }

        }
        public void ProcesarEstado47()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (UtilTexto.EsPunto(caracterActual))
            {
                estadoActual = "q48";
            }
            else if (!UtilTexto.EsPunto(caracterActual) && !UtilTexto.EsVacio(caracterActual))
            {
                estadoActual = "q182";
            }
            else
            {
                estadoActual = "q135";
            }

        }
        public void ProcesarEstado48()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (UtilTexto.EsPunto(caracterActual))
            {
                estadoActual = "q49";
            }
            else if (!UtilTexto.EsPunto(caracterActual) && !UtilTexto.EsVacio(caracterActual))
            {
                estadoActual = "q182";
            }
            else
            {
                estadoActual = "q136";
            }

        }
        public void ProcesarEstado49()
        {
            categoria = CategoriaGramatical.EsNumeral;
            FormarComponenteLexicoSimboloPunto();
        }
        public void ProcesarEstado50()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (UtilTexto.EsPunto(caracterActual))
            {
                estadoActual = "q51";
            }
            else
            {
                estadoActual = "q182";
            }

        }
        public void ProcesarEstado51()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (UtilTexto.EsPunto(caracterActual))
            {
                estadoActual = "q52";
            }
            else if (!UtilTexto.EsPunto(caracterActual) && !UtilTexto.EsVacio(caracterActual))
            {
                estadoActual = "q182";
            }
            else
            {
                estadoActual = "q138";
            }

        }
        public void ProcesarEstado52()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (UtilTexto.EsPunto(caracterActual))
            {
                estadoActual = "q53";
            }
            else if (!UtilTexto.EsPunto(caracterActual) && !UtilTexto.EsVacio(caracterActual))
            {
                estadoActual = "q182";
            }
            else
            {
                estadoActual = "q139";
            }

        }
        public void ProcesarEstado53()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (UtilTexto.EsPunto(caracterActual))
            {
                estadoActual = "q54";
            }
            else if (!UtilTexto.EsPunto(caracterActual) && !UtilTexto.EsVacio(caracterActual))
            {
                estadoActual = "q182";
            }
            else
            {
                estadoActual = "q140";
            }

        }
        public void ProcesarEstado54()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (UtilTexto.EsPunto(caracterActual))
            {
                estadoActual = "q55";
            }
            else if (!UtilTexto.EsPunto(caracterActual) && !UtilTexto.EsVacio(caracterActual))
            {
                estadoActual = "q182";
            }
            else
            {
                estadoActual = "q141";
            }

        }
        public void ProcesarEstado55()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (UtilTexto.EsPunto(caracterActual))
            {
                estadoActual = "q56";
            }
            else if (!UtilTexto.EsPunto(caracterActual) && !UtilTexto.EsVacio(caracterActual))
            {
                estadoActual = "q182";
            }
            else
            {
                estadoActual = "q142";
            }

        }
        public void ProcesarEstado56()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (UtilTexto.EsPunto(caracterActual))
            {
                estadoActual = "q57";
            }
            else if (!UtilTexto.EsPunto(caracterActual) && !UtilTexto.EsVacio(caracterActual))
            {
                estadoActual = "q182";
            }
            else
            {
                estadoActual = "q143";
            }

        }
        public void ProcesarEstado57()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (UtilTexto.EsPunto(caracterActual))
            {
                estadoActual = "q58";
            }
            else if (!UtilTexto.EsPunto(caracterActual) && !UtilTexto.EsVacio(caracterActual))
            {
                estadoActual = "q182";
            }
            else
            {
                estadoActual = "q144";
            }

        }
        public void ProcesarEstado58()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (UtilTexto.EsPunto(caracterActual))
            {
                estadoActual = "q59";
            }
            else if (!UtilTexto.EsPunto(caracterActual) && !UtilTexto.EsVacio(caracterActual))
            {
                estadoActual = "q182";
            }
            else
            {
                estadoActual = "q145";
            }

        }
        public void ProcesarEstado59()
        {
            categoria = CategoriaGramatical.EsPuntoYComa;
            FormarComponenteLexicoSimboloPunto();
        }
        public void ProcesarEstado60()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (UtilTexto.EsPunto(caracterActual))
            {
                estadoActual = "q61";
            }
            else
            {
                estadoActual = "q182";
            }

        }
        public void ProcesarEstado61()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (UtilTexto.EsPunto(caracterActual))
            {
                estadoActual = "q62";
            }
            else if (!UtilTexto.EsPunto(caracterActual) && !UtilTexto.EsVacio(caracterActual))
            {
                estadoActual = "q182";
            }
            else
            {
                estadoActual = "q147";
            }

        }
        public void ProcesarEstado62()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (UtilTexto.EsPunto(caracterActual))
            {
                estadoActual = "q63";
            }
            else if (!UtilTexto.EsPunto(caracterActual) && !UtilTexto.EsVacio(caracterActual))
            {
                estadoActual = "q182";
            }
            else
            {
                estadoActual = "q148";
            }

        }
        public void ProcesarEstado63()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (UtilTexto.EsPunto(caracterActual))
            {
                estadoActual = "q64";
            }
            else if (!UtilTexto.EsPunto(caracterActual) && !UtilTexto.EsVacio(caracterActual))
            {
                estadoActual = "q182";
            }
            else
            {
                estadoActual = "q149";
            }

        }
        public void ProcesarEstado64()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (UtilTexto.EsPunto(caracterActual))
            {
                estadoActual = "q65";
            }
            else if (!UtilTexto.EsPunto(caracterActual) && !UtilTexto.EsVacio(caracterActual))
            {
                estadoActual = "q182";
            }
            else
            {
                estadoActual = "q150";
            }

        }
        public void ProcesarEstado65()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (UtilTexto.EsPunto(caracterActual))
            {
                estadoActual = "q66";
            }
            else if (!UtilTexto.EsPunto(caracterActual) && !UtilTexto.EsVacio(caracterActual))
            {
                estadoActual = "q182";
            }
            else
            {
                estadoActual = "q151";
            }

        }
        public void ProcesarEstado66()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (UtilTexto.EsPunto(caracterActual))
            {
                estadoActual = "q67";
            }
            else if (!UtilTexto.EsPunto(caracterActual) && !UtilTexto.EsVacio(caracterActual))
            {
                estadoActual = "q182";
            }
            else
            {
                estadoActual = "q152";
            }

        }
        public void ProcesarEstado67()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (UtilTexto.EsPunto(caracterActual))
            {
                estadoActual = "q68";
            }
            else if (!UtilTexto.EsPunto(caracterActual) && !UtilTexto.EsVacio(caracterActual))
            {
                estadoActual = "q182";
            }
            else
            {
                estadoActual = "q153";
            }

        }
        public void ProcesarEstado68()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (UtilTexto.EsPunto(caracterActual))
            {
                estadoActual = "q69";
            }
            else if (!UtilTexto.EsPunto(caracterActual) && !UtilTexto.EsVacio(caracterActual))
            {
                estadoActual = "q182";
            }
            else
            {
                estadoActual = "q154";
            }

        }
        public void ProcesarEstado69()
        {
            categoria = CategoriaGramatical.EsDiguito2;
            FormarComponenteLexicoSimboloPunto();
        }
        public void ProcesarEstado70()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (UtilTexto.EsPunto(caracterActual))
            {
                estadoActual = "q71";
            }
            else
            {
                estadoActual = "q182";
            }

        }
        public void ProcesarEstado71()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (UtilTexto.EsPunto(caracterActual))
            {
                estadoActual = "q72";
            }
            else if (!UtilTexto.EsPunto(caracterActual) && !UtilTexto.EsVacio(caracterActual))
            {
                estadoActual = "q182";
            }
            else
            {
                estadoActual = "q156";
            }

        }
        public void ProcesarEstado72()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (UtilTexto.EsPunto(caracterActual))
            {
                estadoActual = "q73";
            }
            else if (!UtilTexto.EsPunto(caracterActual) && !UtilTexto.EsVacio(caracterActual))
            {
                estadoActual = "q182";
            }
            else
            {
                estadoActual = "q157";
            }

        }
        public void ProcesarEstado73()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (UtilTexto.EsPunto(caracterActual))
            {
                estadoActual = "q74";
            }
            else if (!UtilTexto.EsPunto(caracterActual) && !UtilTexto.EsVacio(caracterActual))
            {
                estadoActual = "q182";
            }
            else
            {
                estadoActual = "q158";
            }

        }
        public void ProcesarEstado74()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (UtilTexto.EsPunto(caracterActual))
            {
                estadoActual = "q75";
            }
            else if (!UtilTexto.EsPunto(caracterActual) && !UtilTexto.EsVacio(caracterActual))
            {
                estadoActual = "q182";
            }
            else
            {
                estadoActual = "q159";
            }

        }
        public void ProcesarEstado75()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (UtilTexto.EsPunto(caracterActual))
            {
                estadoActual = "q76";
            }
            else if (!UtilTexto.EsPunto(caracterActual) && !UtilTexto.EsVacio(caracterActual))
            {
                estadoActual = "q182";
            }
            else
            {
                estadoActual = "q160";
            }

        }
        public void ProcesarEstado76()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (UtilTexto.EsPunto(caracterActual))
            {
                estadoActual = "q77";
            }
            else if (!UtilTexto.EsPunto(caracterActual) && !UtilTexto.EsVacio(caracterActual))
            {
                estadoActual = "q182";
            }
            else
            {
                estadoActual = "q161";
            }

        }
        public void ProcesarEstado77()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (UtilTexto.EsPunto(caracterActual))
            {
                estadoActual = "q78";
            }
            else if (!UtilTexto.EsPunto(caracterActual) && !UtilTexto.EsVacio(caracterActual))
            {
                estadoActual = "q182";
            }
            else
            {
                estadoActual = "q162";
            }

        }
        public void ProcesarEstado78()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (UtilTexto.EsPunto(caracterActual))
            {
                estadoActual = "q79";
            }
            else if (!UtilTexto.EsPunto(caracterActual) && !UtilTexto.EsVacio(caracterActual))
            {
                estadoActual = "q182";
            }
            else
            {
                estadoActual = "q163";
            }

        }
        public void ProcesarEstado79()
        {
            categoria = CategoriaGramatical.EsLetraZz;
            FormarComponenteLexicoSimboloPunto();
        }


        public void ProcesarEstado80()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (UtilTexto.EsPunto(caracterActual))
            {
                estadoActual = "q81";
            }
            else
            {
                estadoActual = "q182";
            }

        }
        public void ProcesarEstado81()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (UtilTexto.EsPunto(caracterActual))
            {
                estadoActual = "q82";
            }
            else if (!UtilTexto.EsPunto(caracterActual) && !UtilTexto.EsVacio(caracterActual))
            {
                estadoActual = "q182";
            }
            else
            {
                estadoActual = "q165";
            }

        }
        public void ProcesarEstado82()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (UtilTexto.EsPunto(caracterActual))
            {
                estadoActual = "q83";
            }
            else if (!UtilTexto.EsPunto(caracterActual) && !UtilTexto.EsVacio(caracterActual))
            {
                estadoActual = "q182";
            }
            else
            {
                estadoActual = "q166";
            }

        }
        public void ProcesarEstado83()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (UtilTexto.EsPunto(caracterActual))
            {
                estadoActual = "q84";
            }
            else if (!UtilTexto.EsPunto(caracterActual) && !UtilTexto.EsVacio(caracterActual))
            {
                estadoActual = "q182";
            }
            else
            {
                estadoActual = "q167";
            }

        }
        public void ProcesarEstado84()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (UtilTexto.EsPunto(caracterActual))
            {
                estadoActual = "q85";
            }
            else if (!UtilTexto.EsPunto(caracterActual) && !UtilTexto.EsVacio(caracterActual))
            {
                estadoActual = "q182";
            }
            else
            {
                estadoActual = "q168";
            }

        }
        public void ProcesarEstado85()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (UtilTexto.EsPunto(caracterActual))
            {
                estadoActual = "q86";
            }
            else if (!UtilTexto.EsPunto(caracterActual) && !UtilTexto.EsVacio(caracterActual))
            {
                estadoActual = "q182";
            }
            else
            {
                estadoActual = "q169";
            }

        }
        public void ProcesarEstado86()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (UtilTexto.EsPunto(caracterActual))
            {
                estadoActual = "q87";
            }
            else if (!UtilTexto.EsPunto(caracterActual) && !UtilTexto.EsVacio(caracterActual))
            {
                estadoActual = "q182";
            }
            else
            {
                estadoActual = "q170";
            }

        }
        public void ProcesarEstado87()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (UtilTexto.EsPunto(caracterActual))
            {
                estadoActual = "q88";
            }
            else if (!UtilTexto.EsPunto(caracterActual) && !UtilTexto.EsVacio(caracterActual))
            {
                estadoActual = "q182";
            }
            else
            {
                estadoActual = "q171";
            }

        }
        public void ProcesarEstado88()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (UtilTexto.EsPunto(caracterActual))
            {
                estadoActual = "q89";
            }
            else if (!UtilTexto.EsPunto(caracterActual) && !UtilTexto.EsVacio(caracterActual))
            {
                estadoActual = "q182";
            }
            else
            {
                estadoActual = "q172";
            }

        }
        public void ProcesarEstado89()
        {
            categoria = CategoriaGramatical.EsLetraQq;
            FormarComponenteLexicoSimboloPunto();
        }

        public void ProcesarEstado90()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (UtilTexto.EsPunto(caracterActual))
            {
                estadoActual = "q91";
            }
            else
            {
                estadoActual = "q182";
            }

        }
        public void ProcesarEstado91()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (UtilTexto.EsPunto(caracterActual))
            {
                estadoActual = "q92";
            }
            else if (!UtilTexto.EsPunto(caracterActual) && !UtilTexto.EsVacio(caracterActual))
            {
                estadoActual = "q182";
            }
            else
            {
                estadoActual = "q174";
            }

        }
        public void ProcesarEstado92()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (UtilTexto.EsPunto(caracterActual))
            {
                estadoActual = "q93";
            }
            else if (!UtilTexto.EsPunto(caracterActual) && !UtilTexto.EsVacio(caracterActual))
            {
                estadoActual = "q182";
            }
            else
            {
                estadoActual = "q175";
            }

        }
        public void ProcesarEstado93()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (UtilTexto.EsPunto(caracterActual))
            {
                estadoActual = "q94";
            }
            else if (!UtilTexto.EsPunto(caracterActual) && !UtilTexto.EsVacio(caracterActual))
            {
                estadoActual = "q182";
            }
            else
            {
                estadoActual = "q176";
            }

        }
        public void ProcesarEstado94()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (UtilTexto.EsPunto(caracterActual))
            {
                estadoActual = "q95";
            }
            else if (!UtilTexto.EsPunto(caracterActual) && !UtilTexto.EsVacio(caracterActual))
            {
                estadoActual = "q182";
            }
            else
            {
                estadoActual = "q177";
            }

        }
        public void ProcesarEstado95()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (UtilTexto.EsPunto(caracterActual))
            {
                estadoActual = "q96";
            }
            else if (!UtilTexto.EsPunto(caracterActual) && !UtilTexto.EsVacio(caracterActual))
            {
                estadoActual = "q182";
            }
            else
            {
                estadoActual = "q178";
            }

        }
        public void ProcesarEstado96()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (UtilTexto.EsPunto(caracterActual))
            {
                estadoActual = "q97";
            }
            else if (!UtilTexto.EsPunto(caracterActual) && !UtilTexto.EsVacio(caracterActual))
            {
                estadoActual = "q182";
            }
            else
            {
                estadoActual = "q179";
            }

        }
        public void ProcesarEstado97()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (UtilTexto.EsPunto(caracterActual))
            {
                estadoActual = "q98";
            }
            else if (!UtilTexto.EsPunto(caracterActual) && !UtilTexto.EsVacio(caracterActual))
            {
                estadoActual = "q182";
            }
            else
            {
                estadoActual = "q180";
            }

        }
        public void ProcesarEstado98()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (UtilTexto.EsPunto(caracterActual))
            {
                estadoActual = "q99";
            }
            else if (!UtilTexto.EsPunto(caracterActual) && !UtilTexto.EsVacio(caracterActual))
            {
                estadoActual = "q182";
            }
            else
            {
                estadoActual = "q181";
            }

        }
        public void ProcesarEstado99()
        {
            categoria = CategoriaGramatical.EsLetraIi;
            FormarComponenteLexicoSimboloPunto();
        }
        private void ProcesarEstado100()
        {
            categoria = CategoriaGramatical.FIN_ARCHIVO;
            FormarComponenteLexicoSimboloPunto();
        }
        private void ProcesarEstado101()
        {
            CargarNuevaLinea();
            Resetear();
        }

        public void ProcesarEstado102()
        {
            categoria = CategoriaGramatical.EsGionBajo;
            FormarComponenteLexicoSimboloPunto();
        }
        public void ProcesarEstado103()
        {
            categoria = CategoriaGramatical.EsMayorQue;
            FormarComponenteLexicoSimboloPunto();
        }
        public void ProcesarEstado104()
        {
            categoria = CategoriaGramatical.EsMenorQue;
            FormarComponenteLexicoSimboloPunto();
        }
        public void ProcesarEstado105()
        {
            categoria = CategoriaGramatical.EsAGuionBajo;
            FormarComponenteLexicoSimboloPunto();
        }
        public void ProcesarEstado106()
        {
            categoria = CategoriaGramatical.EsOGuionBajo;
            FormarComponenteLexicoSimboloPunto();
        }
        public void ProcesarEstado107()
        {
            categoria = CategoriaGramatical.EsTilde;
            FormarComponenteLexicoSimboloPunto();
        }
        public void ProcesarEstado108()
        {
            categoria = CategoriaGramatical.EsComillaBajaAbre;
            FormarComponenteLexicoSimboloPunto();
        }
        public void ProcesarEstado109()
        {
            categoria = CategoriaGramatical.EsComillaBajaCierra;
            FormarComponenteLexicoSimboloPunto();
        }
        public void ProcesarEstado111()
        {
            categoria = CategoriaGramatical.EsBarraInversa;
            FormarComponenteLexicoSimboloPunto();
        }
        public void ProcesarEstado112()
        {
            categoria = CategoriaGramatical.EsOr;
            FormarComponenteLexicoSimboloPunto();
        }
        public void ProcesarEstado113()
        {
            categoria = CategoriaGramatical.EsComillaDoble;
            FormarComponenteLexicoSimboloPunto();
        }
        public void ProcesarEstado114()
        {
            categoria = CategoriaGramatical.EsComillaSimple;
            FormarComponenteLexicoSimboloPunto();
        }
        public void ProcesarEstado115()
        {
            categoria = CategoriaGramatical.EsPotencia;
            FormarComponenteLexicoSimboloPunto();
        }
        public void ProcesarEstado116()
        {
            categoria = CategoriaGramatical.EsAdmiracionAbre;
            FormarComponenteLexicoSimboloPunto();
        }
        public void ProcesarEstado117()
        {
            categoria = CategoriaGramatical.EsAdmiracionCierra;
            FormarComponenteLexicoSimboloPunto();
        }
        public void ProcesarEstado118()
        {
            categoria = CategoriaGramatical.EsPreguntaAbre;
            FormarComponenteLexicoSimboloPunto();
        }
        public void ProcesarEstado119()
        {
            categoria = CategoriaGramatical.EsPreguntaCierra;
            FormarComponenteLexicoSimboloPunto();
        }
        public void ProcesarEstado120()
        {
            categoria = CategoriaGramatical.EsPeso;
            FormarComponenteLexicoSimboloPunto();
        }
        public void ProcesarEstado121()
        {
            categoria = CategoriaGramatical.EsUmpersand;
            FormarComponenteLexicoSimboloPunto();
        }
        public void ProcesarEstado122()
        {
            categoria = CategoriaGramatical.EsArroba;
            FormarComponenteLexicoSimboloPunto();
        }
        public void ProcesarEstado123()
        {
            categoria = CategoriaGramatical.EsSuma;
            FormarComponenteLexicoSimboloPunto();
        }
        public void ProcesarEstado124()
        {
            categoria = CategoriaGramatical.EsResta;
            FormarComponenteLexicoSimboloPunto();
        }
        public void ProcesarEstado125()
        {
            categoria = CategoriaGramatical.EsMultiplicacion;
            FormarComponenteLexicoSimboloPunto();
        }
        public void ProcesarEstado126()
        {
            categoria = CategoriaGramatical.EsDivision;
            FormarComponenteLexicoSimboloPunto();
        }
        public void ProcesarEstado127()
        {
            categoria = CategoriaGramatical.EsModulo;
            FormarComponenteLexicoSimboloPunto();
        }
        public void ProcesarEstado129()
        {
            categoria = CategoriaGramatical.EsPunto;
            FormarComponenteLexicoSimboloPunto();
        }
        public void ProcesarEstado130()
        {
            categoria = CategoriaGramatical.EsDosPuntos;
            FormarComponenteLexicoSimboloPunto();
        }
        public void ProcesarEstado131()
        {
            categoria = CategoriaGramatical.EsParentesisAbre;
            FormarComponenteLexicoSimboloPunto();
        }
        public void ProcesarEstado132()
        {
            categoria = CategoriaGramatical.EsParentesisCierra;
            FormarComponenteLexicoSimboloPunto();
        }
        public void ProcesarEstado133()
        {
            categoria = CategoriaGramatical.EsCorchetesAbre;
            FormarComponenteLexicoSimboloPunto();
        }
        public void ProcesarEstado134()
        {
            categoria = CategoriaGramatical.EsCorchetesCierra;
            FormarComponenteLexicoSimboloPunto();
        }
        public void ProcesarEstado135()
        {
            categoria = CategoriaGramatical.EsLlavesAbre;
            FormarComponenteLexicoSimboloPunto();
        }
        public void ProcesarEstado136()
        {
            categoria = CategoriaGramatical.EsLlavesCierra;
            FormarComponenteLexicoSimboloPunto();
        }
        public void ProcesarEstado138()
        {
            categoria = CategoriaGramatical.EsDiguito3;
            FormarComponenteLexicoSimboloPunto();
        }
        public void ProcesarEstado139()
        {
            categoria = CategoriaGramatical.EsDiguito4;
            FormarComponenteLexicoSimboloPunto();
        }
        public void ProcesarEstado140()
        {
            categoria = CategoriaGramatical.EsDiguito5;
            FormarComponenteLexicoSimboloPunto();
        }
        public void ProcesarEstado141()
        {
            categoria = CategoriaGramatical.EsDiguito6;
            FormarComponenteLexicoSimboloPunto();
        }
        public void ProcesarEstado142()
        {
            categoria = CategoriaGramatical.EsDiguito7;
            FormarComponenteLexicoSimboloPunto();
        }
        public void ProcesarEstado143()
        {
            categoria = CategoriaGramatical.EsDiguito8;
            FormarComponenteLexicoSimboloPunto();
        }
        public void ProcesarEstado144()
        {
            categoria = CategoriaGramatical.EsDiguito9;
            FormarComponenteLexicoSimboloPunto();
        }
        public void ProcesarEstado145()
        {
            categoria = CategoriaGramatical.EsComa;
            FormarComponenteLexicoSimboloPunto();
        }
        public void ProcesarEstado147()
        {
            categoria = CategoriaGramatical.EsLetraA_TILDE;
            FormarComponenteLexicoSimboloPunto();
        }
        public void ProcesarEstado148()
        {
            categoria = CategoriaGramatical.EsLetraE_TILDE;
            FormarComponenteLexicoSimboloPunto();
        }
        public void ProcesarEstado149()
        {
            categoria = CategoriaGramatical.EsLetraI_TILDE;
            FormarComponenteLexicoSimboloPunto();
        }
        public void ProcesarEstado150()
        {
            categoria = CategoriaGramatical.EsLetraO_TILDE;
            FormarComponenteLexicoSimboloPunto();
        }
        public void ProcesarEstado151()
        {
            categoria = CategoriaGramatical.EsLetraU_TILDE;
            FormarComponenteLexicoSimboloPunto();
        }
        public void ProcesarEstado152()
        {
            categoria = CategoriaGramatical.EsLetraU_DIERESIS;
            FormarComponenteLexicoSimboloPunto();
        }
        public void ProcesarEstado153()
        {
            categoria = CategoriaGramatical.EsDiguito0;
            FormarComponenteLexicoSimboloPunto();
        }
        public void ProcesarEstado154()
        {
            categoria = CategoriaGramatical.EsDiguito1;
            FormarComponenteLexicoSimboloPunto();
        }

        public void ProcesarEstado156()
        {
            categoria = CategoriaGramatical.EsLetraRr;
            FormarComponenteLexicoSimboloPunto();
        }
        public void ProcesarEstado157()
        {
            categoria = CategoriaGramatical.EsLetraSs;
            FormarComponenteLexicoSimboloPunto();
        }
        public void ProcesarEstado158()
        {
            categoria = CategoriaGramatical.EsLetraTt;
            FormarComponenteLexicoSimboloPunto();
        }
        public void ProcesarEstado159()
        {
            categoria = CategoriaGramatical.EsLetraUu;
            FormarComponenteLexicoSimboloPunto();
        }
        public void ProcesarEstado160()
        {
            categoria = CategoriaGramatical.EsLetraVv;
            FormarComponenteLexicoSimboloPunto();
        }
        public void ProcesarEstado161()
        {
            categoria = CategoriaGramatical.EsLetraWw;
            FormarComponenteLexicoSimboloPunto();
        }
        public void ProcesarEstado162()
        {
            categoria = CategoriaGramatical.EsLetraXx;
            FormarComponenteLexicoSimboloPunto();
        }
        public void ProcesarEstado163()
        {
            categoria = CategoriaGramatical.EsLetraYy;
            FormarComponenteLexicoSimboloPunto();
        }
        public void ProcesarEstado165()
        {
            categoria = CategoriaGramatical.EsLetraJj;
            FormarComponenteLexicoSimboloPunto();
        }

        public void ProcesarEstado166()
        {
            categoria = CategoriaGramatical.EsLetraKk;
            FormarComponenteLexicoSimboloPunto();
        }
        public void ProcesarEstado167()
        {
            categoria = CategoriaGramatical.EsLetraLl;
            FormarComponenteLexicoSimboloPunto();
        }
        public void ProcesarEstado168()
        {
            categoria = CategoriaGramatical.EsLetraMm;
            FormarComponenteLexicoSimboloPunto();
        }
        public void ProcesarEstado169()
        {
            categoria = CategoriaGramatical.EsLetraNn;
            FormarComponenteLexicoSimboloPunto();
        }
        public void ProcesarEstado170()
        {
            categoria = CategoriaGramatical.EsLetraÑñ;
            FormarComponenteLexicoSimboloPunto();
        }
        public void ProcesarEstado171()
        {
            categoria = CategoriaGramatical.EsLetraOo;
            FormarComponenteLexicoSimboloPunto();
        }
        public void ProcesarEstado172()
        {
            categoria = CategoriaGramatical.EsLetraPp;
            FormarComponenteLexicoSimboloPunto();
        }

        public void ProcesarEstado174()
        {
            categoria = CategoriaGramatical.EsLetraAa;
            FormarComponenteLexicoSimboloPunto();
        }
        public void ProcesarEstado175()
        {
            categoria = CategoriaGramatical.EsLetraBb;
            FormarComponenteLexicoSimboloPunto();
        }

        public void ProcesarEstado176()
        {
            categoria = CategoriaGramatical.EsLetraCc;
            FormarComponenteLexicoSimboloPunto();
        }
        public void ProcesarEstado177()
        {
            categoria = CategoriaGramatical.EsLetraDd;
            FormarComponenteLexicoSimboloPunto();
        }
        public void ProcesarEstado178()
        {
            categoria = CategoriaGramatical.EsLetraEe;
            FormarComponenteLexicoSimboloPunto();
        }
        public void ProcesarEstado179()
        {
            categoria = CategoriaGramatical.EsLetraFf;
            FormarComponenteLexicoSimboloPunto();
        }
        public void ProcesarEstado180()
        {
            categoria = CategoriaGramatical.EsLetraGg;
            FormarComponenteLexicoSimboloPunto();
        }
        public void ProcesarEstado181()
        {
            categoria = CategoriaGramatical.EsLetraHh;
            FormarComponenteLexicoSimboloPunto();
        }
        private void ProcesarEstado182()
        {
            //ERROR SIMBOLO NO VALIDO
            falla = "Simbolo no valido";
            causa = " se recibió el simbolo no reconocido por el lenguaje  " + caracterActual;
            solucion = "Asegurese que en la posicion esperada  se encuentre un punto .";
            ReportarErrorLexicoStopper();
        }
        private void ProcesarEstado183()
        {
            //ERROR SIMBOLO NO VALIDO
            falla = "Simbolo no valido";
            causa = " se recibió el simbolo no reconocido por el lenguaje  " + caracterActual;
            solucion = "Asegurese que en la posicion esperada  se encuentre un espacio";
            ReportarErrorLexicoStopper();
        }
        private void FormarComponenteLexicoSimboloPunto()
        {
            DevolverPuntero();
            FormarComponenteLexicoLiteral();
            continuarAnalisis = false;
        }
       
        private void FormarComponenteLexicoLiteral()
        {
            posicionInicial = puntero - lexema.Length;
            componente = ComponenteLexico.Crear(numeroLineaActual, posicionInicial, lexema, categoria, tipo);
            DevorarDosEspacios();

        }

        private void ReportarErrorLexicoStopper()
        {
            posicionInicial = puntero - lexema.Length;
            Error error = Error.CrearErrorLexicoStopper(numeroLineaActual, posicionInicial, lexema, falla, causa, solucion);
            ManejadorErrores.ObtenerManejadorDeErrores().ReportarError(error);
        }
        private void DevorarEspaciosBlanco()
        {
            LeerSiguienteCaracter();
            while ("".Equals(caracterActual))
            {
                LeerSiguienteCaracter();
            }
        }
        private void DevorarDosEspacios()
        {
            LeerSiguienteCaracter();
            if (UtilTexto.EsEspacioEnBlanco(caracterActual))
            {
                LeerSiguienteCaracter();
                if (UtilTexto.EsEspacioEnBlanco(caracterActual))
                {
                    LeerSiguienteCaracter();

                }
                else
                {
                    falla = "Caracter no esperado";
                    causa = "Se esperaba espacio y se encontró " + caracterActual;
                    solucion = "Corrija los espacios";
                    ReportarErrorLexicoStopper();
                }
            }
            else if (!UtilTexto.EsFinArchivo(caracterActual) && !UtilTexto.EsFinLinea(caracterActual))
            {
                falla = "Caracter no esperado";
                causa = "Se esperaba punto y se encontró " + caracterActual;
                solucion = "Corrija los espacios";
                ReportarErrorLexicoStopper();
            }
        }
    }
}
