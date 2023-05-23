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
    public partial class valorDaOrdem : Form
    {

        public int bitOrdem;

        public int getBitOrdem()
        {
            return bitOrdem;
        }

        public valorDaOrdem()
        {
            InitializeComponent();
        }

        private void btConfirm_Click(object sender, EventArgs e)
        {
            if (txOrdem.Text != "")
            {
                bitOrdem = Convert.ToInt32(txOrdem.Text);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
