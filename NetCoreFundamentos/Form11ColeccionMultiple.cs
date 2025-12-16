using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form11ColeccionMultiple : Form
    {
        public Form11ColeccionMultiple()
        {
            InitializeComponent();
            this.lstElementos.SelectionMode = SelectionMode.MultiExtended;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            this.lstElementos.Items.Add(this.txtNuevo.Text);
            this.txtNuevo.Text = "";
            this.txtNuevo.Focus();
            this.txtNuevo.SelectAll();
        }

        private void btnSeleccionados_Click(object sender, EventArgs e)
        {
            string indices = "";
            string items = "";
            foreach (string item in this.lstElementos.SelectedItems)
            {
                items += item + ", ";
            }
            foreach (int index in this.lstElementos.SelectedIndices)
            {
                indices += index + ", ";
            }
            this.lblIndex.Text = indices.Trim(',');
            this.lblItem.Text = items.Trim(',');
        }

        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {
            this.lstElementos.Items.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //QUIERO ELIMINAR LOS ELEMENTOS SELECCIONADOS

            /*PARA LAS ACCIONES SOBRE LAS COLECCIONES SIEMPRE CON BUCLES CONTADOR*/

            /* PARA ELIMINAR SOBRE VARIOS SE ELIMINA DE MAYOR INDICE A MENOR PQ 
             * SINO AL ELIMINAR EL PRIMERO EL SEGUNDO CAMBIA SU INDICE*/
            int numElementos = this.lstElementos.SelectedIndices.Count - 1;

            for (int i = numElementos; i >= 0; i--)
            {
                this.lstElementos.Items.RemoveAt(this.lstElementos.SelectedIndices[i]);
            }
        }
    }
}
