using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovingCatMackenzie
{
    public partial class MovingCatForm : Form
    {
        public MovingCatForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.picCat.Image = Properties.Resources.cat1;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void MovingCatForm_Load(object sender, EventArgs e)
        {
            this.picCat.Image = Properties.Resources.cat2;
        }
    }
}
