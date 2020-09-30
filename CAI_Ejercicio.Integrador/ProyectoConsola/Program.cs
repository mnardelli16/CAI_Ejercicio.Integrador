using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
using ClassLibrary.Entidades;

namespace ProyectoConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuConsola M = new MenuConsola();
            Facultad F = new Facultad();

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
                    Console.WriteLine(ex.Message);
                }

                bool ok;

                do
                {
                    Console.WriteLine("Desea elegir otra opcion S/N : ");
                    seguir = Console.ReadLine();
                    ok = new Validaciones().ValidarSalida(seguir);
                } while (ok == false);


            } while (seguir == "S");

            Console.WriteLine("HASTA LUEGO");

            //System.Console.Clear();

            Console.ReadKey();





            Console.ReadKey();
        }

        static void AgregarAlumnos(Facultad a)
        {
            try
            {
                string nombre;
                string apellido;
                DateTime Fechanac = new DateTime();
                bool flag = false;
                do
                {
                    nombre = new ConsolaHelper().PedirNombre();
                    flag = new Validaciones().ValidarStringNULL(nombre);
                } while (!flag);
                bool flag2 = false;
                do
                {
                    apellido = new ConsolaHelper().PedirApellido();
                    flag2 = new Validaciones().ValidarStringNULL(apellido);
                } while (!flag2);
                bool flag3 = false;
                do
                {
                    string fechanac = new ConsolaHelper().PedirFechaNac();
                    flag3 = new Validaciones().ValidarFecha(fechanac, ref Fechanac);
                } while (!flag3);

                Alumno A = new Alumno(nombre, apellido, Fechanac, 1);

                a.AgregarAlumno(A);
            }
            catch (Exception e)
            {
                new ConsolaHelper().MostrarMensaje(e.ToString());
            }
        }
    }
}
