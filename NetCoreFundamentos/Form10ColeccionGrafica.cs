using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form10ColeccionGrafica : Form
    {
        public Form10ColeccionGrafica()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            this.lstElementos.Items.Add(this.txtNuevo.Text);
            this.txtNuevo.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //this.lstElementos.Items.Remove(this.lstElementos.SelectedItem);
            //MEJOR ESTO POR SI HAY ELEMENTOS REPETIDOS
            this.lstElementos.Items.RemoveAt(this.lstElementos.SelectedIndex);
        }

        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {
            this.lstElementos.Items.Clear();
        }

        private void lstElementos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lstElementos.SelectedIndex != -1)
            {
                this.lblIndex.Text = this.lstElementos.SelectedIndex.ToString();
                this.lblItem.Text = this.lstElementos.SelectedItem.ToString();
            }
        }

        private void Form10ColeccionGrafica_Load(object sender, EventArgs e)
        {

        }
    }
}
