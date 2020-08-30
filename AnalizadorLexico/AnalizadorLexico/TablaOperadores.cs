using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace AnalizadorLexico
{
    class TablaOperadores
    {
        public static List<string> operadores = new List<string>();
        public static List<string> tipos = new List<string>();

        public static void AgregarOperador(string operador,string tipo) 
        {
            if (!operadores.Contains(operador) && !TablaSimbolos.simbolos.Contains(operador))
            {
                operadores.Add(operador);
                tipos.Add(tipo);
            }
        }
    }
}
