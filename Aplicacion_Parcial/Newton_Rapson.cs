using Calculus;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion_Parcial
{
    public partial class Newton_Rapson : Form
    {
        public Newton_Rapson()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                tablaDatos.Rows.Clear(); //esto para limpiar por si le vuelve a dar al boton
                //Definicion de variables
                double x = double.Parse(inputX0.Text); // nos ayudara con el almacenamiento de la x sub 0
                double error = double.Parse(inputError.Text); // nos ayudara con el almacenamiento del error requerido
                string polinomio = inputPolinomio.Text.ToLower(); // nos ayudara con el almacenamiento del polinomio y el toLower es por si coloca la X en mayuscula eso no afecte
                string derivada = inputDerivada.Text.ToLower(); // nos ayudara con el almacenamiento de la derivada y el toLower es por si coloca la X en mayuscula eso no afecte
                double fxi = 0;
                double fxiDerivada = 0;
                double errorObtenido = 0;
                double xiMas1 = 0.0; //se ocupara para guardar el valor de la siguiente iteracion
                int i = 0;

                do
                {
                    //Primeramente obtendremos las Fx tanto de la derivada como la del polinomio
                    fxi = calcularPolinomio(x, polinomio);
                    fxiDerivada = calcularPolinomio(x, derivada);

                    //Ahora calcularemos el x sub i mas 1
                    xiMas1 = x - (fxi / fxiDerivada);

                    //Ahora calcularemos el error
                    if (i > 0) // esto se hace para evitar el primer calculo dado que siempre es 100%
                    {
                        errorObtenido = ((xiMas1 - x) / xiMas1) * 100;

                        if(errorObtenido < 0) //esto con el objetivo que si se llega a obtener en negativo el dato se pueda pasar a positivo para poder seguir iterando
                        {
                            errorObtenido *= -1;
                        }
                    }
                    else
                    {
                        errorObtenido = 100;
                    }

                    //Agregamos los datos a la tabla
                    tablaDatos.Rows.Add(i,x,fxi,fxiDerivada,errorObtenido);

                    //Ahora hacemos los cambios para las variables
                    x = xiMas1;
                    i += 1;
                }
                while (errorObtenido > error);

            }
            catch (FormatException)
            {
                MessageBox.Show("Hubo algun error al momento de recibir un tipo de dato.");
            }
        }

        private double calcularPolinomio(double x, string polinomio)
        {
            double fxDevolver = 0.0; //sera la variable que calculamos y devolveremos

            Calculo calcuPolinomio = new Calculo(); // instanciamos un objeto de la libreria calculus
            calcuPolinomio.Sintaxis(polinomio, 'x'); //aqui le decimos la letra que debe sustituir
            fxDevolver = calcuPolinomio.EvaluaFx(x); // valor calculado ocuando la funcion EvaluarFx de la libreria Calculus
            return fxDevolver;
        }
    }
}
