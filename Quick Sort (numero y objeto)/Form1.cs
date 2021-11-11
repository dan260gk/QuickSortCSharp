using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Quick_Sort
{
    public partial class Form1 : Form
    {
        //declaracion del arreglo de alumnos
        Alumno[] miArregloAlumnos;

        //declaracion del arreglo de numeros
        int[] miArregloNumeros;

        public Form1()
        {
            InitializeComponent();
        }

        public int intTotalComparaciones = 0;
        public int intTotalIntercambios = 0;

        //al cargar la forma oculta los dtg
        private void Form1_Load(object sender, EventArgs e)
        {
            dtgAlumnosDesordenado.Visible = false;
            dtgAlumnosOrdenado.Visible = false;
        }

        //metodo para ordenar objetos
        private void QuickSortObjeto<Tipo>(Tipo[] arreglo, int izquierdo, int derecho) where Tipo : IComparable<Tipo>
        {
            int i = izquierdo;
            int d = derecho;
            int centro = (izquierdo + derecho) / 2;
            Tipo pivote = arreglo[centro];
            do
            {
                intTotalComparaciones++;
                while (arreglo[i].CompareTo(pivote) < 0)
                {
                    i++;
                }
                intTotalComparaciones++;
                while (arreglo[d].CompareTo(pivote) > 0)
                {
                    d--;
                }
                if (i <= d)
                {
                    IntercambiarObjeto<Tipo>(arreglo, i, d);
                    i++;
                    d--;
                }
            } while (i <= d);
            if (izquierdo < d)
            {
                QuickSortObjeto(arreglo, izquierdo, d);
            }
            if (i < derecho)
            {
                QuickSortObjeto(arreglo, i, derecho);
            }
        }

        //metodo que intercambia los datos en el arreglo de objetos
        void IntercambiarObjeto<Tipo>(Tipo[] arreglo, int i, int d)
        {
            intTotalIntercambios++;
            Tipo temp;
            temp = arreglo[i];
            arreglo[i] = arreglo[d];
            arreglo[d] = temp;
        }

        //metodo para ordenar numeros enteros
        private void QuickSort(int[] arreglo, int izquierdo, int derecho)
        {
            int i = izquierdo;
            int d = derecho;
            int pivote = arreglo[(izquierdo + derecho) / 2];
            do
            {
                intTotalComparaciones++;
                while (arreglo[i] < pivote)
                {
                    
                    i++;
                }
                intTotalComparaciones++;
                while (arreglo[d] > pivote)
                {
                    
                    d--;
                }
                if (i <= d)
                {
                    Intercambiar(arreglo, i, d);
                    i++;
                    d--;
                }
            } while (i <= d);

            if (izquierdo < d)
            {
                QuickSort(arreglo, izquierdo, d);
            }
            if (i < derecho)
            {
                QuickSort(arreglo, i, derecho);
            }
        }

        //metodo que intercambia los datos en el arreglo de numeros
        void Intercambiar(int[] arreglo ,int i, int d)
        {
            intTotalIntercambios++;
            int temp;
            temp = arreglo[i];
            arreglo[i] = arreglo[d];
            arreglo[d] = temp;
        }

        //boton que genera numeros u objetos aleatorios dependiendo de si el boton booleano "chkObjetos" esta presionado o no
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                if (chkObjeto.Checked)
                {
                    dtgAlumnosDesordenado.Rows.Clear();
                    dtgAlumnosOrdenado.Rows.Clear();
                    CapturarAlumnos();
                    MostrarArregloObjetosDesordenado();
                }
                else
                {
                    lstDatosDesordenados.Items.Clear();
                    lstDatosOrdenados.Items.Clear();
                    GenerarNumeros();

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese los datos correctamente", "Dato invalido detectado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        //metodo que genera numeros aleatorios y manda a llamar al metodo InsertarNumeros
        void GenerarNumeros()
        {
            Random Aleatorio = new Random();
            int i = 0;
            int cantidad = int.Parse(txtCantidadDatos.Text);
            while (i < int.Parse(txtCantidadDatos.Text))
            {
                lstDatosDesordenados.Items.Add(Aleatorio.Next(1, 1000));
                i++;
            }
            InsertarNumeros();
        }

        //metodo que genera e inserta los objetos (en este caso son alumnos) en el arreglo
        void CapturarAlumnos()
        {
            int cantidad = int.Parse(txtCantidadDatos.Text);
            Random Aleatorio = new Random();
            miArregloAlumnos = new Alumno[cantidad];
            for (int i=0; i<cantidad; i++)
            {
                Alumno miAlumno = new Alumno();
                miAlumno.Nombre = Guid.NewGuid().ToString().Substring(2, 9);
                miAlumno.Edad = Aleatorio.Next(12, 23);
                miAlumno.Estatura = Aleatorio.NextDouble() * 2;
                miArregloAlumnos[i] = miAlumno;
            }
        }

        //metodo que muestra los alumos desordenados en su respectivo dat grid view
        void MostrarArregloObjetosDesordenado()
        {
            foreach (Alumno alumno in miArregloAlumnos)
            {
                dtgAlumnosDesordenado.Rows.Add(alumno.Nombre, alumno.Edad, alumno.Estatura);
            }
        }

        //metodo que muestra los alumos despues de ser ordenados en el dtg de alumnos ordenados
        void MostrarArregloObjetosOrdenado()
        {
            foreach (Alumno alumno in miArregloAlumnos)
            {
                dtgAlumnosOrdenado.Rows.Add(alumno.Nombre, alumno.Edad, alumno.Estatura);
            }
        }

        //metodo que inserta los numeros desde la lista al arreglo
        void InsertarNumeros()
        {
            miArregloNumeros = new int[int.Parse(txtCantidadDatos.Text)];
            for (int i = 0; i < lstDatosDesordenados.Items.Count; i++)
            {
                miArregloNumeros[i] = Convert.ToInt32(lstDatosDesordenados.Items[i]);
            }
        }

        //metodo que muestra los numeros despues de ser ordenados en su respectiva lista
        void MostrarNumerosOrdenados()
        {
            lstDatosOrdenados.Items.Clear();

            for (int i = 0; i < miArregloNumeros.Length; i++)
            {
                if (miArregloNumeros[i] != 0)
                {
                    lstDatosOrdenados.Items.Add(miArregloNumeros[i]);
                }
            }
        }

        //boton que manda a llamar los metodos de ordenamiento dependiendo del estado del control chkObjeto
        //tambien manda a llamar los metodos que muestran los datos en sus respectivos controles
        // por ultimo muestra un menssaje con las comparaciones, intercambios y tiempo de ejecucion
        private void Ordenar_Click(object sender, EventArgs e)
        {
            double dblTiempoEjecucion = 0;
            if(chkObjeto.Checked)
            {
                Stopwatch stp = Stopwatch.StartNew();

                QuickSortObjeto<Alumno>(miArregloAlumnos, 0, miArregloAlumnos.Length - 1);

                stp.Stop();
                dblTiempoEjecucion = stp.Elapsed.TotalMilliseconds;
                MostrarArregloObjetosOrdenado();
            }
            else
            {
                Stopwatch stp = Stopwatch.StartNew();

                QuickSort(miArregloNumeros, 0, miArregloNumeros.Length - 1);

                stp.Stop();
                dblTiempoEjecucion = stp.Elapsed.TotalMilliseconds;
                MostrarNumerosOrdenados();
            }
            MessageBox.Show("Cantidad de comparaciones: "+intTotalComparaciones+"\nCantidad de intercambios: "+intTotalIntercambios+"\nTiempo en ejecucion: " + dblTiempoEjecucion + " ms.");
            intTotalComparaciones = 0;
            intTotalIntercambios = 0;

        }

        //boton booleano que oculta y muestra los controles dependiendo de lo que se vaya a mostrar
        private void chkObjeto_CheckedChanged(object sender, EventArgs e)
        {
            if(chkObjeto.Checked==true)
            {
                dtgAlumnosDesordenado.Visible = true;
                dtgAlumnosOrdenado.Visible = true;
                lstDatosDesordenados.Visible = false;
                lstDatosOrdenados.Visible = false;
            }
            else
            {
                dtgAlumnosDesordenado.Visible = false;
                dtgAlumnosOrdenado.Visible = false;
                lstDatosDesordenados.Visible = true;
                lstDatosOrdenados.Visible = true;
            }
        }
    }
}