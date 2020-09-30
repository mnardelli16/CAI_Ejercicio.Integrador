using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.Entidades;

namespace ProyectoConsola
{
    class MenuConsola
    {
        public void PantallaInicio()
        {
            string _msj;

            _msj =
                "-----------------------------------------------------------------------------\n" +
                "---------------------------BIENVENIDO A LA FACULTAD--------------------------\n" +
                "-----------------------------------------------------------------------------\n\n" +
                "MENU:                                       \n" +
                "1 - Agregar alumnos                         \n" +
                "2 - Mostrar alumnos                         \n" +
                "3 - Quitar alumnos                        \n\n" +
                "4 - Agregar empleados                       \n" +
                "5 - Mostrar empleados                       \n" +
                "6 - Mostrar empleado por legajo             \n" +
                "7 - Mostrar empleado por nombre             \n" +
                "8 - Modificar datos de empleado             \n" +
                "9 - Quitar empleados                        \n";

            new ConsolaHelper().MostrarMensaje(_msj);
        }
        public int EleccionMenu()
        {
            string _opcion;
            bool _flag;

            do
            {
                _opcion = new ConsolaHelper().PedirMenu();
                _flag = new Validaciones().ValidarIngresoCaso(_opcion);

            } while (_flag == false);


            return Convert.ToInt32(_opcion);
        }
    }
}
