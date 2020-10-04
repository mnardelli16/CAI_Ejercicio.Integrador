using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Entidades
{
    public class ConsolaHelper
    {
        public string PedirNombre()
        {
            Console.WriteLine("Ingrese el Nombre: ");
            return Console.ReadLine();
        }
        public string PedirApodo()
        {
            Console.WriteLine("Ingrese el Apodo: ");
            return Console.ReadLine();
        }
        public string PedirApellido()
        {
            Console.WriteLine("Ingrese el Apellido: ");
            return Console.ReadLine();
        }
        public string PedirFechaNac()
        {
            Console.WriteLine("Ingrese la fecha de nacimiento: ");
            return Console.ReadLine();
        }
        public string PedirCodigoAlumno()
        {
            Console.WriteLine("Ingrese el codigo de alumno a eliminar: ");
            return Console.ReadLine();
        }
        public string PedirLegajoEmpleadoEliminar()
        {
            Console.WriteLine("Ingrese el legajo del Empleado a eliminar: ");
            return Console.ReadLine();
        }
        public string PedirSalarioBruto()
        {
            Console.WriteLine("Ingrese el salario bruto: ");
            return Console.ReadLine();
        }
        public string PedirFechaIngresoLaboral()
        {
            Console.WriteLine("Ingrese la fecha de inicio laboral: ");
            return Console.ReadLine();
        }
        public string PedirTipoEmpleado()
        {
            Console.WriteLine("Ingrese el tipo de empleado: B - Bedel, C - Directivo, D - Docente ");
            return Console.ReadLine();
        }
        public string PedirLegajo()
        {
            Console.WriteLine("Ingrese el legajo a buscar: ");
            return Console.ReadLine();
        }
        public string PedirLegajoAModificar()
        {
            Console.WriteLine("Ingrese el legajo a modificar: ");
            return Console.ReadLine();
        }
        public string PedirMenu()
        {
            Console.WriteLine("Elija una opcion del menu: ");
            return Console.ReadLine();
        }

        public string SeguirMenu()
        {
            Console.WriteLine("Desea elegir otra opcion S/N : ");
            return Console.ReadLine();
        }

        public void MostrarMensaje(string msj)
        {
            Console.WriteLine(msj);
        }

        public string PedirModificar() 
        {
            return Console.ReadLine();
        }


    }
}
