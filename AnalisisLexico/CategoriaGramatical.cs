using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compilador.AnalisisLexico
{
    public enum CategoriaGramatical
    {
        EsLetraAa, EsLetraBb, EsLetraCc, EsLetraDd, EsLetraEe, EsLetraFf, EsLetraGg, EsLetraHh, 
        EsLetraIi, EsLetraJj, EsLetraKk, EsLetraLl, EsLetraMm, EsLetraNn, EsLetraÑñ, EsLetraOo,
        EsLetraPp, EsLetraQq, EsLetraRr, EsLetraSs, EsLetraTt, EsLetraUu, EsLetraVv, EsLetraWw,
        EsLetraXx, EsLetraYy, EsLetraZz, EsLetraA_TILDE, EsLetraE_TILDE, EsLetraI_TILDE,
        EsLetraO_TILDE, EsLetraU_TILDE,EsLetraU_DIERESIS, EsDiguito0, EsDiguito1, EsDiguito2, 
        EsDiguito3, EsDiguito4, EsDiguito5, EsDiguito6, EsDiguito7, EsDiguito8, EsDiguito9, EsComa, 
        EsPuntoYComa, EsPunto, EsDosPuntos, EsParentesisAbre, EsParentesisCierra, EsCorchetesAbre,
        EsCorchetesCierra, EsLavesAbre, EsLlavesCierra, EsNumeral, EsPeso,EsUmpersand, EsArroba,
        EsSuma, EsResta, EsMultiplicacion, EsDivision, EsModulo, EsAsignacion, EsBarraInversa,
        EsOr, EsComillaDoble, EsComillaSimple, EsPotencia, EsAdmiracionAbre, EsAdmiracionCierra,
        EsPreguntaAbre, EsPreguntaCierra, EsGionBajo, EsMayorQue, EsMenorQue, EsAGuionBajo, 
        EsOGuionBajo, EsTilde, EsComillaBajaAbre, EsComillaBajaCierra, EsEspacioEnBlanco,DEFECTO
    }
}
