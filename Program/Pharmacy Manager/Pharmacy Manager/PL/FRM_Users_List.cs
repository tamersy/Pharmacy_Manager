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
    public partial class FRM_Users_List : Form
    {
        //CLS_Login
        BL.CLS_Login Login = new BL.CLS_Login();

        public FRM_Users_List()
        {
            InitializeComponent();
            this.dataGridView1.DataSource = Login.SearchUsers("");
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

        private void button1_Click(object sender, EventArgs e)
        {
            FRM_Add_User FRM = new FRM_Add_User();
            FRM.ShowDialog();
            this.dataGridView1.DataSource = Login.SearchUsers("");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                FRM_Add_User FRM = new FRM_Add_User();
                FRM.txtID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                FRM.txtID.Enabled = false;
                FRM.txtName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                FRM.txtPWD.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                FRM.txtCPWD.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                FRM.txtType.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                FRM.button1.Text = "تحديث";
                FRM.Text = "تعديل بيانات المستخدم";
                FRM.ShowDialog();
                this.dataGridView1.DataSource = Login.SearchUsers("");
            }
            catch
            {
                MessageBox.Show("حدث خطأ ما", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = Login.SearchUsers(textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("هل أنت متأكد من الحذف؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    Login.Delete_User(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    MessageBox.Show("تم الحذف بنجاح", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.dataGridView1.DataSource = Login.SearchUsers("");
                }
            }
            catch
            {
                MessageBox.Show("حدث خطأ ما", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
