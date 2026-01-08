using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ProyectoClases
{
    public class Director : Empleado
    {
        #region CONSTRUCTORES
        public Director()
        {
            Debug.WriteLine("Constructor DIRECTOR");
            this.SalarioMinimo +=200;
        }
        #endregion

        #region METODOS

        public override int GetDiasVacaciones()
        {
            Debug.WriteLine("GetVacaciones() DIRECTOR");
            return base.GetDiasVacaciones() + 8;
        }
        #endregion
    }
}
