using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyeccalculadoraseba
{
    public enum Operacion
    {
        NoDefinida = 0,
        Suma = 1,
        Resta = 2,
        Division = 3,
        Multiplicacion = 4,
    }
    public partial class Form1 : Form
    {
        double valor1 = 0;
        double valor2 = 0;
        Operacion operado = Operacion.NoDefinida;
        bool unNumeroLeido = false;
        public Form1()
        {
            InitializeComponent();
        }
        private void LeerNumero(string numero)
        {
            unNumeroLeido = true;
            if (CajaResultado.Text == "0" && CajaResultado.Text != null)
            {
                CajaResultado.Text = numero;
            }
            else
            {
                CajaResultado.Text += numero;
            }
        }
        private double operacion()
        {
            double resultado = 0;
            switch (operado)
            {
                case Operacion.Suma:
                    resultado = valor1 + valor2;
                    break;

                case Operacion.Resta:
                    resultado = valor1 - valor2;
                    break;

                case Operacion.Division:
                    if (valor2 == 0)
                    {
                        lblHistorial.Text = " error division por 0 .";
                        resultado = 0;
                    }
                    else
                    {
                        resultado = valor1 / valor2;
                    }
                    break;

                case Operacion.Multiplicacion:
                    resultado = valor1 * valor2;
                    break;
            }
            return resultado;
        }
        private void Btn0_Click_1(object sender, EventArgs e)
        {
            unNumeroLeido = true;
            if (CajaResultado.Text == "0")
            {
                return;
            }
            else
            {
                CajaResultado.Text += "0";
            }
        }
        private void Btn1_Click_1(object sender, EventArgs e)
        {
            LeerNumero("1");
        }
        private void Btn2_Click_1(object sender, EventArgs e)
        {
            LeerNumero("2");
        }

        private void Btn3_Click_1(object sender, EventArgs e)
        {
            LeerNumero("3");
        }

        private void Btn4_Click_1(object sender, EventArgs e)
        {
            LeerNumero("4");
        }

        private void Btn5_Click_1(object sender, EventArgs e)
        {
            LeerNumero("5");
        }

        private void Btn6_Click_1(object sender, EventArgs e)
        {
            LeerNumero("6");
        }

        private void Btn7_Click_1(object sender, EventArgs e)
        {
            LeerNumero("7");
        }

        private void Btn8_Click_1(object sender, EventArgs e)
        {
            LeerNumero("8");
        }

        private void Btn9_Click_1(object sender, EventArgs e)
        {
            LeerNumero("9");
        }
        private void ObtenerValor(String operado)
        {
            valor1 = Convert.ToDouble(CajaResultado.Text);
            lblHistorial.Text = CajaResultado.Text + operado;
            CajaResultado.Text = "0";
        }
        private void BtnSuma_Click_1(object sender, EventArgs e)
        {
            operado = Operacion.Suma;
            ObtenerValor("+");
        }
        private void BtnResta_Click_1(object sender, EventArgs e)
        {
            operado = Operacion.Resta;
            ObtenerValor("-");
        }
        private void BtnMultiplicacion_Click_1(object sender, EventArgs e)
        {
            operado = Operacion.Multiplicacion;
            ObtenerValor("X");
        }
        private void BtnDivision_Click_1(object sender, EventArgs e)
        {
            operado = Operacion.Division;
            ObtenerValor("/");
        }
        private void BtnResultado_Click_1(object sender, EventArgs e)
        {
            if (valor2 == 0 && unNumeroLeido)
            {
                valor2 = Convert.ToDouble(CajaResultado.Text);
                lblHistorial.Text += valor2 + "=";
                double resultado = operacion();
                valor1 = 0;
                valor2 = 0;
                unNumeroLeido = false;
                CajaResultado.Text = Convert.ToString(resultado);
            }
        }
        private void BtnBorrar_Click_1(object sender, EventArgs e)
        {

            if (CajaResultado.Text.Length > 1)
            {
                string txtResultado = CajaResultado.Text;
                txtResultado = txtResultado.Substring(0, txtResultado.Length - 1);

                if (txtResultado.Length == 1 && txtResultado.Contains("-"))
                {
                    CajaResultado.Text = "0";
                }
                else
                {
                    CajaResultado.Text = txtResultado;
                }
            }
            else
            {
                CajaResultado.Text = "0";
            }
        }
        private void BtnPunto_Click_1(object sender, EventArgs e)
        {
            if (CajaResultado.Text.Contains('.'))
            {
                return;
            }
            CajaResultado.Text += ".";
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            CajaResultado.Text = "0";
            lblHistorial.Text = "";
        }
    }
}