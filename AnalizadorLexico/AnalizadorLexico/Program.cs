using System;

namespace AnalizadorLexico
{
    class Program
    {
        static void Main(string[] args)
        {
            IngresarTexto.LeerTexto("texto.txt");
            IngresarTexto.imprimirCaracteres();

            TablaSimbolos.CarcarModuloPorDefecto();
            TablaSimbolos.AgregarSimbolo("boolean", "Tipo de dato");
            TablaSimbolos.AgregarSimbolo("=", "operador");
            TablaSimbolos.AgregarTipoASimbolo("=", "separador");
            TablaSimbolos.AgregarSimbolo("(", "separador");
            TablaSimbolos.AgregarSimbolo(" ", "separador");
            TablaSimbolos.AgregarSimbolo(")", "separador");
            TablaSimbolos.AgregarSimbolo("{", "separador");
            TablaSimbolos.AgregarSimbolo("}", "separador");
            TablaSimbolos.AgregarSimbolo("==", "operador");
            TablaSimbolos.AgregarTipoASimbolo("==", "separador");

            Analizador.AnalizarCompleto();
            Analizador.imprimirTabla();
        }
    }
}
