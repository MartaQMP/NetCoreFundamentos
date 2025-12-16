using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form12ColeccionNumeros : Form
    {
        public Form12ColeccionNumeros()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            this.lstCaja.Items.Clear();
            for (int i = 0; i < 10; i++)
            {
                Random num = new Random();
                int aleatorio = num.Next(0, 10);
                this.lstCaja.Items.Add(aleatorio);
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            int suma = 0, pares = 0, impares = 0;
            foreach(int num in this.lstCaja.Items)
            {
                suma += num;
                if (num % 2 == 0)
                {
                    pares += num ;
                }
                else
                {
                    impares += num ;
                }
            }
            this.txtSuma.Text = suma.ToString();
            this.txtPares.Text = pares.ToString();
            this.txtImpares.Text = impares.ToString();
        }
    }
}
