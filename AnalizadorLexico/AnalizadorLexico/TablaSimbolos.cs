using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace AnalizadorLexico
{
    static class TablaSimbolos
    {
        public static List<string> simbolos=new List<string>();
        public static List<List<string>> tipos = new List<List<string>>();
        public static void AgregarSimbolo(string simbolo)
        {
            if (!simbolos.Contains(simbolo)&&!TablaOperadores.operadores.Contains(simbolo)) 
            {
                simbolos.Add(simbolo);
                List<string> tipoTemporal = new List<string>();
                tipos.Add(tipoTemporal);
            }
        }
        public static void AgregarSimbolo(string simbolo,string tipo)
        {
            if (!simbolos.Contains(simbolo) && !TablaOperadores.operadores.Contains(simbolo))
            {
                simbolos.Add(simbolo);
                List<string> tipoTemporal = new List<string>();
                tipoTemporal.Add(tipo);
                tipos.Add(tipoTemporal);
            }
        }

        public static void AgregarTipoASimbolo(string simbolo, string tipo)
        {
            int index = simbolos.IndexOf(simbolo);
            if (!tipos[index].Contains(tipo))
            {
                tipos[index].Add(tipo);
            }
        }
        public static void EliminarSimbolo(string simbolo)
        {
            int index = simbolos.IndexOf(simbolo);
            simbolos.RemoveAt(index);
            tipos.RemoveAt(index);
        }
    }
}
