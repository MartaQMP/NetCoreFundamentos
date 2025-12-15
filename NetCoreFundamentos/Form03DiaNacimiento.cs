using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form03DiaNacimiento : Form
    {
        public Form03DiaNacimiento()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int dia = int.Parse(this.txtDia.Text);
            int mes = int.Parse(this.txtMes.Text);
            int anio = int.Parse(this.txtAnio.Text);

            if(mes == 1)
            {
                mes = 13;
                anio --;
            }else if(mes == 2)
            {
                mes = 14;
                anio --;
            }

            int primero = ((mes + 1) * 3) / 5;
            int segundo = anio / 4;
            int tercero = anio / 100;
            int cuarto = anio / 400;
            int quinto = dia + (mes * 2) + anio + primero + segundo - tercero + cuarto + 2;
            int sexto = quinto / 7;
            int resultado = quinto - (sexto * 7);

            switch (resultado)
            {
                case 0:
                    {
                        this.lblDiaSemana.Text = "El dia de la semana es SABADO";
                        break;
                    }
                case 1:
                    {
                        this.lblDiaSemana.Text = "El dia de la semana es DOMINGO";
                        break;
                    }
                case 2:
                    {
                        this.lblDiaSemana.Text = "El dia de la semana es LUNES";
                        break;
                    }
                case 3:
                    {
                        this.lblDiaSemana.Text = "El dia de la semana es MARTES";
                        break;
                    }
                case 4:
                    {
                        this.lblDiaSemana.Text = "El dia de la semana es MIERCOLES";
                        break;
                    }
                case 5:
                    {
                        this.lblDiaSemana.Text = "El dia de la semana es JUEVES";
                        break;
                    }
                case 6:
                    {
                        this.lblDiaSemana.Text = "El dia de la semana es VIERNES";
                        break;
                    }
            }
        }
    }
}
