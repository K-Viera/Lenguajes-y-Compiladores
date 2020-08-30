using System;
using System.Collections.Generic;
using System.Text;

namespace AnalizadorLexico
{
    class Analizador
    {
        public static List<string> simbolo= new List<string>();
        public static List<string> ubicacion= new List<string>();
        public static List<string> tipo= new List<string>();
        public static void Analizar()
        {
            int indiceLineaActual = 0;
            while (IngresarTexto.arregloTexto.Count!=0) 
            {
                char[] lineaTemporal = IngresarTexto.arregloTexto.Dequeue();
                for (int i = 0; i < lineaTemporal.Length; i++) 
                {
                    Console.WriteLine(lineaTemporal[i]);
                    Boolean encontroPalabra = false;
                    int posicionSimbolo = 0;
                    while (encontroPalabra == false && posicionSimbolo < TablaSimbolos.simbolos.Count) 
                    {
                        char[] palabraArreglo = TablaSimbolos.simbolos[posicionSimbolo].ToCharArray();
                        int posicionLinea = i;
                        int posicionPalabra = 0;
                        Boolean Conincide= true;
                        if (lineaTemporal.Length - posicionLinea < palabraArreglo.Length)
                        {
                            Conincide = false;
                        }
                        else 
                        {
                            while (Conincide == true && posicionPalabra < palabraArreglo.Length && posicionLinea < lineaTemporal.Length)
                            {
                                if (lineaTemporal[posicionLinea] != palabraArreglo[posicionPalabra])
                                {
                                    Conincide = false;
                                }
                                else
                                {
                                    posicionLinea++;
                                    posicionPalabra++;
                                }
                            }
                        }
                        if (Conincide==true)
                        {
                            encontroPalabra = true;
                            simbolo.Add(TablaSimbolos.simbolos[posicionSimbolo]);
                            ubicacion.Add(indiceLineaActual + ","+i+" - "+indiceLineaActual+","+posicionLinea);
                            tipo.Add(TablaSimbolos.tipos[posicionSimbolo]);
                            Console.WriteLine(indiceLineaActual + "," + i + " - " + indiceLineaActual + "," + posicionLinea+"   Palabra: "+ TablaSimbolos.simbolos[posicionSimbolo]);
                            i = posicionLinea;
                        }
                        posicionSimbolo++;
                    }
                }
                indiceLineaActual++;
            }
        }
    }
}
