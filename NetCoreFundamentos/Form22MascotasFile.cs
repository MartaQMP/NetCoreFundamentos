using ProyectoClases.Helpers;
using ProyectoClases.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form22MascotasFile : Form
    {
        HelperMascotas helper;

        public Form22MascotasFile()
        {
            InitializeComponent();
            this.helper = new HelperMascotas();
        }

        /* CREAMOS UN METODO PARA DIBUJAR LA LISTA DE MASCOTAS */
        private void DibujarMascotas()
        {
            this.lstMascotas.Items.Clear();
            foreach (Mascota mascota in this.helper.Mascotas)
            {
                this.lstMascotas.Items.Add(mascota.Nombre);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Mascota mascota = new Mascota();
            mascota.Nombre = this.txtNombre.Text;
            mascota.Raza = this.txtRaza.Text;
            this.helper.Mascotas.Add(mascota);
            this.DibujarMascotas();
            this.txtNombre.Text = "";
            this.txtRaza.Text = "";
            this.txtNombre.Focus();
        }

        private async void btnLeer_Click(object sender, EventArgs e)
        {
            await this.helper.ReadMascotasAsync();
            this.DibujarMascotas();
        }

        private async void btnEscribir_Click(object sender, EventArgs e)
        {
            await this.helper.WriteMascotaAsync();
            this.lstMascotas.Items.Clear();
        }

        /* SELECCIONO UNA MASCOTA DE LA CAJA Y ME ESCRIBE LOS DATOS EN LOS TEXTBOX */
        private void lstMascotas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = this.lstMascotas.SelectedIndex;
            if(index != -1)
            {
                Mascota mascota = this.helper.Mascotas[index];
                this.txtNombre.Text = mascota.Nombre;
                this.txtRaza.Text = mascota.Raza;
            }
        }
    }
}
