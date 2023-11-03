using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompiladoExtraClase.LexicalAnalysis;

namespace CompiladoExtraClase.TablaComponentes

{
    public class TablaNumeros
    {
        private Dictionary<string, List<ComponenteLexico>> tabla = new Dictionary<string, List<ComponenteLexico>>();
        private Dictionary<string, ComponenteLexico> numeros = new Dictionary<string, ComponenteLexico>();

        public TablaNumeros()
        {
            LlenarNumeros();
        }

        private void LlenarNumeros()
        {
            numeros.Add("0", ComponenteLexico.CrearNumero(0, 0, "0", CategoriaGramatical.EsDiguito0));
            numeros.Add("1", ComponenteLexico.CrearNumero(0, 0, "1", CategoriaGramatical.EsDiguito1));
            numeros.Add("2", ComponenteLexico.CrearNumero(0, 0, "2", CategoriaGramatical.EsDiguito2));
            numeros.Add("3", ComponenteLexico.CrearNumero(0, 0, "3", CategoriaGramatical.EsDiguito3));
            numeros.Add("4", ComponenteLexico.CrearNumero(0, 0, "4", CategoriaGramatical.EsDiguito4));
            numeros.Add("5", ComponenteLexico.CrearNumero(0, 0, "5", CategoriaGramatical.EsDiguito5));
            numeros.Add("6", ComponenteLexico.CrearNumero(0, 0, "6", CategoriaGramatical.EsDiguito6));
            numeros.Add("7", ComponenteLexico.CrearNumero(0, 0, "7", CategoriaGramatical.EsDiguito7));
            numeros.Add("8", ComponenteLexico.CrearNumero(0, 0, "8", CategoriaGramatical.EsDiguito8));
            numeros.Add("9", ComponenteLexico.CrearNumero(0, 0, "9", CategoriaGramatical.EsDiguito9));

        }


        public void Limpiar()
        {
            tabla.Clear();
        }

        public void ComprobarNumero(ComponenteLexico componete)
        {
            if(componete != null && numeros.ContainsKey(componete.Lexema))
            {
                componete.Categoria = numeros[componete.Lexema].Categoria;
                componete.Tipo = TipoComponente.NUMERO;
            }
        }

        public void Agregar(ComponenteLexico componente)
        {
            if (componente != null && TipoComponente.NUMERO.Equals(componente.Tipo))
            {
                ObtenerSimbolo(componente.Lexema).Add(componente);
            }
        }

        public List<ComponenteLexico> ObtenerSimbolo(string lexema)
        {
            if (!tabla.ContainsKey(lexema))
            {
                tabla.Add(lexema, new List<ComponenteLexico>());
            }

            return tabla[lexema];
        }

        public List<ComponenteLexico> ObtenerTodosSimbolos()
        {
            List<ComponenteLexico> listaRetorno = new List<ComponenteLexico>();
            foreach (List<ComponenteLexico> lista in tabla.Values)
            {
                listaRetorno.AddRange(lista);
            }
            return listaRetorno;
        }
    }
}
