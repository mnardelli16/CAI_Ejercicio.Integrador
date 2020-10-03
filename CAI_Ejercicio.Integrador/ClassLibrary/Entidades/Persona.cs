using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Entidades
{
    public abstract class Persona
    {
        //ATRIBTOS
        protected string _apellido;
        protected string _nombre;
        protected DateTime _fechaNac;
        private int _edad;

        //PROPIEDADES
        public string Apellido
        {
            get { return this._apellido; }
            set { _apellido = value; }
        }

        public string Nombre
        {
            get { return this._nombre; }
            set { _nombre = value; }
        }

        public int Edad
        {
            get { return this._edad; }
            set { this._edad = value; }
        }

        //CONSTRUCTORES

        public Persona()
        {

        }

        public Persona(string nombre, string apellido, DateTime fechanac)
        {
            this._apellido = apellido;
            this._nombre = nombre;
            this._fechaNac = fechanac;
            this._edad = GetEdad();
        }

        //METODOS

        public virtual string GetNombreCompleto() 
        {
            return string.Format("{0}, {1}", this._apellido, this._nombre); 
        }

        public int GetEdad()
        {
            return Convert.ToInt32(((DateTime.Now - this._fechaNac).TotalDays / 365));
        }
    }
}
