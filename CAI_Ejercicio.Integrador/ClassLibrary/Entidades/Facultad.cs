using ClassLibrary.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Security.Cryptography;
using System.Text;


namespace ClassLibrary.Entidades
{
    public class Facultad
    {
        private List<Alumno> _alumnos;
        private int _cantidadSedes;
        private List<Empleado> _empleados;
        private string _nombre;
        ConsolaHelper H = new ConsolaHelper();

        public int CantidadSedes
        {
            get { return this._cantidadSedes; }
            set { this._cantidadSedes = value; }
        }

        public string Nombre
        {
            get { return this._nombre; }
            set { this._nombre = value; }
        }
        public Facultad()
        {
            this._alumnos =  new List<Alumno>(); // se declaran en el constructor
            this._empleados = new List<Empleado>(); // se declaran en el constructor
        }
        public void AgregarAlumno(Alumno alumno) //creacion de la instancia pasando un objeto
        {
            try
            {
                if (alumno.Edad < 18)
                {
                    throw new Exception("El alumno es menor de edad");
                }
                else
                {
                    this._alumnos.Add(alumno);
                    H.MostrarMensaje("Alumno agregado con exito!");
                }

            }
            catch(Exception e)
            {
                H.MostrarMensaje(e.Message);
            }

        }

        public void AgregarAlumno(string nombre, string apellido, DateTime fechanac) //pase con parametros e instancia dentro del metodo
        {
            Alumno A = new Alumno(nombre, apellido, fechanac);

            AgregarAlumno(A);

            this._alumnos.Add(A);
        }


        public void TraerAlumnos()
        {
            try
            {
                if (CantidadAlumnos() == 0)
                {
                    throw new ListaVaciaAlumnosException();
                }
                else
                {
                    foreach (Alumno A in _alumnos)
                    {
                        new ConsolaHelper().MostrarMensaje(A.ToString());
                    }
                }
            }
            catch (ListaVaciaAlumnosException e)
            {
                new ConsolaHelper().MostrarMensaje(e.Message);
            }

        }

        public int CantidadAlumnos()
        {
            return _alumnos.Count;
        }

        public void EliminarAlumno(int codigo)
        {
            try
            {
                if (BuscarAlumno(codigo) == null)
                {
                    throw new AlumnoInexistenteException();
                }
                else
                {
                    Alumno A = BuscarAlumno(codigo);
                    _alumnos.Remove(A);
                    H.MostrarMensaje("Alumno eliminado con exito!");
                }

            }
            catch (AlumnoInexistenteException e)
            {
                H.MostrarMensaje(e.Message);
            }

        }

        public Alumno BuscarAlumno(int codigo)
        {
            return _alumnos.Find(a => a.Codigo == codigo);
        }

        public void AgregarEmpleado(string nombre, string apellido, DateTime ingreso, string tipo, string apodo, double bruto, DateTime fechanac)
        {
            Empleado Emp;
            try
            {
                switch (tipo)
                {
                    case "B":
                        {
                            Emp = new Bedel(nombre, apellido, bruto, ingreso, fechanac, apodo);
                            break;
                        }
                    case "C":
                        {
                            Emp = new Directivo(nombre, apellido, fechanac, ingreso, bruto);
                            break;
                        }
                    case "D":
                        {
                            Emp = new Docente(nombre, apellido, fechanac, ingreso, bruto);
                            break;
                        }
                    default:
                        throw new Exception("Tipo inválido.");
                }
                
                this._empleados.Add(Emp);
                H.MostrarMensaje("Empleado agregado con exito!");

            }
            catch (Exception e)
            {
                H.MostrarMensaje(e.Message);
            }
        }

        public void TraerEmpleados()
        {
            try
            {
                if (_empleados.Count == 0)
                {
                    throw new ListaEmpleadoVaciaException();
                }
                else
                {
                    foreach (Empleado e in _empleados)
                    {
                        new ConsolaHelper().MostrarMensaje(e.ToString());
                    }
                }
            }
            catch(ListaEmpleadoVaciaException e)
            {
                new ConsolaHelper().MostrarMensaje(e.Message);
            }
        }
    }
}
