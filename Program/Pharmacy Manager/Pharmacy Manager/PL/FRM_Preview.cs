using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Manager.PL
{
    public partial class FRM_Preview : Form
    {
        public FRM_Preview()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            this.label1.ForeColor = Color.Red;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            this.label1.ForeColor = Color.Black;
        }
    }
}
