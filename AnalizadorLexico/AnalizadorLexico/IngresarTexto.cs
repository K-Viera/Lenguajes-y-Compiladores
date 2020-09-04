using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AnalizadorLexico
{
    static class IngresarTexto
    {
        public static Queue<char[]> arregloTexto;


        public static void LeerTexto(String direccion) 
        {
            Queue<char[]> lista= new Queue<char[]>();
            TextReader leer = new StreamReader(direccion);
            string linea = leer.ReadLine();
            //se añade el caracter Form Feed que indica el inicio del texto
            linea = "\f" + linea + "\n";
            while ((linea = leer.ReadLine()) != null) 
            {
                //se añade el caracter de salto de linea al final de cada linea de texto
                linea = linea + "\n";
                lista.Enqueue(linea.ToCharArray());
            }
            leer.Close();
            arregloTexto = lista;
        }


        //imprime caracter por caracter todo el contenido del texto ingresado en formato ASCII
        public static void imprimirCaracteres()
        {
            List<char[]> temp = arregloTexto.ToList();
            int contador = 1;
            foreach (char[] linea in temp) 
            {
                foreach (char caracter in linea) 
                {
                    Console.WriteLine(contador + ": " + (int)caracter);
                    contador++;
                }
            }
        }
    }
}
