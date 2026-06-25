using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Taquilla_Cine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Boleto boleto = null;
            decimal precioBase = 80m;

            if (cmbTipoBoleto.SelectedItem.ToString() == "Estudiante")
            {
                boleto = new BoletoEstudiante(precioBase, "2026001");
            }
            else if (cmbTipoBoleto.SelectedItem.ToString() == "Adulto Mayor")
            {
                boleto = new BoletoAdultoMayor(precioBase, "INAPAM123");
            }
            else if (cmbTipoBoleto.SelectedItem.ToString() == "General")
            {
                boleto = new BoletoGeneral(precioBase);
            }

            if (boleto != null)
            {
                lblResultado.Text =
                    $"Total a pagar: ${boleto.CalcularPrecioFinal():0.00}";
            }
        }
    }
}
