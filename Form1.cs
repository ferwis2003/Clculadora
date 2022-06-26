using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_dcuE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool s = true;
        double Num1, resultado, Num2;
        string tipo, Borrado;

        private void num_cuatro_Click(object sender, EventArgs e)
        {
            if (s == true)
            {
                PantallaPrincipal.Text = "4";
                s = false;
            }
            else
            {
                PantallaPrincipal.Text = PantallaPrincipal.Text + "4";
            }
        }

        private void num_cinco_Click(object sender, EventArgs e)
        {
            if (s == true)
            {
                PantallaPrincipal.Text = "5";
                s = false;
            }
            else
            {
                PantallaPrincipal.Text = PantallaPrincipal.Text + "5";
            }
        }

        private void num_seis_Click(object sender, EventArgs e)
        {
            if (s == true)
            {
                PantallaPrincipal.Text = "6";
                s = false;
            }
            else
            {
                PantallaPrincipal.Text = PantallaPrincipal.Text + "6";
            }
        }

        private void num_siete_Click(object sender, EventArgs e)
        {
            if (s == true)
            {
                PantallaPrincipal.Text = "7";
                s = false;
            }
            else
            {
                PantallaPrincipal.Text = PantallaPrincipal.Text + "7";
            }
        }

        private void num_ocho_Click(object sender, EventArgs e)
        {
            if (s == true)
            {
                PantallaPrincipal.Text = "8";
                s = false;
            }
            else
            {
                PantallaPrincipal.Text = PantallaPrincipal.Text + "8";
            }
        }

        private void num_nueve_Click(object sender, EventArgs e)
        {
            if (s == true)
            {
                PantallaPrincipal.Text = "9";
                s = false;
            }
            else
            {
                PantallaPrincipal.Text = PantallaPrincipal.Text + "9";
            }
        }

        private void num_cero_Click(object sender, EventArgs e)
        {
            if (PantallaPrincipal.Text == "0")
            {
                PantallaPrincipal.Text = "0";
            }
            else
            {
                PantallaPrincipal.Text = PantallaPrincipal.Text + "0";
            }
        }

        private void num_cero_cero_Click(object sender, EventArgs e)
        {
            if (PantallaPrincipal.Text == "0")
            {
                PantallaPrincipal.Text = "0";
            }
            else
            {
                PantallaPrincipal.Text = PantallaPrincipal.Text + "00";
            }
        }

        private void punto_Click(object sender, EventArgs e)
        {

        }

        private void igual_Click(object sender, EventArgs e)
        {
            Num2 = double.Parse(PantallaPrincipal.Text);

            if (tipo == "*")
            {
                resultado = Num1 * Num2;
                PantallaAnterior.Text = "=" + PantallaAnterior.Text + Num2.ToString();
                PantallaPrincipal.Text = resultado.ToString();
            }
            if (tipo == "-")
            {
                resultado = Num1 - Num2;
                PantallaAnterior.Text = "=" + PantallaAnterior.Text + Num2.ToString();
                PantallaPrincipal.Text = resultado.ToString();
            }
            if (tipo == "/")
            {
                resultado = Num1 / Num2;
                PantallaAnterior.Text = "=" + PantallaAnterior.Text + Num2.ToString();
                PantallaPrincipal.Text = resultado.ToString();
            }
            if (tipo == "+")
            {
                resultado = Num1 + Num2;
                PantallaAnterior.Text = "=" + PantallaAnterior.Text + Num2.ToString();
                PantallaPrincipal.Text = resultado.ToString();
            }
        }

        private void sumar_Click(object sender, EventArgs e)
        {
            tipo = "+";
            Num1 = double.Parse(PantallaPrincipal.Text);
            PantallaAnterior.Text = PantallaPrincipal.Text + "+";
            s = true;
        }

        private void restar_Click(object sender, EventArgs e)
        {
            tipo = "-";
            Num1 = double.Parse(PantallaPrincipal.Text);
            PantallaAnterior.Text = PantallaPrincipal.Text + "-";
            s = true;
        }

        private void multiplicar_Click(object sender, EventArgs e)
        {
            tipo = "*";
            Num1 = double.Parse(PantallaPrincipal.Text);
            PantallaAnterior.Text = PantallaPrincipal.Text + "*";
            s = true;
        }

        private void dividir_Click(object sender, EventArgs e)
        {
            tipo = "/";
            Num1 = double.Parse(PantallaPrincipal.Text);
            PantallaAnterior.Text = PantallaPrincipal.Text + "/";
            s = true;
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            int contador = 0;
            Borrado = PantallaPrincipal.Text;
            contador = Borrado.Length - 1;
            Borrado = Borrado.Substring(0, contador);
            PantallaPrincipal.Text = Borrado;

            if (PantallaPrincipal.Text == "")
            {
                PantallaPrincipal.Text = "0";
                s = true;
            }
        }

        private void elevado_dos_Click(object sender, EventArgs e)
        {
            Num1 = double.Parse(PantallaPrincipal.Text);
            resultado = Num1 * Num1;
            PantallaAnterior.Text = "=" + PantallaPrincipal.Text;
            PantallaPrincipal.Text = resultado.ToString();
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            PantallaPrincipal.Text = "0";
            PantallaAnterior.Text = "";
            s = true;
        }

        private void num_tres_Click(object sender, EventArgs e)
        {
            if (s == true)
            {
                PantallaPrincipal.Text = "3";
                s = false;
            }
            else
            {
                PantallaPrincipal.Text = PantallaPrincipal.Text + "3";
            }
        }

        private void num_dos_Click(object sender, EventArgs e)
        {
            if (s == true)
            {
                PantallaPrincipal.Text = "2";
                s = false;
            }
            else
            {
                PantallaPrincipal.Text = PantallaPrincipal.Text + "2";
            }
        }

        

        private void num_uno_Click(object sender, EventArgs e)
        {
            if (s == true)
            {
                PantallaPrincipal.Text = "1";
                s = false;
            }
            else
            {
                PantallaPrincipal.Text = PantallaPrincipal.Text + "1";
            }
        }
    }
}
