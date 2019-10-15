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
    public partial class FRM_Restore : Form
    {
        SqlConnection Con = new SqlConnection(@"Server = .\SQLEXPRESS; Database = master; Integrated Security = true");
        SqlCommand CMD;

        public FRM_Restore()
        {
            InitializeComponent();
            string mode = Properties.Settings.Default.Mode;

            //Connection String
            if (mode == "SQL")
            {
                Con = new SqlConnection(@"Server =" + Properties.Settings.Default.Server + "; Database = master ; Integrated Security = false; User ID =" + Properties.Settings.Default.ID + ";Password=" + Properties.Settings.Default.Password + "");
            }
            else
            {
                Con = new SqlConnection(@"Server =" + Properties.Settings.Default.Server + "; Database = master; Integrated Security = true");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFileName.Text = openFileDialog1.FileName;
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
                string strQuery = "Alter Database Pharmacy set offline with rollback immediate; Restore Database Pharmacy from Disk ='" + txtFileName.Text + "'";
                CMD = new SqlCommand(strQuery, Con);
                Con.Open();
                CMD.ExecuteNonQuery();
                Con.Close();
                MessageBox.Show("تم استعادة النسخة بنجاح", "استعادة النسخة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("حدث خطأ ما", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
