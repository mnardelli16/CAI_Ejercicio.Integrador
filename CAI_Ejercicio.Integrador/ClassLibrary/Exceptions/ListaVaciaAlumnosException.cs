using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Exceptions
{
    public class ListaVaciaAlumnosException:Exception
    {
        public ListaVaciaAlumnosException() : base("No existen alumnos cargados en la lista..")
        {

        }
    }
}
