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
    public partial class FRM_Login : Form
    {
        //Class Login object
        BL.CLS_Login Log = new BL.CLS_Login();

        public FRM_Login()
        {
            InitializeComponent();
            timer1.Stop();
        }

        private void BTN_Cancel_Click(object sender, EventArgs e)
        {
            //Close form
            this.Close();
        }

        private void BTN_Login_Click(object sender, EventArgs e)
        {
            try
            {
                //DataTable object
                DataTable DT = Log.Login(txtID.Text, txtPWD.Text);

                //Start ProgressBar
                timer1.Start();

                //Result
                if (DT.Rows.Count > 0)
                {
                    if (DT.Rows[0][2].ToString() == "Admin")
                    {
                        //Enable menus if login success
                        FRM_Main.getMainForm.الأدويةToolStripMenuItem.Enabled = true;
                        FRM_Main.getMainForm.العملاءToolStripMenuItem.Enabled = true;
                        FRM_Main.getMainForm.المستخدمونToolStripMenuItem.Enabled = true;
                        FRM_Main.getMainForm.إنشاءنسخةإحتياطيةToolStripMenuItem.Enabled = true;
                        FRM_Main.getMainForm.استعادةنسخةمحفوظةToolStripMenuItem.Enabled = true;
                        Program.SaleMan = DT.Rows[0]["FullName"].ToString();
                        FRM_Main.getMainForm.المستخدمونToolStripMenuItem.Visible = true;
                        this.Close();
                    }
                    else
                    {
                        //Enable menus if login success
                        FRM_Main.getMainForm.الأدويةToolStripMenuItem.Enabled = true;
                        FRM_Main.getMainForm.العملاءToolStripMenuItem.Enabled = true;
                        FRM_Main.getMainForm.المستخدمونToolStripMenuItem.Visible = false;
                        FRM_Main.getMainForm.إنشاءنسخةإحتياطيةToolStripMenuItem.Enabled = true;
                        FRM_Main.getMainForm.استعادةنسخةمحفوظةToolStripMenuItem.Enabled = true;
                        Program.SaleMan = DT.Rows[0]["FullName"].ToString();
                        this.Close();
                    }
                }
                else
                {
                    //Message if login failed
                    MessageBox.Show("فشل تسجيل الدخول", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("حدث خطأ ما", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            while (progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.Value += 2;
            }
        }

        private void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txtPWD.Focus();
            }
        }
    }
}
