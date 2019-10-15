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
    public partial class FRM_Add_User : Form
    {
        public FRM_Add_User()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text == string.Empty || txtName.Text == string.Empty || txtPWD.Text == string.Empty || txtCPWD.Text == string.Empty || txtType.Text == string.Empty)
                {
                    MessageBox.Show("حدث خطأ ما", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (txtPWD.Text != txtCPWD.Text)
                {
                    MessageBox.Show("كلمات المرور غير متطابقة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (button1.Text == "إضافة")
                {
                    BL.CLS_Login User = new BL.CLS_Login();
                    User.Add_User(txtID.Text, txtName.Text, txtPWD.Text, txtType.Text);
                    MessageBox.Show("تمت الإضافة بنجاح", "عملية الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else if(button1.Text == "تحديث")
                {
                    BL.CLS_Login User = new BL.CLS_Login();
                    User.Edit_User(txtID.Text, txtName.Text, txtPWD.Text, txtType.Text);
                    MessageBox.Show("تم التعديل بنجاح", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("حدث خطأ ما", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCPWD_Validated(object sender, EventArgs e)
        {
            if(txtPWD.Text != txtCPWD.Text)
            {
                MessageBox.Show("كلمات المرور غير متطابقة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void txtID_MouseDown(object sender, MouseEventArgs e)
        {
        }

        private void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txtName.Focus();
            }
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txtPWD.Focus();
            }
        }

        private void txtPWD_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txtCPWD.Focus();
            }
        }
    }
}
