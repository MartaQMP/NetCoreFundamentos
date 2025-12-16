using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace NetCoreFundamentos
{
    public partial class Form08StringBuilder : Form
    {
        public Form08StringBuilder()
        {
            InitializeComponent();
        }

        private void btnString_Click(object sender, EventArgs e)
        {
            string texto = this.txtTexto.Text;
            Stopwatch crono = new Stopwatch();
            int longitud = texto.Length;

            //COMENZAMOS EL PROCESO
            crono.Start();
            for (int i = 0; i < longitud; i++)
            {
                //SIEMPRE RECUPERAMOS LA ULTIMA LETRA
                char letra = texto[longitud - 1];
                texto = texto.Remove(longitud - 1, 1);
                texto = texto.Insert(i, letra.ToString());
            }
            //FINALIZAMOS EL PROCESO
            crono.Stop();
            //EL OBJETO Stopwatch TIENE UNA SERIE DE PROPIEDADES 
            //PARA COMPROBAR EL TIEMPO ENTRE EL PROCESO
            this.lblTiempo.Text = "Segundos: " + crono.Elapsed.Seconds + ", Milisegundos: " + crono.Elapsed.Milliseconds + ", Nanosegundos: " + crono.Elapsed.Nanoseconds;
            this.txtTexto.Text = texto;
        }

        private void btnBuilder_Click(object sender, EventArgs e)
        {
            StringBuilder texto = new StringBuilder();
            texto.Append(this.txtTexto.Text);
            Stopwatch crono = new Stopwatch();
            int longitud = texto.Length;

            //COMENZAMOS EL PROCESO
            crono.Start();
            for (int i = 0; i < longitud; i++)
            {
                //SIEMPRE RECUPERAMOS LA ULTIMA LETRA
                char letra = texto[longitud - 1];
                texto = texto.Remove(longitud - 1, 1);
                texto = texto.Insert(i, letra.ToString());
            }
            //FINALIZAMOS EL PROCESO
            crono.Stop();
            //EL OBJETO Stopwatch TIENE UNA SERIE DE PROPIEDADES 
            //PARA COMPROBAR EL TIEMPO ENTRE EL PROCESO
            this.lblTiempo.Text = "Segundos: " + crono.Elapsed.Seconds + ", Milisegundos: " + crono.Elapsed.Milliseconds + ", Nanosegundos: " + crono.Elapsed.Nanoseconds;
            this.txtTexto.Text = texto.ToString();
        }
    }
}
