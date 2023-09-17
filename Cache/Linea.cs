﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compilador.Cache
{
    public class Linea
    {
        private int numeroLinea;
        private string contenido;

        private Linea(int numeroLinea, string contenido)
        {
            NumeroLinea = numeroLinea;
            Contenido = contenido;

        }

        public int NumeroLinea { get => numeroLinea; set => numeroLinea = value; }
        public string Contenido { get => contenido; set => contenido = value; }

        public static Linea Crear(int numeroLinea, string contenido)
        {
            return new Linea(numeroLinea, contenido);
        }
    }
}
            