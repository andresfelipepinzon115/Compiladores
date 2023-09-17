﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compilador.Cache
{
    public class DataCache
    {
        private static Dictionary<int, Linea> programaFuente = new Dictionary<int, Linea>();
        public static void Limpiar()
        {
            programaFuente.Clear();

        }
        public static void AgregarLinea(string linea)
        {
            if (linea != null)
            {
                int numeroLinea = ObtenerProximaLinea();
                programaFuente.Add(numeroLinea, Linea.Crear(numeroLinea, linea));
            }
        }

        private static void AgregarLineas(List<string> lineas)
        {
            foreach (string linea in lineas)
            {
                AgregarLinea(linea);
            }
        }
        public static int ObtenerProximaLinea()

        {
            return programaFuente.Count + 1;
        }
        public static Linea ObtenerLinea(int numeroLinea)
        {
            int numeroUltimaLinea = ObtenerProximaLinea();
            Linea lineaRetorno = Linea.Crear(numeroUltimaLinea, "@EOF");

            if (numeroLinea <= 0)
            {
                throw new Exception("Número de la linea Inválido");
            }
            else if (numeroLinea <= programaFuente.Count)
            {
                lineaRetorno = programaFuente[numeroLinea];
            }
            return lineaRetorno;
        }
    }
}

