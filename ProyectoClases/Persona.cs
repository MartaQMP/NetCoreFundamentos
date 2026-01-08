using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ProyectoClases
{

    public enum TipoGenero { Masculino, Femenino}
    public enum Paises { España, Italia, Alemania, Inglaterra}

    public class Persona
    {
        #region CONSTRUCTORES
        public Persona ()
        {
            /*PUEDO INICIALIZAR AQUI LA DIRECCION
             O HACERLO EN EL FORM */
            //this.Domicilio = new Direccion();
            Debug.WriteLine("Constructor PERSONA vacio");
        }

        public Persona (string nombre, string apellidos)
        {
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            Debug.WriteLine("Constructor PERSONA con 2 parametros");
        }

        #endregion


        #region PROPIEDADES

        public string _DescripcionThis;
        public string this[int indice]
        {
            get { return this._DescripcionThis; }
            set {
                /*DEVOLVEMOS UNA DESCRIPCION ALEATORIA DE NUESTRO NUMERO*/
                Random random = new Random();
                int dato = random.Next(1, 20);
                this._DescripcionThis = "Descripcion " + dato;
            }

        }

        public Direccion Domicilio { get; set; }
        public Direccion DomicilioVacaciones { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public Paises Nacionalidad { get; set; }
        /*PARA PONER EL SET CON RESTRICCIONES*/
        public TipoGenero _Genero;
        public TipoGenero Genero
        {
            get { return this._Genero; }
            set
            {
                if (value != TipoGenero.Femenino && value != TipoGenero.Masculino)
                {
                    throw new Exception("Ese genero no existe");
                }
                else
                {
                    this._Genero = value;
                }
            }
        }
        private int _Edad;
        public int Edad
        {
            get { return this._Edad; }
            set {
                if (value > 0)
                {
                    this._Edad = value;
                }
                else
                {
                    throw new Exception("La edad no puede ser negativa");
                }
            }
        }
        #endregion

        #region METODOS
        public string GetNombreCompleto()
        {
            return this.Nombre + " " + this.Apellidos;
        }

        public string GetNombreCompleto(bool orden)
        {
            return this.Apellidos + ", " + this.Nombre;
        }

        public string GetNombreCompleto(int num1)
        {
            return this.GetNombreCompleto().ToUpper();
        }

        public string GetNombreCompleto(int num1, int num2)
        {
            return this.GetNombreCompleto().ToLower();
        }
        #endregion
    }
}
