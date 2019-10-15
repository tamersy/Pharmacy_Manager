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
    public partial class FRM_Medicines_List : Form
    {
        //CLS_Medicines object
        BL.CLS_Medicines Med = new BL.CLS_Medicines();

        public FRM_Medicines_List()
        {
            InitializeComponent();
            try
            {
                this.dataGridView1.DataSource = Med.Get_All_Medicines();
            }
            catch
            {
                MessageBox.Show("حدث خطأ ما", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
