using System;
using System.Collections.Generic;
using System.Text;

namespace AnalizadorLexico
{
    class Analizador
    {
        public static List<string> simbolo;
        public static List<string> ubicacion;
        public static List<string> tipo;
        public void Analizar()
        {
            while (IngresarTexto.arregloTexto.Count!=0) 
            {
                char[] temp = IngresarTexto.arregloTexto.Dequeue();
                
            }
        }
    }
}
