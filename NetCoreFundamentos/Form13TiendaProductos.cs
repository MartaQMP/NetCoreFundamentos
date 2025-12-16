using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form13TiendaProductos : Form
    {
        public Form13TiendaProductos()
        {
            InitializeComponent();
            this.lstTienda.SelectionMode = SelectionMode.MultiExtended;
            this.lstAlmacen.SelectionMode = SelectionMode.MultiExtended;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Boolean existe = false;
            foreach (string item in this.lstTienda.Items)
            {
                if (this.txtNuevo.Text == item)
                {
                    existe = true;
                }
            }
            if (!existe)
            {
                this.lstTienda.Items.Add(this.txtNuevo.Text);
                this.txtNuevo.Text = "";
            }
            this.txtNuevo.Focus();
            this.txtNuevo.SelectAll();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int numElementos = this.lstTienda.SelectedIndices.Count - 1;

            for (int i = numElementos; i >= 0; i--)
            {
                this.lstTienda.Items.RemoveAt(this.lstTienda.SelectedIndices[i]);
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            this.lstTienda.Items.Clear();
        }

        private void btnSeleccion_Click(object sender, EventArgs e)
        {

            for (int i = (lstTienda.SelectedItems.Count - 1); i >= 0; i--)
            {
                this.lstAlmacen.Items.Add(this.lstTienda.SelectedItems[i]);
                this.lstTienda.Items.RemoveAt(this.lstTienda.SelectedIndices[i]);
            }
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            for (int i = (this.lstTienda.Items.Count - 1); i >= 0; i--)
            {
                this.lstAlmacen.Items.Add(this.lstTienda.Items[i]);

            }
            this.lstTienda.Items.Clear();
        }

        private void btnSubir_Click(object sender, EventArgs e)
        {
            //COJO EL OBJETO SELECCIONADO Y SU INDEX
            string item = this.lstAlmacen.SelectedItem.ToString();
            int index = this.lstAlmacen.SelectedIndex;

            //MIRO Q NO SEA EL PRIMERO
            if (index != 0)
            {
                //ELIMINO DONDE ESTA
                this.lstAlmacen.Items.RemoveAt(index);
                //LO AGREGO UNA POSICION MAS ARRIBA
                this.lstAlmacen.Items.Insert(index - 1, item);
                this.lstAlmacen.SelectedIndex = index - 1;
            }


        }

        private void btnBajar_Click(object sender, EventArgs e)
        {
            //COJO EL OBJETO SELECCIONADO Y SU INDEX
            string item = this.lstAlmacen.SelectedItem.ToString();
            int index = this.lstAlmacen.SelectedIndex;

            //MIRO Q NO SEA EL ULTIMO
            if (index != this.lstAlmacen.Items.Count-1)
            {
                //ELIMINO DONDE ESTA
                this.lstAlmacen.Items.RemoveAt(index);
                //LO AGREGO UNA POSICION MAS ABAJO
                this.lstAlmacen.Items.Insert(index + 1, item);
                this.lstAlmacen.SelectedIndex = index + 1;
            }
        }
    }
}
