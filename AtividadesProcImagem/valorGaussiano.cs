using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadesProcImagem
{
    public partial class valorGaussiano : Form
    {

        public double sigma;

        public double getSigma()
        {
            return sigma;
        }

        public valorGaussiano()
        {
            InitializeComponent();
        }

        private void btConfirm_Click(object sender, EventArgs e)
        {
            if (txDesvio.Text != "")
            {
                sigma = Convert.ToDouble(txDesvio.Text);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
