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
        public static Queue<Queue<char>> LeerTexto(String direccion) 
        {
            Queue<Queue<char>> lista= new Queue<Queue<char>>();
            TextReader leer = new StreamReader(direccion);
            string linea;
            while ((linea = leer.ReadLine()) != null) 
            {
                lista.Enqueue(new Queue<char>(linea.ToList()));
            }
            leer.Close();
            return lista;
        }
    }
}
