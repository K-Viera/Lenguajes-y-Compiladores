using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace AnalizadorLexico
{
    static class TablaSimbolos
    {
        public static List<string> simbolo;
        public static List<string> tipo;

        public static void AgregarSimbolo(string simboloName, string tipoName)
        {
            if (!simbolo.Contains(simboloName)) 
            {
                simbolo.Add(simboloName);
                tipo.Add(tipoName);
            }
        }
    }
}
