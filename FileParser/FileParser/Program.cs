using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace FileParser
{
    class Program
    {
        private static int i;

        static void Main(string[] args)
        {
            string path = @"INGRESAR AQUI LA RUTA DE LA CARPETA DE ORIGEN";

            StreamWriter sw = new StreamWriter(path, true);
            sw.WriteLine("U");
            sw.WriteLine("N");
            sw.WriteLine(" ");
            sw.WriteLine("T");
            sw.WriteLine("E");
            sw.WriteLine("X");
            sw.WriteLine("T");
            sw.WriteLine("O");
            sw.WriteLine(" ");
            sw.WriteLine("C");
            sw.WriteLine("U");
            sw.WriteLine("A");
            sw.WriteLine("L");
            sw.WriteLine("Q");
            sw.WriteLine("U");
            sw.WriteLine("I");
            sw.WriteLine("E");
            sw.WriteLine("R");
            sw.WriteLine("A");
            sw.Close();

            /* Otra forma de hacer lo mismo pero optimizando memoria y cerrando automaticamente
            using (StreamWriter sw2 = new StreamWriter(@"d:\Destino\Salida.txt", true))
            {
                sw.WriteLine("A");
                sw.WriteLine("B");
                sw.WriteLine("C");
            }
            */

            /*StreamWriter sw3 = new StreamWriter(path, true);
            for(i=0; i<=10; i++)
            {
                sw3.WriteLine(i);
            }
            sw3.Close();

            StreamReader sr = new StreamReader(path);
            string completo = sr.ReadToEnd();*/


            //Reemplazar caracteres - Se van a reemplazar ciertos caracteres del texto que
            // escribimos anteriormente.
            string text = File.ReadAllText(path);
            text = text.Replace("A", "O"); // Reemplazamos todas las letras "A" por la letra "O".
            File.WriteAllText(path, text);

            // Leemos el archivo modificado
            StreamReader sr2 = new StreamReader(path,Encoding.UTF8);
            string cartaCompleta = sr2.ReadToEnd();

            Console.ReadLine();
        }    
    }
}
