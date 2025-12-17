using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form14Metodos : Form
    {
        public Form14Metodos()
        {
            InitializeComponent();
        }

        //RECIBIMOS UN WRAPPER POR VALOR
        void GetDobleValor(int numero)
        {
            numero *= 2;
        }
        /*int GetDoble(int numero)
        {
            return numero * 2;
        }*/

        void CambiarColor(Button boton)
        {
            boton.BackColor = Color.Coral;
        }

        void GetDobleReferencia(ref int numero)
        {
            numero *= 2;
        }

        private void btnObjeto_Click(object sender, EventArgs e)
        {
            this.CambiarColor(this.btnObjeto);
        }

        private void btnValor_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(this.txtNumero.Text);
            this.GetDobleValor(numero);
            this.lblResultado.Text = numero.ToString();

            //this.lblResultado.Text = GetDoble(numero).ToString();
        }

        private void btnReferencia_Click(object sender, EventArgs e)
        {
            int num = int.Parse(this.txtNumero.Text);
            this.GetDobleReferencia(ref num);
            this.lblResultado.Text = num.ToString();
        }

        private void lblRaton_MouseMove(object sender, MouseEventArgs e)
        {
            this.lblRaton.Text = "X: " + e.X + ", Y: " + e.Y;
        }

        private void txtNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            //TENEMOS UNA ENUMERACION LLAMADA keys QUE NOS PERIMTE 
            //ACEDDER A LOS CODIGOS DEL TECLADO
            //DEBEMOS SABER EL CODIGO ASCII DE LA TECLA DE BORRAR
            char teclaBorrar = (char)Keys.Back;
            //EXISTE ALGUNA FORMA DE SABER SI UN CHAR ES UN NUMERO ???
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != teclaBorrar)
            {
                //INDICA SI NOS HACEMOS CARGO DEL EVENTO KEY
                e.Handled = true;
            }
            

        }

        private void txtLetras_KeyPress(object sender, KeyPressEventArgs e)
        {
            char teclaBorrar = (char)Keys.Back;
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != teclaBorrar)
            {
                //INDICA SI NOS HACEMOS CARGO DEL EVENTO KEY
                e.Handled = true;
            }
        }
    }
}
