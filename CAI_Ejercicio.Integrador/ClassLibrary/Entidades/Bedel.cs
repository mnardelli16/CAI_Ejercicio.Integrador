using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Entidades
{
    class Bedel:Empleado
    {
        private string _apodo;

        public string Apodo
        {
            get { return this._apodo; }
            set { this._apodo = value; }
        }


        public Bedel(string nombre, string apellido, double bruto, DateTime fechaingreso, DateTime fechanac, string apodo) :base(nombre,apellido, fechanac, fechaingreso, bruto)
        {
            this._apodo = apodo;
        }

        public override string GetNombreCompleto()
        {
            return string.Format("Bedel {0}",this._apodo);
        }
    }
}
