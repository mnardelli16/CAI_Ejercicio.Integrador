using System;
using System.Collections.Generic;
using System.Linq;
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

        public void AgregarAlumno(Alumno alumno)
        {
            this._alumnos.Add(alumno);
        }
        public Facultad()
        {

        }

        public void TraerAlumnos()
        {
            foreach(Alumno A in _alumnos)
            {
                new ConsolaHelper().MostrarMensaje(A.ToString());
            }

        } 


    }
}
