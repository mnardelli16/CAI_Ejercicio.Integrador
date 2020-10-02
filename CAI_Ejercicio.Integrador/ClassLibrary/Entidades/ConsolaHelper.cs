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
            Console.WriteLine("Ingrese el codigo de alumno: ");
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

    }
}
