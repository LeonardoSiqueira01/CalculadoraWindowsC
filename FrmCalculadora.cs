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
            if (operador == '+') {
                txtResultado.Text = (numero1 + numero2).ToString();
                numero1 = Convert.ToDouble(txtResultado.Text);
            }
             else if (operador == '-') {
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
                txtResultado.Text = (numero1 / numero2).ToString();
                numero1 = Convert.ToDouble(txtResultado.Text);
            }
        }

        private void clickOperador(object sender, EventArgs e) {
            var boton = ((Button)sender);
            numero1 = Convert.ToDouble(txtResultado.Text);
            if (operador == '√') {
                numero1 = Math.Sqrt(numero1);
                txtResultado.Text = numero1.ToString();
            } 
            else if (operador == '²') {

                numero1 = Math.Pow(numero1, 2);
                txtResultado.Text = numero1.ToString();
            }
            else if (operador == '%')
            {
                txtResultado.Text = (numero1 % numero2).ToString();
            }
            else
            {
                operador = Convert.ToChar(boton.Tag);
                txtResultado.Text = "0";
            }
            
        }
        
    }
}
