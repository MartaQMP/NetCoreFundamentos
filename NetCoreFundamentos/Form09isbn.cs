using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form09isbn : Form
    {
        public Form09isbn()
        {
            InitializeComponent();
        }

        private void btnComprobar_Click(object sender, EventArgs e)
        {
            string texto = this.txtCaja.Text;
            if(texto.Length != 10)
            {
                this.lblValido.Text = "No es valido debe tener 10 numeros";
                return;
            }
            int suma = 0;
            for(int i=0; i<texto.Length; i++)
            {
                suma += ((int)texto[i] * (i+1));
            }
            if(suma%11 != 0)
            {
                this.lblValido.Text = "No es valido";
            }else
            {
                this.lblValido.Text = "Es valido";
            }
        }
    }
}
