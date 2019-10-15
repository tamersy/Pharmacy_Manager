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
    public partial class FRM_BackUp : Form
    {
        SqlConnection Con;
        SqlCommand CMD;

        public FRM_BackUp()
        {
            InitializeComponent();
            string mode = Properties.Settings.Default.Mode;

            //Connection String
            if (mode == "SQL")
            {
                Con = new SqlConnection(@"Server =" + Properties.Settings.Default.Server + "; Database = " + Properties.Settings.Default.Database + "; Integrated Security = false; User ID =" + Properties.Settings.Default.ID + ";Password=" + Properties.Settings.Default.Password + "");
            }
            else
            {
                Con = new SqlConnection(@"Server =" + Properties.Settings.Default.Server + "; Database = " + Properties.Settings.Default.Database + "; Integrated Security = true");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFileName.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string FileName = txtFileName.Text + "\\Pharmacy" + "_" + DateTime.Now.ToLongDateString().Replace('/', '-');
                string strQuery = "Backup Database Pharmacy to Disk = '" + FileName + ".bak'";
                CMD = new SqlCommand(strQuery, Con);
                Con.Open();
                CMD.ExecuteNonQuery();
                Con.Close();
                MessageBox.Show("تم إنشاء النسخة بنجاح", "إنشاء النسخة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("حدث خطأ ما", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
