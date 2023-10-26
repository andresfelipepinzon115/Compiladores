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
                    ProcesarEstado0T();

                }

            }
            return lexema;
        }

        public string ProcesarEstado0T()
        {
            DevorarEspaciosBlanco();
            while (!"@EOF@".Equals(caracterActual))
            {
                if (UtilTexto.EsLetraAa(caracterActual))
                {
                    estadoActual = "q1";
                    resultado = FormarComponeneteLexico();

                    Console.WriteLine("Resultado: " + resultado);
                }
                else if (UtilTexto.EsLetraBb(caracterActual))
                {
                    estadoActual = "q2";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilTexto.EsLetraCc(caracterActual))
                {
                    estadoActual = "q3";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilTexto.EsLetraDd(caracterActual))
                {
                    estadoActual = "q4";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilTexto.EsLetraEe(caracterActual))
                {
                    estadoActual = "q5";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilTexto.EsLetraFf(caracterActual))
                {
                    estadoActual = "q6";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilTexto.EsLetraGg(caracterActual))
                {
                    estadoActual = "q7";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilTexto.EsLetraHh(caracterActual))
                {
                    estadoActual = "q8";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilTexto.EsLetraIi(caracterActual))
                {
                    estadoActual = "q9";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilTexto.EsLetraJj(caracterActual))
                {
                    estadoActual = "q10";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilTexto.EsLetraKk(caracterActual))
                {
                    estadoActual = "q11";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilTexto.EsLetraLl(caracterActual))
                {
                    estadoActual = "q12";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilTexto.EsLetraMm(caracterActual))
                {
                    estadoActual = "q13";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilTexto.EsLetraNn(caracterActual))
                {
                    estadoActual = "q14";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilTexto.EsLetraÑñ(caracterActual))
                {
                    estadoActual = "q15";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilTexto.EsLetraOo(caracterActual))
                {
                    estadoActual = "q16";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilTexto.EsLetraPp(caracterActual))
                {
                    estadoActual = "q17";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilTexto.EsLetraQq(caracterActual))
                {
                    estadoActual = "q18";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilTexto.EsLetraRr(caracterActual))
                {
                    estadoActual = "q19";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilTexto.EsLetraSs(caracterActual))
                {
                    estadoActual = "q20";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilTexto.EsLetraTt(caracterActual))
                {
                    estadoActual = "q21";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilTexto.EsLetraUu(caracterActual))
                {
                    estadoActual = "q22";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilTexto.EsLetraVv(caracterActual))
                {
                    estadoActual = "q23";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilTexto.EsLetraWw(caracterActual))
                {
                    estadoActual = "q24";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilTexto.EsLetraXx(caracterActual))
                {
                    estadoActual = "q25";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilTexto.EsLetraYy(caracterActual))
                {
                    estadoActual = "q26";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilTexto.EsLetraZz(caracterActual))
                {
                    estadoActual = "q27";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilTexto.EsLetraÁá(caracterActual))
                {
                    estadoActual = "q28";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilTexto.EsLetraÉé(caracterActual))
                {
                    estadoActual = "q29";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilTexto.EsLetraÍí(caracterActual))
                {
                    estadoActual = "q30";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilTexto.EsLetraÓó(caracterActual))
                {
                    estadoActual = "q31";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilTexto.EsLetraÚú(caracterActual))
                {
                    estadoActual = "q32";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilTexto.EsLetraÜü(caracterActual))
                {
                    estadoActual = "q33";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilTexto.EsDigito0(caracterActual))
                {
                    estadoActual = "q34";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilTexto.EsDigito1(caracterActual))
                {
                    estadoActual = "q35";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilTexto.EsDigito2(caracterActual))
                {
                    estadoActual = "q36";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilTexto.EsDigito3(caracterActual))
                {
                    estadoActual = "q37";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilTexto.EsDigito4(caracterActual))
                {
                    estadoActual = "q38";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilTexto.EsDigito5(caracterActual))
                {
                    estadoActual = "q39";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilTexto.EsDigito6(caracterActual))
                {
                    estadoActual = "q40";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilTexto.EsDigito7(caracterActual))
                {
                    estadoActual = "q41";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilTexto.EsDigito8(caracterActual))
                {
                    estadoActual = "q42";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilTexto.EsDigito9(caracterActual))
                {
                    estadoActual = "q43";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilTexto.EsComa(caracterActual))
                {
                    estadoActual = "q44";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilTexto.EsPuntoYComa(caracterActual))
                {
                    estadoActual = "q45";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilTexto.EsPunto(caracterActual))
                {
                    estadoActual = "q46";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilTexto.EsDosPuntos(caracterActual))
                {
                    estadoActual = "q47";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilTexto.EsParentesisAbre(caracterActual))
                {
                    estadoActual = "q48";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilTexto.EsParentesisCierra(caracterActual))
                {
                    estadoActual = "q49";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilTexto.EsCorchetesAbre(caracterActual))
                {
                    estadoActual = "q50";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilTexto.EsCorchetesCierra(caracterActual))
                {
                    estadoActual = "q51";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilTexto.EsLlavesAbre(caracterActual))
                {
                    estadoActual = "q52";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilTexto.EsLlavesCierra(caracterActual))
                {
                    estadoActual = "q53";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilTexto.EsNumeral(caracterActual))
                {
                    estadoActual = "q54";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilTexto.EsPeso(caracterActual))
                {
                    estadoActual = "q55";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilTexto.EsUmpersand(caracterActual))
                {
                    estadoActual = "q56";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilTexto.EsArroba(caracterActual))
                {
                    estadoActual = "q57";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilTexto.EsSuma(caracterActual))
                {
                    estadoActual = "q58";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilTexto.EsResta(caracterActual))
                {
                    estadoActual = "q59";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilTexto.EsMult(caracterActual))
                {
                    estadoActual = "q60";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilTexto.EsDiv(caracterActual))
                {
                    estadoActual = "q61";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilTexto.EsModulo(caracterActual))
                {
                    estadoActual = "q62";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilTexto.EsAsignacion(caracterActual))
                {
                    estadoActual = "q63";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilTexto.EsBarraInversa(caracterActual))
                {
                    estadoActual = "q64";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilTexto.EsOr(caracterActual))
                {
                    estadoActual = "q65";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilTexto.EsComillaDoble(caracterActual))
                {
                    estadoActual = "q66";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilTexto.EsComillaSimple(caracterActual))
                {
                    estadoActual = "q67";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilTexto.EsPotencia(caracterActual))
                {
                    estadoActual = "q68";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilTexto.EsAdmiracionAbre(caracterActual))
                {
                    estadoActual = "q69";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilTexto.EsAdmiracionCierra(caracterActual))
                {
                    estadoActual = "q70";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilTexto.EsPreguntaAbre(caracterActual))
                {
                    estadoActual = "q71";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilTexto.EsPreguntaCierra(caracterActual))
                {
                    estadoActual = "q72";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilTexto.EsGuionBajo(caracterActual))
                {
                    estadoActual = "q73";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilTexto.EsMayorQue(caracterActual))
                {
                    estadoActual = "q74";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilTexto.EsMenorQue(caracterActual))
                {
                    estadoActual = "q75";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilTexto.EsAGuionBajo(caracterActual))
                {
                    estadoActual = "q76";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilTexto.EsOGuionBajo(caracterActual))
                {
                    estadoActual = "q77";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilTexto.EsTilde(caracterActual))
                {
                    estadoActual = "q78";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilTexto.EsComillaBajaAbre(caracterActual))
                {
                    estadoActual = "q79";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilTexto.EsComillaBajaCierra(caracterActual))
                {
                    estadoActual = "q80";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilTexto.EsEspacioEnBlanco(caracterActual))
                {
                    estadoActual = "q81";
                    resultado = FormarComponeneteLexico();
                }
                else if (UtilTexto.EsComillaSimple(caracterActual))
                {
                    estadoActual = "q67";
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
