using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using ProyectoClases.Helpers;

namespace NetCoreFundamentos
{
    public partial class Form21Files : Form
    {
        public string Ruta { get; set; }
        HelperFiles helper;

        public Form21Files()
        {
            InitializeComponent();
            /*
             * CUANDO HABLAMOS DE RUTA O CARACTERES ESPECIALES
             * DENTRO DE STRING, TENEMOS DOS FORMAS DE ESCRIBIR DICHOS CARACTERES
             * 1) C:\carpeta\1.txt
             * UTILIZAR DOBLE BARRA
             * this.Ruta = "C:\\carpeta\\1.txt"
             * 2) Utilizar @ antes del String y fuera del String
             * this.Ruta = @"C:\\carpeta\\1.txt"
            */
            this.Ruta = "file1.txt";
            this.helper = new HelperFiles();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.lstNombres.Items.Add(this.txtNombre.Text);
            this.txtNombre.SelectAll();
            this.txtNombre.Text = "";
            this.txtNombre.Focus();
        }

        private async void btnLeer_Click(object sender, EventArgs e)
        {
            string contenido = await this.helper.ReadFileAsync(this.Ruta);
            this.txtContenido.Text = contenido;
            string[] nombres = contenido.Split(',');
            foreach(string nombre in nombres)
            {
                this.lstNombres.Items.Add(nombre);
            }
        }

        private async void btnEscribir_Click(object sender, EventArgs e)
        {
            string contenido = this.GetNombresListBox();
            this.helper.WriteFileAsync(this.Ruta, contenido);
            this.lstNombres.Items.Clear();
            MessageBox.Show("Fichero Almacenado");

        }

        public string GetNombresListBox()
        {
            string data = "";
            foreach(string nombre in this.lstNombres.Items)
            {
                data += nombre + ",";
            }
            data = data.Trim(',');
            return data;
        }
    }
}
