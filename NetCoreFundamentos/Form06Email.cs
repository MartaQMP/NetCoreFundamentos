using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form06Email : Form
    {
        public Form06Email()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;

            //COMPRUEBO @
            if (!email.Contains("@"))
            {
                MessageBox.Show("Tiene que existir @", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (email.StartsWith("@") || email.EndsWith("@"))
            {
                MessageBox.Show("@ no puede estar al inicio ni al final", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int posArroba = email.IndexOf("@");
            if (email.IndexOf("@", posArroba + 1) != -1)
            {
                MessageBox.Show("Solo puede haber una @", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //COMPRUEBO .
            if (!email.Contains("."))
            {
                MessageBox.Show("Tiene que existir un punto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int posPunto = email.LastIndexOf(".");
            if (posPunto < posArroba)
            {
                MessageBox.Show("El punto debe ir después de la @", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //COMPRUEBO DOMINIO
            int dominio = email.Length - posPunto - 1;
            if (dominio < 2 || dominio > 3)
            {
                MessageBox.Show("El dominio debe tener 2 o 3 caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblResultado.Text = "Correcto";


        }
    }
}
