using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Exceptions
{
    public class ListaEmpleadoVaciaException:Exception
    {
        public ListaEmpleadoVaciaException() : base("No hay empleados en la lista")
        {

        }
    }
}
