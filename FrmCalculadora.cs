using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class FrmCalculadora : Form
    {

        double numero1 = 0, numero2 = 0;
        char operador;
        public FrmCalculadora()
        {
            InitializeComponent();
        }
        private void Frmcalculadora_Load(object sender, EventArgs e)
        { }
           
        private void agregarNumero(object sender, EventArgs e) {
            var boton = ((Button)sender);

            if (txtResultado.Text == "0") 
                txtResultado.Text = "";

            txtResultado.Text += boton.Text;
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            numero2 = Convert.ToDouble(txtResultado.Text);
            if (operador == '+')
            {
                txtResultado.Text = (numero1 + numero2).ToString();
                numero1 = Convert.ToDouble(txtResultado.Text);
            }
            else if (operador == '-')
            {
                txtResultado.Text = (numero1 - numero2).ToString();
                numero1 = Convert.ToDouble(txtResultado.Text);
            }
            else if (operador == '*')
            {
                txtResultado.Text = (numero1 * numero2).ToString();
                numero1 = Convert.ToDouble(txtResultado.Text);
            }
            else if (operador == '/')
            {
                if (txtResultado.Text != "0")
                {
                    txtResultado.Text = (numero1 / numero2).ToString();
                    numero1 = Convert.ToDouble(txtResultado.Text);
                }
            
            else
            {
                lblMensagem.Visible = true;
                lblMensagem.Text = "Não é possivel dividir  o número por 0.";
            }
        }

        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text.Length > 1)
            {
                txtResultado.Text = txtResultado.Text.Substring(0, txtResultado.Text.Length - 1);
            }
            else { txtResultado.Text = "0"; }
        }

        private void btnLimparTodos_Click(object sender, EventArgs e)
        {
            numero1 = 0;
            numero2 = 0;
            operador = '\0';
            txtResultado.Text = "0";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "0";

        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            if (!txtResultado.Text.Contains(",")) {
                txtResultado.Text += ",";            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            numero1 = Convert.ToDouble(txtResultado.Text);
            numero1 *= -1;
            txtResultado.Text = Convert.ToString(numero1);
        }

        private void clickOperador(object sender, EventArgs e) {
            var boton = ((Button)sender);
            numero1 = Convert.ToDouble(txtResultado.Text);
            operador = Convert.ToChar(boton.Tag);
            if (operador == '√')
            {
                numero1 = Math.Sqrt(numero1);
                txtResultado.Text = numero1.ToString();
            }
            else if (operador == '²')
            {

                numero1 = Math.Pow(numero1, 2);
                txtResultado.Text = numero1.ToString();
            }
            else if (operador == '%')
            {
                txtResultado.Text = (numero1 % numero2).ToString();
            }
            else {
                txtResultado.Text = "0";
            }
           
            
        }
        
    }
}
