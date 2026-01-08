using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ProyectoClases
{
    public class Empleado: Persona
    {
        #region CONSTRUCTORES

        public Empleado()
        {
            Debug.WriteLine("Constructor EMPLEADO vacio");
            this.SalarioMinimo = 1600;
        }

        public Empleado(string nombre, string apellidos) : base(nombre, apellidos)
        {
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            Debug.WriteLine("Constructor EMPLEADO con 2 parametros");
        }

        #endregion

        #region PROPIEDADES

        protected int SalarioMinimo { get; set; }
        #endregion

        #region METODOS
        public int GetSalarioMinimo()
        {
            return this.SalarioMinimo;
        }

        public virtual int GetDiasVacaciones()
        {
            Debug.WriteLine("GetVacaciones() EMPLEADO");
            return 22;
        }
        #endregion
    }
}
