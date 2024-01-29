using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestionBancariaApp
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
            txtSaldo.Text = "1000";
            txtCantidad.Text = "0";
        }


        private void btOperar_Click(object sender, EventArgs e)
        {
            string operacion = "";
            double cantidad = 0.0d;

            try
            {
                while (!double.TryParse(txtCantidad.Text, out cantidad))
                {
                    throw new InvalidCastException("Introduce un valor numerico");
                }

                gestionBancaria cuenta = new gestionBancaria(Int32.Parse(txtSaldo.Text));

                if (rbReintegro.Checked)
                    operacion = "R";

                if (radioButton1.Checked)
                    operacion = "I";

                switch (operacion)
                {
                    case "R":
                        cuenta.realizarReintegro(cantidad);
                        break;

                    case "I":
                        cuenta.realizarIngreso(cantidad);
                        break;
                    default:
                        throw new NullReferenceException("Debes seleccionar una opción");
                }

                txtSaldo.Text = cuenta.obtenerSaldo().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
