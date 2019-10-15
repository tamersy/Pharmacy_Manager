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
    public partial class FRM_Config : Form
    {
        public FRM_Config()
        {
            InitializeComponent();
            try
            {
                txtServerName.Text = Properties.Settings.Default.Server;
                txtDataBase.Text = Properties.Settings.Default.Database;
                if (Properties.Settings.Default.Mode == "SQL")
                {
                    RBsql.Checked = true;
                    txtServerName.Text = Properties.Settings.Default.Mode;
                    txtUserName.Text = Properties.Settings.Default.ID;
                    txtPassWord.Text = Properties.Settings.Default.Password;
                }
                else
                {
                    RBwin.Checked = true;
                    txtUserName.Clear();
                    txtUserName.Enabled = false;
                    txtUserName.ReadOnly = true;
                    txtPassWord.Clear();
                    txtPassWord.Enabled = false;
                    txtPassWord.ReadOnly = true;
                }
            }
            catch
            {
                MessageBox.Show("حدث خطأ ما", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BTNsave_Click(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default.Server = txtServerName.Text;
                Properties.Settings.Default.Database = txtDataBase.Text;
                Properties.Settings.Default.Mode = RBsql.Checked == true ? "SQL" : "Windows";
                Properties.Settings.Default.ID = txtUserName.Text;
                Properties.Settings.Default.Password = txtPassWord.Text;
                Properties.Settings.Default.Save();
            }
            catch
            {
                MessageBox.Show("حدث خطأ ما", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RBsql_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                txtUserName.ReadOnly = false;
                txtUserName.Enabled = true;
                txtPassWord.ReadOnly = false;
                txtPassWord.Enabled = true;
            }
            catch
            {
                MessageBox.Show("حدث خطأ ما", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RBwin_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                txtUserName.ReadOnly = true;
                txtUserName.Enabled = false;
                txtPassWord.ReadOnly = true;
                txtPassWord.Enabled = false;
            }
            catch
            {
                MessageBox.Show("حدث خطأ ما", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
