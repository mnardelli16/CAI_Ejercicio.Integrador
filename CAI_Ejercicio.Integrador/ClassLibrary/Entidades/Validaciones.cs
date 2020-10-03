using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Entidades
{
    public class Validaciones
    {
        ConsolaHelper H = new ConsolaHelper();
        public bool ValidarStringNULL(string a)
        {
            bool flag = false;
            if (string.IsNullOrWhiteSpace(a))
            {
                H.MostrarMensaje("No debe dejar espacios en blanco");
            }
            else
            {
                flag = true;
            }
            return flag;
        }

        public bool ValidarFecha(string fecha, ref DateTime salida)
        {
            bool flag = false;
            if(!DateTime.TryParse(fecha, out salida))
            {
                H.MostrarMensaje("No es un formato de fecha valido");
            }
            else
            {
                flag = true;
            }
            return flag;
        }

        public bool ValidarIngresoCaso(string opcion)
        {
            bool _flag = false;
            int _caso;

            if (!Int32.TryParse(opcion, out _caso))
            {
                H.MostrarMensaje("Debe ingresar una opcion valida");
            }
            else if (_caso < 1 || _caso > 9)
            {
                H.MostrarMensaje("Debe ingresar una opcion valida");
            }
            else
                _flag = true;

            return _flag;
        }

        public bool ValidarSalida(string a)
        {
            bool flag = false;
            if (string.IsNullOrWhiteSpace(a))
            {
                H.MostrarMensaje("No debe dejar espacios en blanco");
            }
            else if (a == "S")
            {
                flag = true;
            }
            else if (a == "N")
            {
                flag = true;
            }
            else
            {
                H.MostrarMensaje("No son opciones validas");
            }
            return flag;
        }

        public bool ValidarCodigoAlumno(string a)
        {
            bool flag = false;
            if(!Int32.TryParse(a, out int salida))
            {
                H.MostrarMensaje("No es un formato numerico valido");
            }
            else if(salida <= 0 || salida > 50)
            {
                H.MostrarMensaje("Debe ser menor a 50 y mayor a 0");
            }
            else
            {
                flag = true;
            }
            return flag;
        }

        public bool ValidarTipoEmpleado (string a)
        {
            bool flag = false;
            if (string.IsNullOrWhiteSpace(a))
            {
                H.MostrarMensaje("No debe dejar espacios en blanco");
            }
            else if (a != "B" && a != "C" && a != "D")
            {
                H.MostrarMensaje("No es un tipo valido");
            }
            else
            {
                flag = true;
            }
            return flag;
        }

        public bool ValidarSalarioBruto(string a, ref double salario)
        {
            bool flag = false;
            if (!Double.TryParse(a, out salario))
            {
                H.MostrarMensaje("No es un formato numerico valido");
            }
            else if (salario <= 0)
            {
                H.MostrarMensaje("Debe ser mayor a 0");
            }
            else
            {
                flag = true;
            }
            return flag;
        }
    }
}
