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
    public partial class FRM_Orders_List : Form
    {
        //CLS_Orders object
        BL.CLS_Orders Order = new BL.CLS_Orders();

        public FRM_Orders_List()
        {
            InitializeComponent();
            try
            {
                this.dataGridView1.DataSource = Order.Search_Orders("");
            }
            catch
            {
                MessageBox.Show("حدث خطأ ما", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            this.label2.ForeColor = Color.Red;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            this.label2.ForeColor = Color.Black;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.dataGridView1.DataSource = Order.Search_Orders(txtSearch.Text);
            }
            catch
            {
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int Order_ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

                this.Cursor = Cursors.WaitCursor;
                RPT.RPT_Orders RPT = new RPT.RPT_Orders();
                RPT.FRM_RPT_Medicine FRM = new RPT.FRM_RPT_Medicine();
                RPT.SetDataSource(Order.Get_Order_Details(Order_ID));
                FRM.crystalReportViewer1.ReportSource = RPT;
                FRM.ShowDialog();
                this.Cursor = Cursors.Default;
            }
            catch
            {
                MessageBox.Show("حدث خطأ ما", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
