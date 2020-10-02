using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Exceptions
{
    class AlumnoInexistenteException:Exception
    {
        public AlumnoInexistenteException() : base("No existe el alumno cargado en la base")
        {

        }
    }
}
