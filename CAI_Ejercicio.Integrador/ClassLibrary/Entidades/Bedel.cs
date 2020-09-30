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

        public override string GetNombreCompleto()
        {
            return string.Format("Bedel {0}",this._apodo);
        }
    }
}
