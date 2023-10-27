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


        public AnalixadorLexico()
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
                else
                {
                    ProcesarEstado18();
                }
            }
            TablaMaestra.ObtenerTablaMaestra().Agregar(componente);
            return componente;
        }
        private void ProcesarEstado0()
        {
            DevorarEspaciosBlanco();
            if (UtilTexto.EsLetra(caracterActual) || UtilTexto.EsGuionBajo(caracterActual) || UtilTexto.EsSignoPesos(caracterActual))
            {
                estadoActual = "q4";
            }
            else if (UtilTexto.EsDiguito(caracterActual))
            {
                estadoActual = "q1";
            }
            else if (UtilTexto.EsFinArchivo(caracterActual))
            {
                estadoActual = "q12";
            }
            else if (UtilTexto.EsFinLinea(caracterActual))
            {
                estadoActual = "q13";
            }
            else
            {
                estadoActual = "18";
            }
        }
        private void ProcesarEstado1()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (UtilTexto.EsDiguito(caracterActual))
            {
                estadoActual = "q1";
            }
            else if (UtilTexto.EsComa(caracterActual))
            {
                estadoActual = "q2";
            }
            else
            {
                estadoActual = "q14";
            }
        }
        private void ProcesarEstado2()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (UtilTexto.EsDiguito(caracterActual))
            {
                estadoActual = "q3";
            }
            else
            {
                estadoActual = "q17";
            }
        }
        private void ProcesarEstado3()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (UtilTexto.EsDiguito(caracterActual))
            {
                estadoActual = "q3";
            }
            else
            {
                estadoActual = "q15";
            }
        }
        private void ProcesarEstado4()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (UtilTexto.EsLetraODiguito(caracterActual) || UtilTexto.EsGuionBajo(caracterActual) || UtilTexto.EsSignoPesos(caracterActual))
            {
                estadoActual = "q4";
            }
            else
            {
                estadoActual = "q16";
            }
        }
        private void ProcesarEstado12()
        {
            categoria = CategoriaGramatical.FIN_ARCHIVO;
            lexema = "@EOF@";
            FormarComponenteLexicoLiteral();
            continuarAnalisis = false;
        }
        private void ProcesarEstado13()
        {
            CargarNuevaLinea();
            Resetear();
        }

        private void ProcesarEstado14()
        {
            DevolverPuntero();
            categoria = CategoriaGramatical.NUMERO_ENTERO;
            FormarComponenteLexicoLiteral();
            continuarAnalisis = false;
        }
        private void ProcesarEstado15()
        {
            DevolverPuntero();
            categoria = CategoriaGramatical.NUMERO_DECIMAL;
            FormarComponenteLexicoLiteral();
            continuarAnalisis = false;
        }
        private void ProcesarEstado16()
        {
            DevolverPuntero();
            categoria = CategoriaGramatical.IDENTIFICADOR;
            FormarComponenteLexicoSimbolo();
            continuarAnalisis = false;
        }
        private void ProcesarEstado17()
        {
            //ERROR DECIMAL NO VALIDO
            DevolverPuntero();
            falla = "Numero Decimal no valido";
            causa = " se recibió luego del separador decimal el simbolo " + caracterActual;
            solucion = "Asegurese que en la posicion esperada  se encuentre un diguito, para formar un númer decimal válido...";
            ReportarErrorLexicoRecuperable();
            caracterActual = "0";
            Concatenar();
            categoria = CategoriaGramatical.NUMERO_DECIMAL;
            FormarComponenteLexicoDummy();
            continuarAnalisis = false;
        }
        private void ProcesarEstado18()
        {
            //ERROR SIMBOLO NO VALIDO
            falla = "Simbolo no valido";
            causa = " se recibió el simbolo no reconocido por el lenguaje  " + caracterActual;
            solucion = "Asegurese que en la posicion esperada  se encuentre un simbolo valido, reconocido por el lenguaje...";
            ReportarErrorLexicoStopper();


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
