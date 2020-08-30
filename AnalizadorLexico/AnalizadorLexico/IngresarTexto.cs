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
            string linea;
            while ((linea = leer.ReadLine()) != null) 
            {
                lista.Enqueue(linea.ToCharArray());
            }
            leer.Close();
            arregloTexto = lista;
        }
    }
}
