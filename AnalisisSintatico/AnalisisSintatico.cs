using Compilador.AnalisisLexico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compilador.AnalisisSintatico
{
    public class AnalisisSintatico
    {
        {
        private AnalixadorLexico AnaLex = new AnalixadorLexico();
        private ComponenteLexico Componente;
        private string falla = "";
        private string causa = "";
        private string solucion = "";
        private Stack<double> pila = new Stack<double>();
        private StringBuilder TrazaDepuracion = new StringBuilder();
        


        public void Analizar(bool depurar)
        {
            DevolverSiguienteComponenteLexico();


            if (!ManejadorErrores.ObtenerManejadorErrores().HayErroresAnalisis())
            {
                resultado = "el proceso de compilacion finalizo con errores";
            }
            else
            {
                resultado = "el programa se encuentra bien escrito. El resultado de la expresion "
            }
            if (depurar)
            {
                resultado = resultado + "n" + TrazaDepuracion.ToString();
            }
        }

        private void factor()
        {
            if (EsCategoriaValida(CategoriaGramatical.EsLetraAa)){
                DevolverSiguienteComponenteLexico();
            }
            if (EsCategoriaValida(CategoriaGramatical.EsLetraBb))
            {
                DevolverSiguienteComponenteLexico();
            }
            if (EsCategoriaValida(CategoriaGramatical.EsLetraCc))
            {
                DevolverSiguienteComponenteLexico();
            }
            if (EsCategoriaValida(CategoriaGramatical.EsLetraDd))
            {
                DevolverSiguienteComponenteLexico();
            }
            if (EsCategoriaValida(CategoriaGramatical.EsLetraEe))
            {
                DevolverSiguienteComponenteLexico();
            }
            if (EsCategoriaValida(CategoriaGramatical.EsLetraFf))
            {
                DevolverSiguienteComponenteLexico();
            }
            if (EsCategoriaValida(CategoriaGramatical.EsLetraGg))
            {
                DevolverSiguienteComponenteLexico();
            }
            if (EsCategoriaValida(CategoriaGramatical.EsLetraHh))
            {
                DevolverSiguienteComponenteLexico();
            }
            if (EsCategoriaValida(CategoriaGramatical.EsLetraIi))
            {
                DevolverSiguienteComponenteLexico();
            }
            if (EsCategoriaValida(CategoriaGramatical.EsLetraJj))
            {
                DevolverSiguienteComponenteLexico();
            }
            if (EsCategoriaValida(CategoriaGramatical.EsLetraKk))
            {
                DevolverSiguienteComponenteLexico();
            }
            if (EsCategoriaValida(CategoriaGramatical.EsLetraLl))
            {
                DevolverSiguienteComponenteLexico();
            }
            if (EsCategoriaValida(CategoriaGramatical.EsLetraMm))
            {
                DevolverSiguienteComponenteLexico();
            }
            if (EsCategoriaValida(CategoriaGramatical.EsLetraNn))
            {
                DevolverSiguienteComponenteLexico();
            }
            if (EsCategoriaValida(CategoriaGramatical.EsLetraÑñ))
            {
                DevolverSiguienteComponenteLexico();
            }
            if (EsCategoriaValida(CategoriaGramatical.EsLetraOo))
            {
                DevolverSiguienteComponenteLexico();
            }
            if (EsCategoriaValida(CategoriaGramatical.EsLetraPp))
            {
                DevolverSiguienteComponenteLexico();
            }
            if (EsCategoriaValida(CategoriaGramatical.EsLetraQq))
            {
                DevolverSiguienteComponenteLexico();
            }
            if (EsCategoriaValida(CategoriaGramatical.EsLetraRr))
            {
                DevolverSiguienteComponenteLexico();
            }
            if (EsCategoriaValida(CategoriaGramatical.EsLetraSs))
            {
                DevolverSiguienteComponenteLexico();
            }
            if (EsCategoriaValida(CategoriaGramatical.EsLetraTt))
            {
                DevolverSiguienteComponenteLexico();
            }
            if (EsCategoriaValida(CategoriaGramatical.EsLetraUu))
            {
                DevolverSiguienteComponenteLexico();
            }
            if (EsCategoriaValida(CategoriaGramatical.EsLetraVv))
            {
                DevolverSiguienteComponenteLexico();
            }
            if (EsCategoriaValida(CategoriaGramatical.EsLetraWw))
            {
                DevolverSiguienteComponenteLexico();
            }
            if (EsCategoriaValida(CategoriaGramatical.EsLetraXx))
            {
                DevolverSiguienteComponenteLexico();
            }
            if (EsCategoriaValida(CategoriaGramatical.EsLetraYy))
            {
                DevolverSiguienteComponenteLexico();
            }
            if (EsCategoriaValida(CategoriaGramatical.EsLetraZz))
            {
                DevolverSiguienteComponenteLexico();
            }
            if (EsCategoriaValida(CategoriaGramatical.EsLetraA_TILDE))
            {
                DevolverSiguienteComponenteLexico();
            }
            if (EsCategoriaValida(CategoriaGramatical.EsLetraE_TILDE))
            {
                DevolverSiguienteComponenteLexico();
            }
            if (EsCategoriaValida(CategoriaGramatical.EsLetraI_TILDE))
            {
                DevolverSiguienteComponenteLexico();
            }
            if (EsCategoriaValida(CategoriaGramatical.EsLetraO_TILDE))
            {
                DevolverSiguienteComponenteLexico();
            }
            if (EsCategoriaValida(CategoriaGramatical.EsLetraU_TILDE))
            {
                DevolverSiguienteComponenteLexico();
            }
            if (EsCategoriaValida(CategoriaGramatical.EsLetraU_DIERESIS))
            {
                DevolverSiguienteComponenteLexico();
            }
            if (EsCategoriaValida(CategoriaGramatical.EsDiguito0))
            {
                DevolverSiguienteComponenteLexico();
            }
            if (EsCategoriaValida(CategoriaGramatical.EsDiguito1))
            {
                DevolverSiguienteComponenteLexico();
            }
            if (EsCategoriaValida(CategoriaGramatical.EsDiguito2))
            {
                DevolverSiguienteComponenteLexico();
            }
            if (EsCategoriaValida(CategoriaGramatical.EsDiguito3))
            {
                DevolverSiguienteComponenteLexico();
            }
            if (EsCategoriaValida(CategoriaGramatical.EsDiguito4))
            {
                DevolverSiguienteComponenteLexico();
            }
            if (EsCategoriaValida(CategoriaGramatical.EsDiguito5))
            {
                DevolverSiguienteComponenteLexico();
            }
            if (EsCategoriaValida(CategoriaGramatical.EsDiguito6))
            {
                DevolverSiguienteComponenteLexico();
            }
            if (EsCategoriaValida(CategoriaGramatical.EsDiguito7))
            {
                DevolverSiguienteComponenteLexico();
            }
            if (EsCategoriaValida(CategoriaGramatical.EsDiguito8))
            {
                DevolverSiguienteComponenteLexico();
            }
            if (EsCategoriaValida(CategoriaGramatical.EsDiguito9))
            {
                DevolverSiguienteComponenteLexico();
            }
            if (EsCategoriaValida(CategoriaGramatical.EsComa))
            {
                DevolverSiguienteComponenteLexico();
            }
            if (EsCategoriaValida(CategoriaGramatical.EsPuntoYComa))
            {
                DevolverSiguienteComponenteLexico();
            }
            if (EsCategoriaValida(CategoriaGramatical.EsPunto))
            {
                DevolverSiguienteComponenteLexico();
            }
            if (EsCategoriaValida(CategoriaGramatical.EsDosPuntos))
            {
                DevolverSiguienteComponenteLexico();
            }
            if (EsCategoriaValida(CategoriaGramatical.EsParentesisAbre))
            {
                DevolverSiguienteComponenteLexico();
            }
            if (EsCategoriaValida(CategoriaGramatical.EsParentesisCierra))
            {
                DevolverSiguienteComponenteLexico();
            }
            if (EsCategoriaValida(CategoriaGramatical.EsCorchetesAbre))
            {
                DevolverSiguienteComponenteLexico();
            }
            if (EsCategoriaValida(CategoriaGramatical.EsCorchetesCierra))
            {
                DevolverSiguienteComponenteLexico();
            }
            if (EsCategoriaValida(CategoriaGramatical.EsLavesAbre))
            {
                DevolverSiguienteComponenteLexico();
            }
            if (EsCategoriaValida(CategoriaGramatical.EsLlavesCierra))
            {
                DevolverSiguienteComponenteLexico();
            }
            if (EsCategoriaValida(CategoriaGramatical.EsNumeral))
            {
                DevolverSiguienteComponenteLexico();
            }
            if (EsCategoriaValida(CategoriaGramatical.EsPeso))
            {
                DevolverSiguienteComponenteLexico();
            }
            if (EsCategoriaValida(CategoriaGramatical.EsUmpersand))
            {
                DevolverSiguienteComponenteLexico();
            }
            if (EsCategoriaValida(CategoriaGramatical.EsArroba))
            {
                DevolverSiguienteComponenteLexico();
            }
            if (EsCategoriaValida(CategoriaGramatical.EsSuma))
            {
                DevolverSiguienteComponenteLexico();
            }
            if (EsCategoriaValida(CategoriaGramatical.EsResta))
            {
                DevolverSiguienteComponenteLexico();
            }
            if (EsCategoriaValida(CategoriaGramatical.EsMultiplicacion))
            {
                DevolverSiguienteComponenteLexico();
            }
            if (EsCategoriaValida(CategoriaGramatical.EsDivision))
            {
                DevolverSiguienteComponenteLexico();
            }
            if (EsCategoriaValida(CategoriaGramatical.EsModulo))
            {
                DevolverSiguienteComponenteLexico();
            }
            if (EsCategoriaValida(CategoriaGramatical.EsAsignacion))
            {
                DevolverSiguienteComponenteLexico();
            }
            if (EsCategoriaValida(CategoriaGramatical.EsBarraInversa))
            {
                DevolverSiguienteComponenteLexico();
            }
            if (EsCategoriaValida(CategoriaGramatical.EsOr))
            {
                DevolverSiguienteComponenteLexico();
            }
            if (EsCategoriaValida(CategoriaGramatical.EsComillaDoble))
            {
                DevolverSiguienteComponenteLexico();
            }
            if (EsCategoriaValida(CategoriaGramatical.EsComillaSimple))
            {
                DevolverSiguienteComponenteLexico();
            }
            if (EsCategoriaValida(CategoriaGramatical.EsPotencia))
            {
                DevolverSiguienteComponenteLexico();
            }
            if (EsCategoriaValida(CategoriaGramatical.EsAdmiracionAbre))
            {
                DevolverSiguienteComponenteLexico();
            }
            if (EsCategoriaValida(CategoriaGramatical.EsAdmiracionCierra))
            {
                DevolverSiguienteComponenteLexico();
            }
            if (EsCategoriaValida(CategoriaGramatical.EsPreguntaAbre))
            {
                DevolverSiguienteComponenteLexico();
            }
            if (EsCategoriaValida(CategoriaGramatical.EsPreguntaCierra))
            {
                DevolverSiguienteComponenteLexico();
            }
            if (EsCategoriaValida(CategoriaGramatical.EsGionBajo))
            {
                DevolverSiguienteComponenteLexico();
            }
            if (EsCategoriaValida(CategoriaGramatical.EsMayorQue))
            {
                DevolverSiguienteComponenteLexico();
            }
            if (EsCategoriaValida(CategoriaGramatical.EsMenorQue))
            {
                DevolverSiguienteComponenteLexico();
            }
            if (EsCategoriaValida(CategoriaGramatical.EsAGuionBajo))
            {
                DevolverSiguienteComponenteLexico();
            }
            if (EsCategoriaValida(CategoriaGramatical.EsOGuionBajo))
            {
                DevolverSiguienteComponenteLexico();
            }
            if (EsCategoriaValida(CategoriaGramatical.EsTilde))
            {
                DevolverSiguienteComponenteLexico();
            }
            if (EsCategoriaValida(CategoriaGramatical.EsComillaBajaAbre))
            {
                DevolverSiguienteComponenteLexico();
            }
            if (EsCategoriaValida(CategoriaGramatical.EsComillaBajaCierra))
            {
                DevolverSiguienteComponenteLexico();
            }
            if (EsCategoriaValida(CategoriaGramatical.EsEspacioEnBlanco))
            {
                DevolverSiguienteComponenteLexico();
            }


        }
        private void DevolverSiguienteComponenteLexico()
        {
            Componente = AnaLex.DevolverSiguienteComponente();
        }

 


        private bool EsCategoriaValida(CategoriaGramatical categoria)
        {
            return categoria.Equals(Componente.Categoria);
        }

        private void ReportarErrorSintacticoStopper()
        {
            Error error = error.CREAR_ERROR_SINTACTICO_STOPPER(Componente.);
            ManejadorErrores.ObtenerManejadorErrores().ReportarEror(error);
        }
        private void EvaluarExpresion(CategoriaGramatical categoria, int jerarquia)
        {
            

        }
        private void FormarInicio(string nombreRegla, int jerarquia)
        {
            StringBuilder indentador = new StringBuilder();
            for (int indice = 1; indice <= jerarquia; indice++)
            {
                indentador.Append("---");
            }
            indentador.Append("INICIO REGLA ").Append(nombreRegla);
            indentador.Append("con componente ").Append(Componente.Lexema).Append("\r\n");
            TrazaDepuracion.Append(indentador.ToString());
        }

        private void FormarFin(string nombreRegla, int jerarquia)
        {
            StringBuilder indentador = new StringBuilder();
            for (int indice = 1; indice <= jerarquia; indice++)
            {
                indentador.Append("---");
            }
            indentador.Append("FIN REGLA ").Append(nombreRegla).Append("\n");

            TrazaDepuracion.Append(indentador.ToString());
        }
        private void FormarPuestaPila(int jerarquia)
        {
            StringBuilder indentador = new StringBuilder();
            for (int indice = 1; indice <= jerarquia; indice++)
            {
                indentador.Append("---");
            }

            indentador.Append("PUSH ").Append(Componente.Lexema).Append("\n");
            TrazaDepuracion.Append(indentador.ToString());
        }

        private void FormarExtracionPila(int jerarquia, string valor)
        {
            StringBuilder indentador = new StringBuilder();
            for (int indice = 1; indice <= jerarquia; indice++)
            {
                indentador.Append("---");
            }

            indentador.Append("POP ").Append(valor).Append("\n");
            TrazaDepuracion.Append(indentador.ToString());
        }

        private void FormarOperacion(int jerarquia, string operacion, string izquierdo, string derecho)
        {
            StringBuilder indentador = new StringBuilder();
            for (int indice = 1; indice <= jerarquia; indice++)
            {
                indentador.Append("---");
            }

            indentador.Append("OPERADO ").Append(izquierdo).Append(operacion).Append(derecho).Append("\n");
            TrazaDepuracion.Append(indentador.ToString());
        }
    }
}
