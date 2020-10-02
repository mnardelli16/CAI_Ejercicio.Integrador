using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
using ClassLibrary.Entidades;
using ClassLibrary.Exceptions;

namespace ProyectoConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuConsola M = new MenuConsola();
            Facultad F = new Facultad();
            ConsolaHelper H = new ConsolaHelper();
            Validaciones V = new Validaciones();

            M.PantallaInicio();

            string seguir;

            do
            {
                int _opcion = M.EleccionMenu(); // elijo una opcion del menu
                try
                {
                    switch (_opcion)
                    {
                        case 1:
                            {
                                AgregarAlumnos(F);
                                break;
                            }
                        case 2:
                            {
                                F.TraerAlumnos();
                                break;
                            }
                        case 3:
                            {
                                EliminarAlumno(F);
                                break;
                            }
                        case 4:
                            {
                                break;
                            }
                        case 5:
                            {
                                break;
                            }
                        case 6:
                            {
                                break;
                            }
                        case 7:
                            {
                                break;
                            }
                        case 8:
                            {
                                break;
                            }
                        case 9:
                            {
                                break;
                            }
                    }

                }
                catch (Exception ex)
                {
                    H.MostrarMensaje((ex.Message));
                }

                bool ok;

                do
                {
                    seguir = H.SeguirMenu();
                    ok = V.ValidarSalida(seguir);
                } while (!ok);


            } while (seguir == "S");

            H.MostrarMensaje("HASTA LUEGO");

            //System.Console.Clear();


            Console.ReadKey();
        }

        static void AgregarAlumnos(Facultad a)
        {
            ConsolaHelper H = new ConsolaHelper();
            Validaciones V = new Validaciones();

            try
            {
                string nombre;
                string apellido;
                DateTime Fechanac = new DateTime();
                bool flag = false;
                do
                {
                    nombre = H.PedirNombre();
                    flag = V.ValidarStringNULL(nombre);
                } while (!flag);

                bool flag2 = false;
                do
                {
                    apellido = H.PedirApellido();
                    flag2 = V.ValidarStringNULL(apellido);
                } while (!flag2);

                bool flag3 = false;
                do
                {
                    string fechanac = H.PedirFechaNac();
                    flag3 = V.ValidarFecha(fechanac, ref Fechanac);
                } while (!flag3);

                Alumno A = new Alumno(nombre, apellido, Fechanac);

                a.AgregarAlumno(A);
            }
            catch (Exception e)
            {
                H.MostrarMensaje(e.ToString());
            }
        }

        static void EliminarAlumno(Facultad F)
        {
            ConsolaHelper H = new ConsolaHelper();
            Validaciones V = new Validaciones();

            try
            {
                if (F.CantidadAlumnos() == 0)
                {
                    throw new ListaVaciaAlumnosException();
                }
                else
                {
                    H.MostrarMensaje("Listado de alumnos: ");
                    F.TraerAlumnos();
                }

                string codigo = H.PedirCodigoAlumno(); // falta buscar al alumno en la lista


                F.EliminarAlumno(1); // eliminar por codigo

            }
            catch (ListaVaciaAlumnosException e)
            {
                H.MostrarMensaje(e.Message);
            }
        }
    }
}
