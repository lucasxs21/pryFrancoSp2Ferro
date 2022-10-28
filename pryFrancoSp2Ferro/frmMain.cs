using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryFrancoSp2Ferro
{
    public partial class frmMain : Form
    {   int resultado;
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void txtDistancia_TextChanged(object sender, EventArgs e)
        {
           string ComprueboDistancia = txtDistancia.Text.Trim();
            if (ComprueboDistancia.Length > 0)
            {
                int distancia = Convert.ToInt32(txtDistancia.Text);
                if (distancia > 0)
                {
                    if (Convert.ToInt32(txtDistancia.Text) >= 100 && numUpDown.Value >= 7)
                    {
                        resultado = Convert.ToInt32(txtDistancia.Text) * 5;
                        txtTotal.Text = Convert.ToString(resultado);
                        MessageBox.Show("Tiene descuento del 50%");

                    }
                    else
                    {
                        resultado = Convert.ToInt32(txtDistancia.Text) * 5;
                        resultado = resultado * 2;
                        txtTotal.Text = Convert.ToString(resultado);

                    }
                }
                
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
