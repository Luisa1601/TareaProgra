using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_Progra
{
    class Archivo
    {
        public string[] LeerArchivo(string archivo)
        {
            string[] contenido = File.ReadAllLines(archivo, Encoding.Default);
            return contenido;
        }

        public string LeerTodoArchivo(string archivo)
        {
            string ContenidoArchivo;
            using (StreamReader reader = new StreamReader(archivo, Encoding.UTF8))
            {
                ContenidoArchivo = reader.ReadToEnd();
            }
            return ContenidoArchivo;
        }
    }
}
