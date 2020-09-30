using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Entidades
{
    public class Alumno : Persona
    {
        //ATRIBTOS
        private int _codigo;

        //PROPIEDADES
        public int Codigo
        {
            get { return this._codigo; }
            set { this._codigo = value; }
        }

        //public string Credencial
        //{
        //    get { return }
        //}

        public Alumno()
        {

        }
        public Alumno(string nombre, string apellido, DateTime fechanac, int codigo)
        {
            this._apellido = apellido;
            this._nombre = nombre;
            this._fechaNac = fechanac;
            this._codigo = codigo;
        }

        public override string ToString()
        {
            return GetCredencial();
        }
        public string GetCredencial()
        {
            return string.Format("Codigo {0}, {1}, {2}", this._codigo, this._apellido, this._nombre);
        }

    }
}
