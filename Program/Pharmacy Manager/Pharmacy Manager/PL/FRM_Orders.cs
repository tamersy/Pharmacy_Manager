using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Pharmacy_Manager.PL
{
    public partial class FRM_Orders : Form
    {
        //CLS_Orders object
        BL.CLS_Orders Order = new BL.CLS_Orders();

        //DataTable object
        DataTable DT = new DataTable();

        void CreateDataTable()
        {
            try
            {
                DT.Columns.Add("معرف الدواء");
                DT.Columns.Add("اسم الدواء");
                DT.Columns.Add("الثمن");
                DT.Columns.Add("الكمية");
                DT.Columns.Add("المبلغ");
                this.dataGridView1.DataSource = DT;
            }
            catch
            {
                MessageBox.Show("حدث خطأ ما", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void SizeDGV()
        {
            try
            {
                this.dataGridView1.RowHeadersWidth = 68;
                this.dataGridView1.Columns[0].Width = this.label12.Width;
                this.dataGridView1.Columns[1].Width = this.label13.Width;
                this.dataGridView1.Columns[2].Width = this.label14.Width;
                this.dataGridView1.Columns[3].Width = this.label15.Width;
                this.dataGridView1.Columns[4].Width = this.label16.Width;
            }
            catch
            {
                MessageBox.Show("حدث خطأ ما", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void CalculateAmount()
        {
            if (txtPMed.Text != string.Empty && txtQMed.Text != string.Empty)
            {
                double Amount = Convert.ToDouble(txtPMed.Text) * Convert.ToInt32(txtQMed.Text);
                txtFPMed.Text = Amount.ToString();
            }
        }

        void ClearBoxes()
        {
            txtIDMed.Clear();
            txtNameMed.Clear();
            txtPMed.Clear();
            txtQMed.Clear();
            txtFPMed.Clear();
        }

        void ClearData()
        {
            try
            {
                this.txtID.Clear();
                this.txtDes.Clear();
                this.CustID.Clear();
                this.CustName.Clear();
                this.CustLastName.Clear();
                this.CustPhone.Clear();
                this.CustEmail.Clear();
                this.txtIDMed.Clear();
                this.txtNameMed.Clear();
                this.txtPMed.Clear();
                this.txtQMed.Clear();
                this.txtFPMed.Clear();
                DT.Clear();
                this.dataGridView1.DataSource = DT;
                this.txtSum.Clear();
                this.button3.Enabled = true;
                this.button4.Enabled = false;
                this.button5.Enabled = true;
            }
            catch
            {
                MessageBox.Show("حدث خطأ ما", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public FRM_Orders()
        {
            InitializeComponent();
            CreateDataTable();
            SizeDGV();
            txtUser.Text = Program.SaleMan;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label11_MouseEnter(object sender, EventArgs e)
        {
            this.label11.ForeColor = Color.Red;
        }

        private void label11_MouseLeave(object sender, EventArgs e)
        {
            this.label11.ForeColor = Color.Black;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.txtID.Text = Order.Get_Last_Order_ID().Rows[0][0].ToString();
            button3.Enabled = false;
            button4.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                FRM_Customers_List FRM = new FRM_Customers_List();
                FRM.ShowDialog();
                this.CustID.Text = FRM.DGVcustomers.CurrentRow.Cells[0].Value.ToString();
                this.CustName.Text = FRM.DGVcustomers.CurrentRow.Cells[1].Value.ToString();
                this.CustLastName.Text = FRM.DGVcustomers.CurrentRow.Cells[2].Value.ToString();
                this.CustPhone.Text = FRM.DGVcustomers.CurrentRow.Cells[3].Value.ToString();
                this.CustEmail.Text = FRM.DGVcustomers.CurrentRow.Cells[4].Value.ToString();
            }
            catch
            {
                MessageBox.Show("حدث خطأ ما", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                ClearBoxes();
                FRM_Medicines_List FRM = new FRM_Medicines_List();
                FRM.ShowDialog();
                this.txtIDMed.Text = FRM.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                this.txtNameMed.Text = FRM.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                this.txtPMed.Text = FRM.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txtQMed.Focus();
            }
            catch
            {
                MessageBox.Show("حدث خطأ ما", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtQMed_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtPMed_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator))
            {
                e.Handled = true;
            }
        }

        private void txtPMed_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtPMed.Text != string.Empty)
            {
                txtQMed.Focus();
            }
        }

        private void txtPMed_KeyUp(object sender, KeyEventArgs e)
        {
            CalculateAmount();
        }

        private void txtQMed_KeyUp(object sender, KeyEventArgs e)
        {
            CalculateAmount();
        }

        private void txtQMed_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        if (dataGridView1.Rows[i].Cells[0].Value.ToString() == txtIDMed.Text)
                        {
                            MessageBox.Show("هذا الدواء موجود مسبقاً", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                    }

                    if (Order.VerifyQty(txtIDMed.Text, Convert.ToInt32(txtQMed.Text)).Rows.Count < 1)
                    {
                        MessageBox.Show("هذه الكمية غير متاحة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    DataRow R = DT.NewRow();
                    R[0] = txtIDMed.Text;
                    R[1] = txtNameMed.Text;
                    R[2] = txtPMed.Text;
                    R[3] = txtQMed.Text;
                    R[4] = txtFPMed.Text;
                    DT.Rows.Add(R);
                    this.dataGridView1.DataSource = DT;
                    ClearBoxes();
                    this.txtSum.Text = (from DataGridViewRow Row in dataGridView1.Rows where Row.Cells[4].FormattedValue.ToString() != string.Empty select Convert.ToDouble(Row.Cells[4].FormattedValue)).Sum().ToString();
                }
            }
            catch
            {
                MessageBox.Show("حدث خطأ ما", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                txtIDMed.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtNameMed.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtPMed.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtQMed.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txtFPMed.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
            }
            catch
            {
                MessageBox.Show("حدث خطأ ما", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            this.txtSum.Text = (from DataGridViewRow Row in dataGridView1.Rows where Row.Cells[4].FormattedValue.ToString() != string.Empty select Convert.ToDouble(Row.Cells[4].FormattedValue)).Sum().ToString();
        }

        private void تعديلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1_DoubleClick(sender, e);
        }

        private void حذفالسطرالحاليToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
        }

        private void حذفالكلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DT.Clear();
            dataGridView1.DataSource = DT;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text == string.Empty || CustID.Text == string.Empty || dataGridView1.Rows.Count < 1 || txtDes.Text == string.Empty)
                {
                    MessageBox.Show("يجب إدخال المعلومات المهمة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Order.Add_Order(Convert.ToInt32(txtID.Text), DTP.Value, Convert.ToInt32(CustID.Text), txtDes.Text, txtUser.Text);
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    Order.Add_Order_Details(this.dataGridView1.Rows[i].Cells[0].Value.ToString(),
                                            Convert.ToInt32(txtID.Text),
                                            Convert.ToInt32(this.dataGridView1.Rows[i].Cells[3].Value),
                                            this.dataGridView1.Rows[i].Cells[2].Value.ToString(),
                                            this.dataGridView1.Rows[i].Cells[4].Value.ToString());
                }
                MessageBox.Show("تم الحفظ بنجاح", "عملية الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearData();
            }
            catch
            {
                MessageBox.Show("حدث خطأ ما", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                //Get the last order
                int Order_ID = Convert.ToInt32(Order.Get_Last_Order_ID_For_Print().Rows[0][0]);

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
