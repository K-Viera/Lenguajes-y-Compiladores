using System;

namespace AnalizadorLexico
{
    class Program
    {
        static void Main(string[] args)
        {
            IngresarTexto.LeerTexto("hola.txt");
            Console.WriteLine(IngresarTexto.arregloTexto.Count);

            TablaSimbolos.AgregarSimbolo("hola", "holaTipo");
            Console.WriteLine(TablaSimbolos.simbolos[0]);
            Console.WriteLine(TablaSimbolos.tipos[0]);

            Console.WriteLine("_______________________________");

            TablaOperadores.AgregarOperador("hola2", "Hola");
            Console.WriteLine(TablaOperadores.operadores[0]);
        }
    }
}
