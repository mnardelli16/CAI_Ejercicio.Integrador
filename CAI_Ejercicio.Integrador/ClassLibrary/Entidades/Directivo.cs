using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Entidades
{
    class Directivo:Empleado
    {
        public override string GetNombreCompleto()
        {
            return string.Format("Sr. Director {0}", this._apellido);
        }
    }
}
