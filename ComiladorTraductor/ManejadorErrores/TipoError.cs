using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiladorTraductor.ManejadorErrores
{
    public enum TipoError
    {
        LEXICO, SINTACTICO, SEMANTICO, GENERADOR_CODIGO_INTERMEDIO, OPTIMIZACION, GENERALDOR_CODIGO_FINAL
    }
}
