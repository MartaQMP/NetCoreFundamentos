using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form02ColoresPosicion : Form
    {
        public Form02ColoresPosicion()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            int rojo = int.Parse(this.txtRojo.Text);
            int verde = int.Parse(this.txtVerde.Text);
            int azul = int.Parse(this.txtAzul.Text);
            if (rojo < 0 || rojo > 255)
            {
                MessageBox.Show("El valor del rojo debe estar comprendido entre 0 y 255");
            }
            else if (verde < 0 || verde > 255)
            {
                MessageBox.Show("El valor del verde debe estar comprendido entre 0 y 255");
            }
            else if (azul < 0 || azul > 255)
            {
                MessageBox.Show("El valor del azul debe estar comprendido entre 0 y 255");
            }
            else
            {
                this.BackColor = Color.FromArgb(rojo, verde, azul);
            }
        }

        private void btnPosicion_Click(object sender, EventArgs e)
        {
            int ejex = int.Parse(this.txtEjeX.Text);
            int ejey = int.Parse(this.txtEjeY.Text);
            this.btnPosicion.Location = new Point(ejex, ejex);
        }
    }
}
