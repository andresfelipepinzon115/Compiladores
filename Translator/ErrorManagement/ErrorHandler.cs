using Compilador_22023.GestorErrores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Translator.ErrorManagement
{
    public class ErrorHandler
    {
        private Dictionary<ErrorType, List<Error>> errores = new Dictionary<ErrorType, List<Error>>();
        private static readonly ErrorHandler INSTANCIA = new ErrorHandler();

        private ErrorHandler()
        {
            Limpiar();
        }

        public static ErrorHandler ObtenerManejadorDeErrores()
        {
            return INSTANCIA;
        }

        public void Limpiar()
        {
            errores.Add(ErrorType.LEXICO, new List<Error>());
            errores.Add(ErrorType.SINTACTICO, new List<Error>());
            errores.Add(ErrorType.SEMANTICO, new List<Error>());
            errores.Add(ErrorType.GENERADOR_CODIGO_INTERMEDIO, new List<Error>());
            errores.Add(ErrorType.OPTIMIZACION, new List<Error>());
            errores.Add(ErrorType.GENERALDOR_CODIGO_FINAL, new List<Error>());

        }

        public void ReportarError(Error error)
        {
            if (error != null)
            {
                errores[error.Tipo].Add(error);
                if (ErrorCategory.STOPPER.Equals(error.Categoria))
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append("++++++++++++++ ERROR TIPO STOPPER ++++++++++++++\r\n");
                    sb.Append("Se ha presentado un error de tipo STOPPER dentro del proceso: \r\n").Append(error.Tipo).Append("\r\n");
                    sb.Append("Por favor solucione el problema para llevar a cabo nuevamente el proceso de compilación.\r\n");
                    sb.Append("Verifique la tabla de errores para tener mayor detalle.\r\n");
                    throw new Exception(sb.ToString());
                }
            }
        }
        public bool HayErrores(ErrorType tipo)
        {
            return errores[tipo].Count > 0;
        }
        public bool HayErroresAnalisis()
        {
            return HayErrores(ErrorType.LEXICO) || HayErrores(ErrorType.SINTACTICO) || HayErrores(ErrorType.SEMANTICO);
        }
        public bool HayErroresSintesis()
        {
            return HayErrores(ErrorType.GENERADOR_CODIGO_INTERMEDIO) || HayErrores(ErrorType.OPTIMIZACION) || HayErrores(ErrorType.GENERALDOR_CODIGO_FINAL);
        }
        public bool HayErroresCompilación()
        {
            return HayErroresAnalisis() || HayErroresSintesis();
        }
        public List<Error> ObtenerErrores(ErrorType tipo)
        {
            return errores[tipo];
        }
    }
}
