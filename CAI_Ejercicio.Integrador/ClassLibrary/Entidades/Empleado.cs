using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Entidades
{
    public abstract class Empleado :Persona
    {
        private DateTime _fechaIngreso;
        private int _legajo;

        private List<Salario> _salarios = new List<Salario>();

        public int Legajo
        {
            get { return this._legajo; }
            set { this._legajo = value; }
        }

        public DateTime FechaIngreso
        {
            get { return this._fechaIngreso; }
            set { this._fechaIngreso = value; }
        }

        public int Antiguedad
        {
            get { return Convert.ToInt32((DateTime.Now - this._fechaIngreso).TotalDays / 365); }
        }

        public DateTime FechaNacimiento
        {
            get { return this._fechaNac; }
            set { this._fechaNac = value; }
        }


        public string GetCredencial()
        {
            return string.Format("{0} - {1} salario $ {2}", this._legajo, GetNombreCompleto(), _salarios);
        }

    }
}
