using Compilador.AnalisisLexico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compilador.TablaComponentes
{
    public class TablaMaestra
    {
        private static TablaMaestra TABLA_MAESTRA = new TablaMaestra();
        private TablaSimbolos tablaSimbolos = new TablaSimbolos();
        private TablaLiteral tablaLiterales = new TablaLiteral();
        private TablasPalabrasReservadas tablasPalabrasReservadas = new TablasPalabrasReservadas();
        private TablaDummy tablaDummy = new TablaDummy();

        public static TablaMaestra ObtenerTablaMaestra()
        {
            return TABLA_MAESTRA;
        }
        public void Limpiar()
        {
            tablaSimbolos.Limpiar();
            tablaLiterales.Limpiar();
            tablasPalabrasReservadas.Limpiar();
            tablaDummy.Limpiar();
        }

        public void Agregar(ComponenteLexico componente)
        {
            tablasPalabrasReservadas.ComprobarPalbraReservada(componente);
            tablaSimbolos.Agregar(componente);
            tablaLiterales.Agregar(componente);
            tablasPalabrasReservadas.Agregar(componente);
            tablaDummy.Agregar(componente);
        }

        public List<ComponenteLexico> ObtenerSimbolo(TipoComponente tipo, string lexema)
        {
            switch (tipo)
            {
                case TipoComponente.SIMBOLO:
                    return tablaSimbolos.ObtenerSimbolo(lexema);
                case TipoComponente.LITERAL:
                    return tablaLiterales.ObtenerSimbolo(lexema);
                case TipoComponente.PALABRA_RESERVADA:
                    return tablasPalabrasReservadas.ObtenerSimbolo(lexema);
                case TipoComponente.DUMMY:
                    return tablaDummy.ObtenerSimbolo(lexema);
                default:
                    throw new Exception("Tipo de componente no valido ");
            }
        }
        public List<ComponenteLexico> ObtenerTodosSimbolos(TipoComponente tipo)
        {
            switch (tipo)
            {
                case TipoComponente.SIMBOLO:
                    return tablaSimbolos.ObtenerTodosSimbolos();
                case TipoComponente.LITERAL:
                    return tablaLiterales.ObtenerTodosSimbolos();
                case TipoComponente.PALABRA_RESERVADA:
                    return tablasPalabrasReservadas.ObtenerTodosSimbolos();
                case TipoComponente.DUMMY:
                    return tablaDummy.ObtenerTodosSimbolos();
                default:
                    throw new Exception("Tipo de componente no valido ");
            }
        }
    }
}
