using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FallingObjectsMack
{
    public partial class frmFallingObjects : Form
    {
        public frmFallingObjects()
        {
            InitializeComponent();
            this.lblHeight.Hide();
            this.lblAnswer.Hide();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            this.lblHeight.Show();
            this.lblAnswer.Show();
        }

        private void lblHeight_Click(object sender, EventArgs e)
        {
            this.lblHeight.Hide();
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {

           
        }

        private void lblAnswer_Click(object sender, EventArgs e)
        {

        }
    }
}
