using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Entidades
{
    public abstract class Empleado : Persona
    {
        private DateTime _fechaIngreso;
        private int _legajo;
        private Salario _ultimosalario;
        private List<Salario> _salarios;

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

        public List<Salario> Salarios
        {
            get { return this._salarios; }
        }

        public Salario UltimoSalario
        {
            get { return this._ultimosalario; }
            set { this._ultimosalario = value; }
        }
        public Empleado()
        {

        }
        public Empleado(string nombre, string apellido, DateTime fechanac, DateTime fechaingreso, double bruto):base(nombre, apellido, fechanac)
        {
            this._fechaIngreso = fechaingreso;
            this._legajo = GetLegajoAleatorio();
            this._ultimosalario = new Salario(bruto);
            this._salarios = new List<Salario>();
            AgregarSalario(_ultimosalario);
        }
    

        public override string ToString()
        {
            return GetCredencial();
        }

        public override string GetNombreCompleto()
        {
            return string.Format("{0}", this._apellido);
        }

        public string NombreEmpleado()
        {
            return string.Format(this._nombre);
        }

        public virtual string GetCredencial()
        {
            return string.Format("{0} - {1} salario $ {2}", this._legajo, GetNombreCompleto(), this._ultimosalario.GetSalarioNeto().ToString());
        }
        
        public int GetLegajoAleatorio()
        {
            Random rnd = new Random();
            int num = rnd.Next(60,100);
            return num;
        }
        public void AgregarSalario(Salario s)
        {
            this._salarios.Add(s);
        }

        public override bool Equals(object obj)
        {

            if (obj == null)
            {
                return false;
            }
            if (!(obj is Empleado))
            {
                return false;
            }
            return (this.Legajo == ((Empleado)obj).Legajo);
        }

    }
}
