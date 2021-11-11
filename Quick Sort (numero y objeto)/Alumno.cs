using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quick_Sort
{
    class Alumno :IComparable<Alumno>
    {
        private string _strNombre;
        private int _intEdad;
        private double _dblEstatura;

        public string Nombre
        {
            get { return _strNombre; }
            set { _strNombre = value; }
        }

        public int Edad
        {
            get { return _intEdad; }
            set { _intEdad = value; }
        }

        public double Estatura
        {
            get{ return _dblEstatura; }
            set { _dblEstatura = value; }
        }

        public int CompareTo(Alumno otroAlumno)
        {
            if (this.Edad > otroAlumno.Edad)
                return (1);
            else
            if (this.Edad < otroAlumno.Edad)
                return (-1);
            else
                return (0);
        }

        //para comparar los nombres y ordenarlos
        //public int CompareTo(Alumno otroAlumno)
        //{
        //    return (this.Nombre.CompareTo(otroAlumno.Nombre));
        //}
    }
}
