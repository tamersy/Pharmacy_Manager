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
    public partial class FRM_Customers_List : Form
    {
        //CLS_Customers object
        BL.CLS_Customers Cust = new BL.CLS_Customers();

        public FRM_Customers_List()
        {
            InitializeComponent();
            try
            {
                this.DGVcustomers.DataSource = Cust.Get_All_Customers();
            }
            catch
            {
                MessageBox.Show("حدث خطأ ما", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DGVcustomers_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
