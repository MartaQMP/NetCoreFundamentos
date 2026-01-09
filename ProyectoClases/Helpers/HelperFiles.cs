using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ProyectoClases.Helpers
{
    public class HelperFiles
    {
        /*
         * NECESITAMOS 2 METODOS: LEER Y ESCRIBIR
         * LOS METODOS DEBEN SER ASINCRONOS 
         * EN LOS METODOS DE CLASE NO GRAFICA DEBEMOS UTILIZAR
         * LA CLASE TASK PARA METODOS ASINCRONOS
         * NO SE UTILIZA VOID 
         * 1) Si es un void, se utiliza Task
         * 2) Si es un return, utilizamos Task<ClaseReturn>
         */

        public async Task WriteFileAsync(string ruta, string contenido)
        {
            FileInfo file = new FileInfo(ruta);
            using(TextWriter writer = file.CreateText())
            {
                await writer.WriteAsync(contenido);
                await writer.FlushAsync();
                writer.Close();
            }
        }

        public async Task<string> ReadFileAsync(string ruta)
        {
            FileInfo file = new FileInfo(ruta);
            using(TextReader reader = file.OpenText())
            {
                string contenido = await reader.ReadToEndAsync();
                reader.Close();
                return contenido;
            }
        }
    }
}
