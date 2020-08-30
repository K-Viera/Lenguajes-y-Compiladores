using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace AnalizadorLexico
{
    static class TablaSimbolos
    {
        public static List<string> simbolos=new List<string>();
        public static List<string> tipos = new List<string>();

        public static void AgregarSimbolo(string simbolo, string tipo)
        {
            if (!simbolos.Contains(simbolo)&&!TablaOperadores.operadores.Contains(simbolo)) 
            {
                simbolos.Add(simbolo);
                tipos.Add(tipo);
            }
        }
    }
}
