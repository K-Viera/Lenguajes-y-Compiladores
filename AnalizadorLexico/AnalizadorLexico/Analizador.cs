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

        public static void AnalizarSoloTablas()
        {
            int indiceFilaActual = 0;

            Boolean encontroPalabra;
            int posicionSimbolo;

            while (IngresarTexto.arregloTexto.Count!=0) 
            {
                char[] filaTemporal = IngresarTexto.arregloTexto.Dequeue();
                for (int columna = 0; columna < filaTemporal.Length; columna++) 
                {
                    Console.WriteLine(filaTemporal[columna]);
                    encontroPalabra = false;
                    posicionSimbolo = 0;
                    while (encontroPalabra == false && posicionSimbolo < TablaSimbolos.simbolos.Count) 
                    {
                        char[] simboloArreglo = TablaSimbolos.simbolos[posicionSimbolo].ToCharArray();
                        int columnaFilaActual = columna;
                        int posicionCaracterSimboloArreglo = 0;
                        Boolean Conincide= true;
                        if (filaTemporal.Length - columnaFilaActual < simboloArreglo.Length)
                        {
                            Conincide = false;
                        }
                        else 
                        {
                            while (Conincide == true && posicionCaracterSimboloArreglo < simboloArreglo.Length && columnaFilaActual < filaTemporal.Length)
                            {
                                if (filaTemporal[columnaFilaActual] != simboloArreglo[posicionCaracterSimboloArreglo])
                                {
                                    Conincide = false;
                                }
                                else
                                {
                                    columnaFilaActual++;
                                    posicionCaracterSimboloArreglo++;
                                }
                            }
                        }
                        if (Conincide==true)
                        {
                            columnaFilaActual--;
                            encontroPalabra = true;
                            simbolo.Add(TablaSimbolos.simbolos[posicionSimbolo]);
                            ubicacion.Add(indiceFilaActual + ","+columna+" - "+indiceFilaActual+","+columnaFilaActual);
                            tipo.Add(TablaSimbolos.tipos[posicionSimbolo]);
                            Console.WriteLine(indiceFilaActual + "," + columna + " - " + indiceFilaActual + "," + columnaFilaActual+"   Palabra: "+ TablaSimbolos.simbolos[posicionSimbolo]);
                            columna = columnaFilaActual;
                        }
                        posicionSimbolo++;
                    }
                    if (encontroPalabra == false) 
                    {
                        int posicionOperador = 0;
                        while (encontroPalabra == false && posicionOperador < TablaOperadores.operadores.Count)
                        {
                            char[] operadorArreglo = TablaOperadores.operadores[posicionOperador].ToCharArray();
                            int columnaFilaActual = columna;
                            int posicionCaracterOperadorArreglo = 0;
                            Boolean coincide = true;
                            if (filaTemporal.Length - columnaFilaActual < operadorArreglo.Length)
                            {
                                coincide = false;
                            }
                            else
                            {
                                while (coincide == true && posicionCaracterOperadorArreglo < operadorArreglo.Length && columnaFilaActual < filaTemporal.Length)
                                {
                                    if (filaTemporal[columnaFilaActual] != operadorArreglo[posicionCaracterOperadorArreglo])
                                    {
                                        coincide = false;
                                    }
                                    else
                                    {
                                        posicionCaracterOperadorArreglo++;
                                        columnaFilaActual++;
                                    }
                                }
                            }
                            if (coincide == true)
                            {
                                columnaFilaActual--;
                                encontroPalabra = true;
                                simbolo.Add(TablaOperadores.operadores[posicionOperador]);
                                ubicacion.Add(indiceFilaActual + "," + columna + " - " + indiceFilaActual + "," + columnaFilaActual);
                                tipo.Add(TablaOperadores.tipos[posicionOperador]);
                                Console.WriteLine(indiceFilaActual + "," + columna + " - " + indiceFilaActual + "," + columnaFilaActual + "   Palabra: " + TablaOperadores.operadores[posicionOperador]+"  --Operador");
                                columna = columnaFilaActual;
                            }
                            posicionOperador++;
                        }
                    }
                }
                indiceFilaActual++;
            }
        }
    }
}
