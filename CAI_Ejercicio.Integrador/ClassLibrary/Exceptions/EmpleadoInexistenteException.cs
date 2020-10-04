using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Exceptions
{
    public class EmpleadoInexistenteException : Exception
    {
        public EmpleadoInexistenteException(): base("No existe el empleado cargado en la base..")
        {

        }
    }
}
