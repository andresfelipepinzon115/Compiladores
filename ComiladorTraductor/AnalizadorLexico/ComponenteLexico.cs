﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiladorTraductor.AnalizadorLexico
{
    public class ComponenteLexico
    {
        private int numeroLinea;
        private int posicionInicial;
        private int posicionFinal;
        private string lexema;
        private CategoriaGramatical categoria;
        private TipoComponente tipo;

        private ComponenteLexico(int numeroLinea, int posicionInicial, int posicionFinal, string lexema, CategoriaGramatical categoria, TipoComponente tipo)
        {
            this.NumeroLinea = numeroLinea;
            this.PosicionInicial = posicionInicial;
            this.PosicionFinal = posicionFinal;
            this.Lexema = lexema;
            this.Categoria = categoria;
            this.Tipo = tipo;
        }

        public int NumeroLinea { get => numeroLinea; set => numeroLinea = value; }
        public int PosicionInicial { get => posicionInicial; set => posicionInicial = value; }
        public int PosicionFinal { get => posicionFinal; set => posicionFinal = (value < 0 ? PosicionInicial : value); }
        public string Lexema { get => lexema; set => lexema = value; }
        public CategoriaGramatical Categoria { get => categoria; set => categoria = value; }
        public TipoComponente Tipo { get => tipo; set => tipo = value; }

        public static ComponenteLexico Crear(int numeroLinea, int posicionInicial, int posicionFinal, string lexema, CategoriaGramatical categoria, TipoComponente tipo)
        {
            switch (tipo)
            {
                case TipoComponente.LITERAL:
                    return CrearLiteral(numeroLinea, posicionInicial, posicionFinal, lexema, categoria);
                case TipoComponente.NUMERO:
                    return CrearLiteral(numeroLinea, posicionInicial, posicionFinal, lexema, categoria);
                case TipoComponente.SIMBOLO:
                    return CrearSimbolo(numeroLinea, posicionInicial, posicionFinal, lexema, categoria);
                case TipoComponente.DUMMY:
                    return CrearDummy(numeroLinea, posicionInicial, posicionFinal, lexema, categoria);
                default:
                    throw new Exception("Tipo de componente Inválido");
            }
        }

        public static ComponenteLexico CrearSimbolo(int numeroLinea, int posicionInicial, int posicionFinal, string lexema, CategoriaGramatical categoria)
        {
            return new ComponenteLexico(numeroLinea, posicionInicial, posicionFinal, lexema, categoria, TipoComponente.SIMBOLO);
        }
        public static ComponenteLexico CrearLiteral(int numeroLinea, int posicionInicial, int posicionFinal, string lexema, CategoriaGramatical categoria)
        {
            return new ComponenteLexico(numeroLinea, posicionInicial, posicionFinal, lexema, categoria, TipoComponente.LITERAL);
        }
        public static ComponenteLexico CrearDummy(int numeroLinea, int posicionInicial, int posicionFinal, string lexema, CategoriaGramatical categoria)
        {
            return new ComponenteLexico(numeroLinea, posicionInicial, posicionFinal, lexema, categoria, TipoComponente.DUMMY);
        }
        public static ComponenteLexico CrearNumero(int numeroLinea, int posicionInicial, int posicionFinal, string lexema, CategoriaGramatical categoria)
        {
            return new ComponenteLexico(numeroLinea, posicionInicial, posicionFinal, lexema, categoria, TipoComponente.NUMERO);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("-------------------------------INICIO-------------------------------\r\n");
            sb.Append("Tipo: ").Append(Tipo).Append("\r\n");
            sb.Append("Categoria: ").Append(Categoria).Append("\r\n");
            sb.Append("Lexema: ").Append(Lexema).Append("\r\n");
            sb.Append("Número de línea: ").Append(NumeroLinea).Append("\r\n");
            sb.Append("Posicion Inicial:").Append(PosicionInicial).Append("\r\n");
            sb.Append("Posicion Final: ").Append(PosicionFinal).Append("\r\n");
            sb.Append("-------------------------------FIN-------------------------------");
            return sb.ToString();
        }

    }
}
