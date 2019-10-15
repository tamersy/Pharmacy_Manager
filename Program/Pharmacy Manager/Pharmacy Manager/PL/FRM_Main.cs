using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Pharmacy_Manager.PL
{
    public partial class FRM_Main : Form
    {
        //Single Instance
        public static FRM_Main Frm;
        //
        static void Frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Frm = null;
        }
        //
        public static FRM_Main getMainForm
        {
            get
            {
                if(Frm == null)
                {
                    Frm = new FRM_Main();
                    Frm.FormClosed += new FormClosedEventHandler(Frm_FormClosed);
                }
                return Frm;
            }
        }

        public FRM_Main()
        {
            InitializeComponent();
            if(Frm == null)
            {
                Frm = this;
            }
            this.الأدويةToolStripMenuItem.Enabled = false;
            this.العملاءToolStripMenuItem.Enabled = false;
            this.المستخدمونToolStripMenuItem.Enabled = false;
            this.إنشاءنسخةإحتياطيةToolStripMenuItem.Enabled = false;
            this.استعادةنسخةمحفوظةToolStripMenuItem.Enabled = false;
        }

        private void تسجيلالدخولToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //Open login window
                FRM_Login Frm = new FRM_Login();
                Frm.ShowDialog();
            }
            catch
            {
                MessageBox.Show("حدث خطأ ما !", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void إضافةدواءجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FRM_Add_M Frm = new FRM_Add_M();
                Frm.ShowDialog();
            }
            catch
            {
                MessageBox.Show("حدث خطأ ما !", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void إدارةالأدويةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FRM_Medicines Frm = new FRM_Medicines();
                Frm.ShowDialog();
            }
            catch
            {
                MessageBox.Show("حدث خطأ ما !", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void إدارةالأصنافToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FRM_Categories FRM = new FRM_Categories();
                FRM.ShowDialog();
            }
            catch
            {
                MessageBox.Show("حدث خطأ ما !", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void إدارةالعملاءToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FRM_Customers FRM = new FRM_Customers();
                FRM.ShowDialog();
            }
            catch
            {
                MessageBox.Show("حدث خطأ ما !", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void إداةعملياتالبيعToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FRM_Orders_List FRM = new FRM_Orders_List();
                FRM.ShowDialog();
            }
            catch
            {
                MessageBox.Show("حدث خطأ ما !", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void إضافةبيعجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FRM_Orders FRM = new FRM_Orders();
                FRM.ShowDialog();
            }
            catch
            {
                MessageBox.Show("حدث خطأ ما !", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void إضافةمستخدمجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FRM_Add_User FRM = new FRM_Add_User();
                FRM.ShowDialog();
            }
            catch
            {
                MessageBox.Show("حدث خطأ ما !", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void إدارةالمستخدمينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FRM_Users_List FRM = new FRM_Users_List();
                FRM.ShowDialog();
            }
            catch
            {
                MessageBox.Show("حدث خطأ ما !", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void إنشاءنسخةإحتياطيةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FRM_BackUp FRM = new FRM_BackUp();
                FRM.ShowDialog();
            }
            catch
            {
                MessageBox.Show("حدث خطأ ما !", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void استعادةنسخةمحفوظةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FRM_Restore FRM = new FRM_Restore();
                FRM.ShowDialog();
            }
            catch
            {
                MessageBox.Show("حدث خطأ ما !", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void إعداداتالاتصالبالسيرفرToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FRM_Config FRM = new FRM_Config();
                FRM.ShowDialog();
            }
            catch
            {
                MessageBox.Show("حدث خطأ ما !", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void معلوماتالإصدارToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FRM_About FRM = new FRM_About();
                FRM.ShowDialog();
            }
            catch
            {
                MessageBox.Show("حدث خطأ ما !", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void تعليماتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("C:\\Users\\USER\\source\\repos\\Pharmacy Manager\\PM_Use.html");
        }

        private void تسجيلالخروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.الأدويةToolStripMenuItem.Enabled = false;
            this.العملاءToolStripMenuItem.Enabled = false;
            this.المستخدمونToolStripMenuItem.Enabled = false;
            this.تسجيلالخروجToolStripMenuItem.Enabled = false;
        }
    }
}
