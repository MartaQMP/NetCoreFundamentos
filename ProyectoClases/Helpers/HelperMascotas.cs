using ProyectoClases.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoClases.Helpers
{
    public class HelperMascotas
    {

        public List<Mascota> Mascotas { get; set; }
        /* QUEREMOS ALMACENAR DE FORMA FISICA LAS MASCOTAS EN FILES */
        private HelperFiles helper;
        private string ruta;

        public HelperMascotas()
        {
            this.Mascotas = new List<Mascota>();
            this.helper = new HelperFiles();
            this.ruta = "mascotas.txt";
        }

        /* 
         * EL PROGRAMADOR ESCRIBA Write Y GUARDAMOS LAS MASCOTAS
         * EL PROGRAMADOR ESCRIBA Read Y LEEMOS UN STRING Y RELLENAMOS LA COLECCION
         */

        /* CONVERTIR EL STRING DEL READ A LIST */
        private void ConvertirMascotasList(string contenido)
        {
            //GARFIELD,GATO@PLUTO,PERRO
            this.Mascotas.Clear();
            /* SEPARAMOS CADA MASCOTA CON @ */
            string[] datosMascota = contenido.Split('@');
            foreach(string stringmascota in datosMascota)
            {
                /* SEPARAMOS LAS PROPIEDADES */
                string[] propiedades = stringmascota.Split(',');
                /* CONVERTIRMS EL TRISTE STRING EN OBJETOS */
                Mascota mascota = new Mascota();
                mascota.Nombre = propiedades[0];
                mascota.Raza = propiedades[1];
                this.Mascotas.Add(mascota);
            }
        }

        public async Task ReadMascotasAsync()
        {
            /* LEEMOS EL FICHERO DE MASCOTAS */
            string data = await this.helper.ReadFileAsync(this.ruta);
            /* CONVERTIMOS EL STRING EN LIST */
            this.ConvertirMascotasList(data);
        }

        /* CONVERTIMOS LA COLECCION A STRING */
        private string ConvertirMascotasString()
        {
            string data = "";
            foreach(Mascota mascota in this.Mascotas)
            {
                data += mascota.Nombre + "," + mascota.Raza;
                data += "@";
            }
            data = data.Trim('@');
            return data;
        }

        public async Task WriteMascotaAsync()
        {
            /* CONVERTIMOS LA COLECCION A STRING */
            string data = this.ConvertirMascotasString();
            /* ESCRIBIMOS LOS DATOS EN FILE */
            await this.helper.WriteFileAsync(this.ruta, data);
        }
    }
}
