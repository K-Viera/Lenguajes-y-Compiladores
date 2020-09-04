using System;
using System.Collections.Generic;
using System.Text;

namespace AnalizadorLexico
{
    class Analizador
    {
        public static List<string> simbolo = new List<string>();
        public static List<string> ubicacion = new List<string>();
        public static List<List<string>> tipo = new List<List<string>>();

        public static void AnalizarCompleto() 
        {
            while (IngresarTexto.arregloTexto.Count != 0) 
            {
                char[] filaActual = IngresarTexto.arregloTexto.Dequeue();
                for (int posicionCaracterFilaActual = 0; posicionCaracterFilaActual < filaActual.Length; posicionCaracterFilaActual++) 
                {
                    
                }
            }
        }
    }
}
