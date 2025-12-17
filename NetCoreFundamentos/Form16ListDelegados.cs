using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form16ListDelegados : Form
    {
        int contador;
        public Form16ListDelegados()
        {
            InitializeComponent();
            this.contador = 0;
            /*ALMACENAMOS TODOS LOS BOTONES EN UNA NUEVA COLECCION*/
            List<Button> botones = new List<Button>();
            /*AÑADIMOS DINAMICAMENTE TODOS LOS BOTONES DEL FORMULARIO*/
            foreach(Control control in this.Controls)
            {
                /*PREGUNTAMOS POR EL TIPO DE CONTROL*/
                if(control is Button)
                {
                    botones.Add((Button)control);
                }
            }
            /*VAMOS A CREAR UN METODO PARA QUE TODOS LOS BOTONES LEAN
             AL SER PULSADOS*/
            foreach (Button boton in botones)
            {
                boton.Click += PulsarBoton;
            }
        }

        private void PulsarBoton(object? sender, EventArgs e)
        {
            this.contador++;
            this.textBox1.Text = contador.ToString();
            /*QUEREMOS ACCEDER AL OBJETO QUE HA REALIZADO LA PETICION
             AL METODO. MEDIANTE sender SE CAPTURA DICHO OBJETO*/
            ((Button)sender).BackColor = Color.BurlyWood;

        }
    }
}
