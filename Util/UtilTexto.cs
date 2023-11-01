using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compilador.Util
{
    public class UtilTexto
    {

        public static bool EsLetraAa(string caracter)
        {
            return caracter == "A" || caracter == "a";
        }

        public static bool EsLetraBb(string caracter)
        {
            return caracter == "B" || caracter == "b";
        }

        public static bool EsLetraCc(string caracter)
        {
            return caracter == "C" || caracter == "c";
        }

        public static bool EsLetraDd(string caracter)
        {
            return caracter == "D" || caracter == "d";
        }

        public static bool EsLetraEe(string caracter)
        {
            return caracter == "E" || caracter == "e";
        }

        public static bool EsLetraFf(string caracter)
        {
            return caracter == "F" || caracter == "f";
        }

        public static bool EsLetraGg(string caracter)
        {
            return caracter == "G" || caracter == "g";
        }

        public static bool EsLetraHh(string caracter)
        {
            return caracter == "H" || caracter == "h";
        }

        public static bool EsLetraIi(string caracter)
        {
            return caracter == "I" || caracter == "i";
        }

        public static bool EsLetraJj(string caracter)
        {
            return caracter == "J" || caracter == "j";
        }

        public static bool EsLetraKk(string caracter)
        {
            return caracter == "K" || caracter == "k";
        }

        public static bool EsLetraLl(string caracter)
        {
            return caracter == "L" || caracter == "l";
        }

        public static bool EsLetraMm(string caracter)
        {
            return caracter == "M" || caracter == "m";
        }

        public static bool EsLetraNn(string caracter)
        {
            return caracter == "N" || caracter == "n";
        }

        public static bool EsLetraÑñ(string caracter)
        {
            return caracter == "Ñ" || caracter == "ñ";
        }

        public static bool EsLetraOo(string caracter)
        {
            return caracter == "O" || caracter == "o";
        }

        public static bool EsLetraPp(string caracter)
        {
            return caracter == "P" || caracter == "p";
        }

        public static bool EsLetraQq(string caracter)
        {
            return caracter == "Q" || caracter == "q";
        }

        public static bool EsLetraRr(string caracter)
        {
            return caracter == "R" || caracter == "r";
        }

        public static bool EsLetraSs(string caracter)
        {
            return caracter == "S" || caracter == "s";
        }

        public static bool EsLetraTt(string caracter)
        {
            return caracter == "T" || caracter == "t";
        }

        public static bool EsLetraUu(string caracter)
        {
            return caracter == "U" || caracter == "u";
        }

        public static bool EsLetraVv(string caracter)
        {
            return caracter == "V" || caracter == "v";
        }

        public static bool EsLetraWw(string caracter)
        {
            return caracter == "W" || caracter == "w";
        }

        public static bool EsLetraXx(string caracter)
        {
            return caracter == "X" || caracter == "x";
        }

        public static bool EsLetraYy(string caracter)
        {
            return caracter == "Y" || caracter == "y";
        }

        public static bool EsLetraZz(string caracter)
        {
            return caracter == "Z" || caracter == "z";
        }

        public static bool EsLetraÁá(string caracter)
        {
            return caracter == "Á" || caracter == "á";
        }

        public static bool EsLetraÉé(string caracter)
        {
            return caracter == "É" || caracter == "é";
        }

        public static bool EsLetraÍí(string caracter)
        {
            return caracter == "Í" || caracter == "í";
        }

        public static bool EsLetraÓó(string caracter)
        {
            return caracter == "Ó" || caracter == "ó";
        }

        public static bool EsLetraÚú(string caracter)
        {
            return caracter == "Ú" || caracter == "ú";
        }

        public static bool EsLetraÜü(string caracter)
        {
            return caracter == "Ü" || caracter == "ü";
        }

        public static bool EsDigito0(string caracter)
        {
            return caracter == "0";
        }

        public static bool EsDigito1(string caracter)
        {
            return caracter == "1";
        }

        public static bool EsDigito2(string caracter)
        {
            return caracter == "2";
        }

        public static bool EsDigito3(string caracter)
        {
            return caracter == "3";
        }

        public static bool EsDigito4(string caracter)
        {
            return caracter == "4";
        }

        public static bool EsDigito5(string caracter)
        {
            return caracter == "5";
        }

        public static bool EsDigito6(string caracter)
        {
            return caracter == "6";
        }

        public static bool EsDigito7(string caracter)
        {
            return caracter == "7";
        }

        public static bool EsDigito8(string caracter)
        {
            return caracter == "8";
        }

        public static bool EsDigito9(string caracter)
        {
            return caracter == "9";
        }
        public static bool EsComa(String caracter)
        {
            return caracter == ",";
        }

        public static bool EsPuntoYComa(string caracter)
        {
            return caracter == ";";
        }

        public static bool EsPunto(string caracter)
        {
            return caracter == ".";
        }

        public static bool EsDosPuntos(string caracter)
        {
            return caracter == ":";
        }

        public static bool EsParentesisAbre(string caracter)
        {
            return caracter == "(";
        }

        public static bool EsParentesisCierra(string caracter)
        {
            return caracter == ")";
        }

        public static bool EsCorchetesAbre(string caracter)
        {
            return caracter == "[";
        }

        public static bool EsCorchetesCierra(string caracter)
        {
            return caracter == "]";
        }

        public static bool EsLlavesAbre(string caracter)
        {
            return caracter == "{";
        }

        public static bool EsLlavesCierra(string caracter)
        {
            return caracter == "}";
        }

        public static bool EsNumeral(string caracter)
        {
            return caracter == "#";
        }

        public static bool EsPeso(string caracter)
        {
            return caracter == "$";
        }

        public static bool EsUmpersand(string caracter)
        {
            return caracter == "&";
        }

        public static bool EsArroba(string caracter)
        {
            return caracter == "@";
        }

        public static bool EsSuma(string caracter)
        {
            return caracter == "+";
        }

        public static bool EsResta(string caracter)
        {
            return caracter == "-";
        }

        public static bool EsMult(string caracter)
        {
            return caracter == "*";
        }

        public static bool EsDiv(string caracter)
        {
            return caracter == "/";
        }

        public static bool EsModulo(string caracter)
        {
            return caracter == "%";
        }

        public static bool EsAsignacion(string caracter)
        {
            return caracter == "=";
        }

        public static bool EsBarraInversa(string caracter)
        {
            return caracter == "\\";
        }

        public static bool EsOr(string caracter)
        {
            return caracter == "|";
        }

        public static bool EsComillaDoble(string caracter)
        {
            return caracter == "\"";
        }

        public static bool EsComillaSimple(string caracter)
        {
            return caracter == "'";
        }

        public static bool EsPotencia(string caracter)
        {
            return caracter == "^";
        }

        public static bool EsAdmiracionAbre(string caracter)
        {
            return caracter == "¡";
        }

        public static bool EsAdmiracionCierra(string caracter)
        {
            return caracter == "!";
        }

        public static bool EsPreguntaAbre(string caracter)
        {
            return caracter == "¿";
        }

        public static bool EsPreguntaCierra(string caracter)
        {
            return caracter == "?";
        }

        public static bool EsGuionBajo(string caracter)
        {
            return caracter == "_";
        }

        public static bool EsMayorQue(string caracter)
        {
            return caracter == ">";
        }

        public static bool EsMenorQue(string caracter)
        {
            return caracter == "<";
        }

        public static bool EsAGuionBajo(string caracter)
        {
            return caracter == "ª";
        }

        public static bool EsOGuionBajo(string caracter)
        {
            return caracter == "º";
        }

        public static bool EsTilde(string caracter)
        {
            return caracter == "~";
        }

        public static bool EsComillaBajaAbre(string caracter)
        {
            return caracter == "«";
        }

        public static bool EsComillaBajaCierra(string caracter)
        {
            return caracter == "»";
        }

        public static bool EsEspacioEnBlanco(string caracter)
        {
            return caracter == " ";
        }
        public static bool EsVacio(string caracter)
        {
            return caracter == "";
        }
        public static bool EsFinArchivo(string caracter)
        {
            return "@EOF@".Equals(caracter);
        }
        public static bool EsFinLinea(string caracter)
        {
            return "@FL@".Equals(caracter);
        }
    }

}

    

