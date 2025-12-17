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
    public partial class Form15ArrayList : Form
    {
        public Form15ArrayList()
        {
            InitializeComponent();

            //CREAMOS UNA COLECCION GENERICA
            List<Button> botones = new List<Button>();
            //DETECTA AUTOMATICAMENTE LOS ELEMENTOS
            botones.Add(this.button1);
            botones.Add(this.button2);
            botones.Add(this.button3);
            botones[0].BackColor = Color.RoyalBlue;




           




            //VAMOS A CREAR UNA COLECCION NO TIPADA
            ArrayList coleccion = new ArrayList();
            coleccion.Add(this.button1);
            coleccion.Add(this.button2);
            coleccion.Add(this.button3);

            //SI DESEAMOS ACCEDER A UN OBJETO Y MODIFICAR ALGUNA CARACTERISTICA
            //NECESITAMOS REALIZAR CASTING
            ((Button)coleccion[0]).BackColor = Color.Aquamarine;
            //PODEMOS REALIZAR CASTING CON foreach 
            foreach (Button boton in coleccion)
            {
                boton.BackColor = Color.BlueViolet;
            }
            //Y SI AÑADIMOS OTRO CONTROL QUE NO SEA UN BUTTON??
            coleccion.Add(this.textBox1);
            //NOS ABSTRAEMOS PARA CASTING EN TODOS LOS OBJETOS
            foreach (Control boton in coleccion)
            {
                boton.BackColor = Color.Salmon;
                //CUADNO TENEMOS MULTIPLES OBJETOS DE DIFERENTES CLASES
                //NOS PODEMOS ABSTRAER EN EL RECORRIDO, PERO A LO MEJOR
                //NECESITAMOS ALGUNA CARACTERISTICA ESPECIAL DE CADA UNO.
                //UNA CAJA TIENE UN METODO LLAMADO paste()
                if(boton is TextBox)
                {
                    ((TextBox)boton).Paste();
                }
            }

            this.button1.Click += MetodoDelegado;
        }


        void MetodoDelegado(object sender, EventArgs e)
        {

        }
    }
}
