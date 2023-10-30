using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compilador.GestorErrores
{
    public enum TipoError
    {
        LEXICO, SINTACTICO, GENERADOR_CODIGO_INTERMEDIO, SEMANTICO, OPTIMIZACION, GENERADOR_CODIGO_FINAL
    }
}
