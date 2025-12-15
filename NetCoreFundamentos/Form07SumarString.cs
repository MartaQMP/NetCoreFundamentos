using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form07SumarString : Form
    {
        public Form07SumarString()
        {
            InitializeComponent();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            char[] caracteres = txtNumeros.Text.ToCharArray();
            int suma = 0;
            foreach (char caracter in caracteres){
                //suma += int.Parse(caracter.ToString());
                suma += Convert.ToInt32(caracter.ToString());
            }

            lblResultado.Text += suma.ToString();
        }
    }
}
