using System;

namespace AnalizadorLexico
{
    class Program
    {
        static void Main(string[] args)
        {
            IngresarTexto.LeerTexto("hola.txt");
            IngresarTexto.imprimirCaracteres();
            Console.WriteLine(IngresarTexto.arregloTexto.Count);

            TablaSimbolos.AgregarSimbolo("hola", "holaTipo");
            TablaSimbolos.AgregarSimbolo("eres", "holaTipo");
            Console.WriteLine(TablaSimbolos.simbolos[0]);

            Console.WriteLine("_______________________________");

            TablaOperadores.AgregarOperador("+", "Operador");
            Console.WriteLine(TablaOperadores.operadores[0]);

            Console.WriteLine("_______________________________");
            Analizador.Analizar();
        }
    }
}
