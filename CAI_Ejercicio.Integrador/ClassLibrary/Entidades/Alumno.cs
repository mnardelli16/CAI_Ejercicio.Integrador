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

        public Alumno()
        {

        }
        public Alumno(string nombre, string apellido, DateTime fechanac)
        {
            this._apellido = apellido;
            this._nombre = nombre;
            this._fechaNac = fechanac;
            this._codigo = GetCodigoAleatorio();
        }

        public override string ToString()
        {
            return GetCredencial();
        }
        public string GetCredencial()
        {
            return string.Format("Codigo {0}, {1}, {2}", this._codigo, this._apellido, this._nombre);
        }
        public virtual int GetCodigoAleatorio()
        {
            Random rnd = new Random();
            int num = rnd.Next(5000);
            return num; 
        }

    }
}
