﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Resources;
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
                                AgregarEmpleado(F);
                                break;
                            }
                        case 5:
                            {
                                F.TraerEmpleados();
                                break;
                            }
                        case 6:
                            {
                                MostrarEmpleadoporLegajo(F);
                                break;
                            }
                        case 7:
                            {
                                MostrarEmpleadoporNombre(F);
                                break;
                            }
                        case 8:
                            {
                                ModificarEmpleado(F);
                                break;
                            }
                        case 9:
                            {
                                EliminarEmpleado(F);
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
                bool flag = false;
                string codigo;
                do
                {
                    codigo = H.PedirCodigoAlumno(); // falta buscar al alumno en la lista
                    flag = V.ValidarCodigoAlumno(codigo);
                } while (!flag);


                F.EliminarAlumno(Convert.ToInt32(codigo)); // eliminar por codigo

            }
            catch (ListaVaciaAlumnosException e)
            {
                H.MostrarMensaje(e.Message);
            }
        }

        static void AgregarEmpleado(Facultad F)
        {
            ConsolaHelper H = new ConsolaHelper();
            Validaciones V = new Validaciones();

            try
            {
                string nombre;
                string apellido;
                DateTime Fechanac = new DateTime();
                string tipoemp;
                DateTime _fechalaboral = new DateTime();
                string apodo = "";
                double bruto = 0;

                bool _fl = false;
                do
                {
                    tipoemp = H.PedirTipoEmpleado();
                    _fl = V.ValidarTipoEmpleado(tipoemp);
                } while (!_fl);
                
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

                bool flag4 = false;
                do
                {
                    string fechala = H.PedirFechaIngresoLaboral();
                    flag4 = V.ValidarFecha(fechala, ref _fechalaboral);
                } while (!flag4);

                bool flag6 = false;
                do
                {
                    string brutostr = H.PedirSalarioBruto();
                    flag6 = V.ValidarSalarioBruto(brutostr, ref bruto);
                } while (!flag6);

                if (tipoemp == "B")
                {
                    bool flag5 = false;
                    do
                    {
                        apodo = H.PedirApodo();
                        flag5 = V.ValidarStringNULL(apodo);
                    } while (!flag5);
                }

                F.AgregarEmpleado(nombre, apellido, _fechalaboral, tipoemp, apodo, bruto, Fechanac);

            } catch(Exception e)
            {
                H.MostrarMensaje(e.Message);
            }

        }

        static void MostrarEmpleadoporLegajo(Facultad F)
        {
            ConsolaHelper H = new ConsolaHelper();
            Validaciones V = new Validaciones();

            try
            {
                if(F.CantidadEmpleados() == 0)
                {
                    throw new ListaEmpleadoVaciaException();
                }
                else
                {
                    string legajo;
                    bool flag = false;
                    do
                    {
                        legajo = H.PedirLegajo();
                        flag = V.ValidarLegajoEmpleado(legajo);
                    } while (!flag);

                    try
                    {
                        if (F.TraerEmpleadoporLegajo(Convert.ToInt32(legajo)) == null)
                        {
                            throw new EmpleadoInexistenteException();
                        }
                        else
                        {
                            Empleado E = F.TraerEmpleadoporLegajo(Convert.ToInt32(legajo));
                            H.MostrarMensaje(E.ToString());

                        }
                    }
                    catch (EmpleadoInexistenteException a)
                    {
                        H.MostrarMensaje(a.Message);
                    }

                }
            }
            catch(ListaEmpleadoVaciaException e)
            {
                H.MostrarMensaje(e.Message);
            }

        }

        static void MostrarEmpleadoporNombre(Facultad F)
        {
            ConsolaHelper H = new ConsolaHelper();
            Validaciones V = new Validaciones();

            try
            {
                if (F.CantidadEmpleados() == 0)
                {
                    throw new ListaEmpleadoVaciaException();
                }
                else
                {

                    try
                    {
                        string nombre;
                        bool flag = false;

                        do
                        {
                            nombre = H.PedirNombre();
                            flag = V.ValidarStringNULL(nombre);
                        } while (!flag);

                        if(F.TraerEmpleadoPorNombre(nombre).Count == 0)
                        {
                            throw new Exception("No existe el empleado");
                        }
                        else
                        {
                            foreach(Empleado E in F.TraerEmpleadoPorNombre(nombre))
                            {
                                H.MostrarMensaje(E.ToString());
                            }
                        }

                    }
                    catch(Exception e)
                    {
                        H.MostrarMensaje(e.Message);
                    }

                }
            }
            catch (ListaEmpleadoVaciaException e)
            {
                H.MostrarMensaje(e.Message);
            }

        }

        static void ModificarEmpleado(Facultad F)
        {
            ConsolaHelper H = new ConsolaHelper();
            Validaciones V = new Validaciones();

            try
            {
                if (F.CantidadEmpleados() == 0)
                {
                    throw new ListaEmpleadoVaciaException();
                }
                else
                {
                    try
                    {
                        string leg;
                        bool flag = false;

                        do
                        {
                            leg = H.PedirLegajoAModificar();
                            flag = V.ValidarLegajoEmpleado(leg);
                        } while (!flag);

                        try
                        {
                            if (F.TraerEmpleadoporLegajo(Convert.ToInt32(leg)) == null)
                            {
                                throw new EmpleadoInexistenteException();
                            }
                            else
                            {
                                Empleado E = F.TraerEmpleadoporLegajo(Convert.ToInt32(leg));
                                H.MostrarMensaje("Nombre: " + E.Nombre + " Apellido: " + E.Apellido);

                                bool flag2 = false;
                                bool flag3 = false;
                                string pedirN;
                                string pedirA;
                                do
                                {
                                    H.MostrarMensaje("Ingrese el nuevo nombre o presione la tecla 'F' para saltear este paso: ");
                                    pedirN = H.PedirModificar();
                                    flag2 = V.ValidarStringNULL(pedirN);
                                } while (!flag2);

                                do
                                {
                                    H.MostrarMensaje("Ingrese el nuevo apellido o presione la tecla 'F' para saltear este paso: ");
                                    pedirA = H.PedirModificar();
                                    flag3 = V.ValidarStringNULL(pedirA);
                                } while (!flag3);

                                F.ModificarEmpleado(pedirN, pedirA, Convert.ToInt32(leg));
                            }

                        }
                        catch(EmpleadoInexistenteException e)
                        {
                            H.MostrarMensaje(e.Message);
                        }
                        
                    }
                    catch (Exception e)
                    {
                        H.MostrarMensaje(e.Message);
                    }

                }
            }
            catch (ListaEmpleadoVaciaException e)
            {
                H.MostrarMensaje(e.Message);
            }


        }

        static void EliminarEmpleado(Facultad F)
        {
            ConsolaHelper H = new ConsolaHelper();
            Validaciones V = new Validaciones();

            try
            {
                if (F.CantidadEmpleados() == 0)
                {
                    throw new ListaEmpleadoVaciaException();
                }
                else
                {
                    H.MostrarMensaje("Listado de Empleados: ");
                    F.TraerEmpleados();
                }
                bool flag = false;
                string legajo;
                do
                {
                    legajo = H.PedirLegajoEmpleadoEliminar(); 
                    flag = V.ValidarLegajoEmpleado(legajo);
                } while (!flag);


                F.EliminarEmpleado(Convert.ToInt32(legajo)); // eliminar por codigo

            }
            catch (ListaEmpleadoVaciaException e)
            {
                H.MostrarMensaje(e.Message);
            }
        }


    }
    
}
