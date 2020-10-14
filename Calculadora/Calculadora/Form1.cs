using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double n1;
        double n2;
        string operador;
        Calculadora calculo = new Calculadora();
        private void btn0_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "9";
        }

        private void btnpunto_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + ".";
        }

        private void btnsumar_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(txtPantalla.Text);
            operador = "+";
            txtPantalla.Clear();
        }

        private void btnresta_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(txtPantalla.Text);
            operador = "-";
            txtPantalla.Clear();
        }

        private void btnmultiplicar_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(txtPantalla.Text);
            operador = "*";
            txtPantalla.Clear();
        }

        private void btndividir_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(txtPantalla.Text);
            operador = "/";
            txtPantalla.Clear();
        }

        private void btnfactorial_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(txtPantalla.Text);
            operador = "!";
            txtPantalla.Clear();
        }

        private void btnporcentaje_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(txtPantalla.Text);
            txtPantalla.Clear();
            operador = "%";
            
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtPantalla.Clear();
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text == "")
            {
                if (operador == "!")
                {
                    double factor;

                    //factor = calculo.Factorial(n1);
                    txtPantalla.Text = Convert.ToString(calculo.Factorial(n1));//factor.ToString();
                }
            }
            else
            {
                n2 = Convert.ToDouble(txtPantalla.Text);

                double suma, resta, división, multiplicacion, porcentaje;

                switch (operador)
                {
                    case "+":
                        suma = calculo.Sumar(n1, n2);
                        txtPantalla.Text = suma.ToString();
                        break;
                    case "-":
                        resta = calculo.Restar(n1, n2);
                        txtPantalla.Text = resta.ToString();
                        break;
                    case "*":
                        multiplicacion = calculo.Multiplicar(n1, n2);
                        txtPantalla.Text = multiplicacion.ToString();
                        break;
                    case "/":
                        división = calculo.Dividir(n1, n2);
                        txtPantalla.Text = división.ToString();
                        break;
                    case "%":
                        porcentaje = calculo.Porcentaje(n1, n2);
                        txtPantalla.Text = porcentaje.ToString();
                        break;

                }
            }
            
        }
    }
}
