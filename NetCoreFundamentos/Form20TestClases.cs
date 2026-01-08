using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ProyectoClases;

namespace NetCoreFundamentos
{
    public partial class Form20TestClases : Form
    {
        public Form20TestClases()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            persona.Nombre = "Marta";
            persona.Apellidos = "Quiros";
            persona.Edad = 20;
            persona.Nacionalidad = Paises.Italia;
            persona.Genero = TipoGenero.Femenino;
            persona.Domicilio = new Direccion();
            persona.Domicilio.Calle = "Calle Enero";
            persona.Domicilio.Ciudad = "Madrid";
            persona.Domicilio.CodigoPostal = 28030;
            //Poner nombre del reves
            this.lstClases.Items.Add(persona.GetNombreCompleto(true));
            //Info
            this.lstClases.Items.Add("Nombre: " + persona.Nombre +
                ", Apellidos: " + persona.Apellidos + ", Edad: " + persona.Edad +
                ", Genero: " + persona.Genero + ", Nacionalidad: " + persona.Nacionalidad + 
                "Direccion: " + persona.Domicilio.Calle + " " + persona.Domicilio.Ciudad + " " +
                persona.Domicilio.CodigoPostal);

        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            //Empleado emp = new Empleado("Marta", "Quiros");
            Empleado emp = new Empleado();
            emp.Nombre = "Becario";
            emp.Apellidos = "Becario";
            this.lstClases.Items.Add("Vacaciones Empleado: " + emp.GetDiasVacaciones());
            this.lstClases.Items.Add("Empleado: " + emp.GetNombreCompleto());
            this.lstClases.Items.Add("Salario: " + emp.GetSalarioMinimo() + "€");
            Director dir = new Director();
            dir.Nombre = "Director";
            dir.Apellidos = "Director";
            this.lstClases.Items.Add("Vacaciones Director: " + dir.GetDiasVacaciones());
            this.lstClases.Items.Add("Director: " + dir.GetNombreCompleto());
            this.lstClases.Items.Add("Salario: " + dir.GetSalarioMinimo() + "€");
        }
    }
}
