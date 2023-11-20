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
        public FrmCalculadora()
        {
            InitializeComponent();
        }
        private void Frmcalculadora_Load(object sender, EventArgs e)
        { }
            private void txtResultado_KeyPress(object sender, KeyPressEventArgs e){
            e.Handled = true;
        }

        private void agregarNumero(object sender, EventArgs e) {
            var boton = ((Button)sender);

            if (txtResultado.Text == "0") 
                txtResultado.Text = "";

            txtResultado.Text += boton.Text;
        }
       
    }
}
