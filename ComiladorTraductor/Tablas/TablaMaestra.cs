using ComiladorTraductor.AnalizadorLexico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiladorTraductor.Tablas
{
    public class TablaMaestra
    {
        private static TablaMaestra TABLA_MAESTRA = new TablaMaestra();
        private TablaSimbolos tablaSimbolos = new TablaSimbolos();
        private TablaLiterales tablaLiterales = new TablaLiterales();
        private TablaNumeroReservados tablaNumeros = new TablaNumeroReservados();
        private TablaDummy tablaDummy = new TablaDummy();

        public static TablaMaestra ObtenerTablaMaestra()
        {
            return TABLA_MAESTRA;
        }
        public void Limpiar()
        {
            tablaDummy.Limpiar();
            tablaLiterales.Limpiar();
            tablaNumeros.Limpiar();
            tablaSimbolos.Limpiar();
        }

        public void Agregar(ComponenteLexico componente)
        {
            tablaDummy.Agregar(componente);
            tablaLiterales.Agregar(componente);
            tablaNumeros.Agregar(componente);
            tablaSimbolos.Agregar(componente);
        }

        public List<ComponenteLexico> ObtenerSimbolo(TipoComponente tipo, string lexema)
        {
            switch (tipo)
            {
                //case TipoComponente.SIMBOLO:
                //    return tablaSimbolos.ObtenerSimbolo(lexema);
                case TipoComponente.LITERAL:
                    return tablaLiterales.ObtenerSimbolo(lexema);
                //case TipoComponente.NUMERO:
                //    return tablaNumeros.ObtenerSimbolo(lexema);
                //case TipoComponente.DUMMY:
                //    return tablaDummies.ObtenerSimbolo(lexema);
                default:
                    throw new Exception("Tipo de componente no válido");
            }
        }
        public List<ComponenteLexico> ObtenerTodosSimbolos(TipoComponente tipo)
        {
            switch (tipo)
            {
                //case TipoComponente.SIMBOLO:
                //    return tablaSimbolos.ObtenerTodosSimbolos();
                case TipoComponente.LITERAL:
                    return tablaLiterales.ObtenerTodosSimbolos();
                //case TipoComponente.NUMERO:
                //    return tablaNumeros.ObtenerTodosSimbolos();
                //case TipoComponente.DUMMY:
                //    return tablaDummies.ObtenerTodosSimbolos();
                default:
                    throw new Exception("Tipo de componente no válido");
            }

        }
    }
}
