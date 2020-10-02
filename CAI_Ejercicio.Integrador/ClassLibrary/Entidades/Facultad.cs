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
        private List<Alumno> _alumnos = new List<Alumno>();
        private int _cantidadSedes;
        private List<Empleado> _empleados = new List<Empleado>();
        private string _nombre;

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

        }
        public void AgregarAlumno(Alumno alumno) //creacion de la instancia pasando un objeto
        {
            this._alumnos.Add(alumno);
        }

        public void AgregarAlumno(string nombre, string apellido) //pase con parametros e instancia dentro del metodo
        {

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

        }
    }
}
