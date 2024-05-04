using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalc_Click(object sender, EventArgs e)
        {
            
            if (!double.TryParse(txtMonto.Text, out double montoInicial) ||
                !double.TryParse(txtInteres.Text, out double tasaInteres) ||
                !int.TryParse(txtPeriodo.Text, out int periodo))
            {
                return;
            }

            
            double capitalFinal = montoInicial * Math.Pow((1 + tasaInteres / 100), periodo);
            double interesesAcumulados = capitalFinal - montoInicial;

            
            txtCapital.Text = capitalFinal.ToString("0.00");
            txtAcumulados.Text = interesesAcumulados.ToString("0.00");
        }
    }
}
