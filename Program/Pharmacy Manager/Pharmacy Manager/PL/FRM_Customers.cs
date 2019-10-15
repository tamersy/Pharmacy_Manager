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
    public partial class FRM_Customers : Form
    {
        //CLS_Customers object
        BL.CLS_Customers Cust = new BL.CLS_Customers();

        int ID, Position;

        public FRM_Customers()
        {
            InitializeComponent();
            try
            {
                this.dataGridView1.DataSource = Cust.Get_All_Customers();
                this.label6.Text = 0 + " / " + this.dataGridView1.Rows.Count;
            }
            catch
            {
                MessageBox.Show("حدث خطأ ما", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label8_MouseEnter(object sender, EventArgs e)
        {
            this.label8.ForeColor = Color.Red;
        }

        private void label8_MouseLeave(object sender, EventArgs e)
        {
            this.label8.ForeColor = Color.Black;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Cust.Add_Customer(Convert.ToInt32(txtID.Text), txtName.Text, txtLastName.Text, txtPhone.Text, txtEmail.Text);
                MessageBox.Show("تمت الإضافة بنجاح", "عملية الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                button1.Enabled = true;
                button2.Enabled = false;
                this.dataGridView1.DataSource = Cust.Get_All_Customers();
            }
            catch
            {
                MessageBox.Show("حدث خطأ ما", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                txtID.Text = Convert.ToString(Convert.ToInt32(Cust.Get_All_Customers().Rows[Cust.Get_All_Customers().Rows.Count - 1][0]) + 1);
                txtName.Clear();
                txtLastName.Clear();
                txtPhone.Clear();
                txtEmail.Clear();
                button2.Enabled = true;
                button1.Enabled = false;
                txtName.Focus();
            }
            catch
            {
                MessageBox.Show("حدث خطأ ما", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txtLastName.Focus();
            }
        }

        private void txtLastName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPhone.Focus();
            }
        }

        private void txtPhone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtEmail.Focus();
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                ID = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value);
                this.txtID.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                this.txtName.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                this.txtLastName.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                this.txtPhone.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                this.txtEmail.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            }
            catch
            {
                MessageBox.Show("حدث خطأ ما", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Cust.Edit_Customer(ID, txtName.Text, txtLastName.Text, txtPhone.Text, txtEmail.Text);
                MessageBox.Show("تم التعديل بنجاح", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                button1.Enabled = true;
                button2.Enabled = false;
                this.dataGridView1.DataSource = Cust.Get_All_Customers();
            }
            catch
            {
                MessageBox.Show("حدث خطأ ما", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("هل أنت متأكد من الحذف ؟", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Cust.Delete_Customer(ID);
                    MessageBox.Show("تم الحذف", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.dataGridView1.DataSource = Cust.Get_All_Customers();
                }
                else
                {
                    MessageBox.Show("تم إلغاء الحذف", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("حدث خطأ ما", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = Cust.Search_Customers(txtSearch.Text);
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(sender, e);
            }
        }

        void Navigate(int Index)
        {
            try
            {
                DataTable DT = Cust.Get_All_Customers();
                txtID.Text = DT.Rows[Index][0].ToString();
                txtName.Text = DT.Rows[Index][1].ToString();
                txtLastName.Text = DT.Rows[Index][2].ToString();
                txtPhone.Text = DT.Rows[Index][3].ToString();
                txtEmail.Text = DT.Rows[Index][4].ToString();
            }
            catch
            {
                MessageBox.Show("حدث خطأ ما", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            Navigate(0);
            this.label6.Text = 1 + " / " + this.dataGridView1.Rows.Count;
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            if(Position != 0)
            {
                Position -= 1;
                Navigate(Position);
                this.label6.Text = (Position + 1) + " / " + this.dataGridView1.Rows.Count;
            }
        }

        private void btnNex_Click(object sender, EventArgs e)
        {
            if(Position != Cust.Get_All_Customers().Rows.Count - 1)
            {
                Position += 1;
                Navigate(Position);
                this.label6.Text = (Position + 1) + " / " + this.dataGridView1.Rows.Count;
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            Position = Cust.Get_All_Customers().Rows.Count - 1;
            Navigate(Position);
            this.label6.Text = (Position + 1) + " / " + this.dataGridView1.Rows.Count;
        }
    }
}
