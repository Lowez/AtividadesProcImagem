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

        public int desvio;

        public int getDesvio()
        {
            return desvio;
        }

        public valorGaussiano()
        {
            InitializeComponent();
        }

        private void btConfirm_Click(object sender, EventArgs e)
        {
            if (txDesvio.Text != "")
            {
                desvio = Convert.ToInt32(txDesvio.Text);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
