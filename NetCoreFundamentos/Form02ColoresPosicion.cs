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
            this.BackColor = Color.FromArgb(rojo, verde, azul);
        }

        private void btnPosicion_Click(object sender, EventArgs e)
        {
            int ejex = int.Parse(this.txtEjeX.Text);
            int ejey = int.Parse(this.txtEjeY.Text);
            this.btnPosicion.Location = new Point(ejex, ejex);
        }
    }
}
