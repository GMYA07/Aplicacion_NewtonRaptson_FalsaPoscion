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
    public partial class Falsa_Posicion : Form
    {
        public Falsa_Posicion()
        {
            InitializeComponent();
        }

        private void botonCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                tablaDatos.Rows.Clear();
                //DEFINICION DE VARIABLES
                double a = double.Parse(inputA.Text); //inicializamos la variable A 
                double b = double.Parse(inputB.Text); // inicializamos la variable B
                double xr = 0; //inicializamos la variable xr
                double xrAnterior = 0; //inicializamos la variable xr anterior 
                double fxA = 0; //inicializamos la variable f(a)
                double fxB = 0; //inicializamos la variable f(b) 
                double fxXr = 0; //inicializamos la variable f(xr)
                double fAxFxr= 0; //inicializamos la variable f(a) * f(xr)
                double error = double.Parse(inputError.Text); // inicializamos la variable del error
                double errorObtenido = 0;
                string polinomio = inputPolinomio.Text.ToLower(); // inicializamos la variable del polinomio
                int i = 1;
                do
                {
                    //Primero calculamos todos los f(a),f(b)
                    fxA = calcularPolinomio(a, polinomio);
                    fxB = calcularPolinomio(b, polinomio);

                    if (fxA > 0 && fxB > 0)
                    {
                        MessageBox.Show("En los intervalos proporcionados no existe una raiz.");
                    }else if (fxA < 0 && fxB < 0)
                    {
                        MessageBox.Show("En los intervalos proporcionados no existe una raiz.");
                    }
                    else {
                        //ahora calcularemos el XR
                        xr = b - ((fxB * (a - b)) / (fxA - fxB));

                        //Ahora calcularemos f(xr)
                        fxXr = calcularPolinomio(xr, polinomio);

                        //ahora calcularemos cual sera el cambio de variable si en a o en b
                        fAxFxr = fxA * fxXr;

                        //Ahora calcularemos el error % que hay
                        if (i > 1) // esto se hace para evitar el primer calculo dado que siempre es 100%
                        {
                            errorObtenido = ((xr - xrAnterior) / xr) * 100;

                            if (errorObtenido < 0) //esto con el objetivo que si se llega a obtener en negativo el dato se pueda pasar a positivo para poder seguir iterando
                            {
                                errorObtenido *= -1;
                            }
                        }
                        else
                        {
                            errorObtenido = 100;
                        }

                        tablaDatos.Rows.Add(i, a, b, fxA, fxB, xr, fxXr, fAxFxr, errorObtenido);

                        //Ahora realizaremos el cambio de variable y instanciar la variable xrPasada para las siguientes iteraciones
                        if (fAxFxr > 0)
                        {
                            a = xr;
                        }
                        else if (fAxFxr < 0)
                        {
                            b = xr;
                        }
                        else
                        {
                            break; //se da un brake por que dado caso encontro la raiz ya que esta en 0
                        }

                        //Ahora aumentamos 1 en la iteracion y guardamos el xr que se usara para el calculo de los errores
                        xrAnterior = xr;
                        i += 1;
                    }
                }
                while (errorObtenido > error);

            }
            catch(FormatException) 
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
