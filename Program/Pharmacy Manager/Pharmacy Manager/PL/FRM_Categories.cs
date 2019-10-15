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
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.CrystalReports;
using CrystalDecisions.Shared;

namespace Pharmacy_Manager.PL
{
    public partial class FRM_Categories : Form
    {
        string mode = Properties.Settings.Default.Mode;

        //Connect to database
        SqlConnection SQLconnection;

        //SQLDataAdapter object
        SqlDataAdapter DA;

        //DataTable object
        DataTable DT = new DataTable();

        //BindingManagerBase object
        BindingManagerBase BMB;

        //SQLCommandBuilder object
        SqlCommandBuilder CMDB;

        public FRM_Categories()
        {
            InitializeComponent();
            try
            {
                //Connect to database
                if (mode == "SQL")
                {
                    SQLconnection = new SqlConnection(@"Server =" + Properties.Settings.Default.Server + "; Database = " + Properties.Settings.Default.Database + "; Integrated Security = false; User ID =" + Properties.Settings.Default.ID + ";Password=" + Properties.Settings.Default.Password + "");
                }
                else
                {
                    SQLconnection = new SqlConnection(@"Server =" + Properties.Settings.Default.Server + "; Database = " + Properties.Settings.Default.Database + "; Integrated Security = true");
                }

                DA = new SqlDataAdapter("Select ID_Cate as 'معرف الصنف', Des_Cate as 'اسم الصنف' From Categories", SQLconnection);
                DA.Fill(DT);
                this.dataGridView1.DataSource = DT;

                //DataBinding
                txtID.DataBindings.Add("Text", DT, "معرف الصنف");
                txtDes.DataBindings.Add("Text", DT, "اسم الصنف");

                //Value of BindingManagerBase object and its word
                BMB = this.BindingContext[DT];
                LbPos.Text = (BMB.Position + 1) + " / " + BMB.Count;
            }
            catch
            {
                MessageBox.Show("حدث خطأ ما", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            this.label3.ForeColor = Color.Red;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            this.label3.ForeColor = Color.Black;
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            BMB.Position = 0;
            LbPos.Text = (BMB.Position + 1) + " / " + BMB.Count;
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            BMB.Position = BMB.Count;
            LbPos.Text = (BMB.Position + 1) + " / " + BMB.Count;
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            BMB.Position -= 1;
            LbPos.Text = (BMB.Position + 1) + " / " + BMB.Count;
        }

        private void btnNex_Click(object sender, EventArgs e)
        {
            BMB.Position += 1;
            LbPos.Text = (BMB.Position + 1) + " / " + BMB.Count;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                BMB.AddNew();
                btnNew.Enabled = false;
                btnAdd.Enabled = true;
                int ID = Convert.ToInt32(DT.Rows[DT.Rows.Count - 1][0]) + 1;
                txtID.Text = ID.ToString();
                txtDes.Focus();
            }
            catch
            {
                MessageBox.Show("حدث خطأ ما", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                BMB.EndCurrentEdit();
                CMDB = new SqlCommandBuilder(DA);
                DA.Update(DT);
                MessageBox.Show("تم الإضافة بنجاح", "عملية الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnAdd.Enabled = false;
                btnNew.Enabled = true;
                LbPos.Text = (BMB.Position + 1) + " / " + BMB.Count;
            }
            catch
            {
                MessageBox.Show("حدث خطأ ما", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                BMB.RemoveAt(BMB.Position);
                BMB.EndCurrentEdit();
                CMDB = new SqlCommandBuilder(DA);
                DA.Update(DT);
                MessageBox.Show("تم الحذف بنجاح", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LbPos.Text = (BMB.Position + 1) + " / " + BMB.Count;
            }
            catch
            {
                MessageBox.Show("حدث خطأ ما", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdt_Click(object sender, EventArgs e)
        {
            try
            {
                BMB.EndCurrentEdit();
                CMDB = new SqlCommandBuilder(DA);
                DA.Update(DT);
                MessageBox.Show("تم التعديل بنجاح", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LbPos.Text = (BMB.Position + 1) + " / " + BMB.Count;
            }
            catch
            {
                MessageBox.Show("حدث خطأ ما", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPA_Click(object sender, EventArgs e)
        {
            try
            {
                RPT.RPT_All_Categories RPT = new RPT.RPT_All_Categories();
                RPT.FRM_RPT_Medicine FRM = new RPT.FRM_RPT_Medicine();
                RPT.Refresh();
                FRM.crystalReportViewer1.ReportSource = RPT;
                FRM.ShowDialog();
            }
            catch
            {
                MessageBox.Show("حدث خطأ ما", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPMs_Click(object sender, EventArgs e)
        {
            try
            {
                RPT.RPT_Single_Category RPT = new RPT.RPT_Single_Category();
                RPT.FRM_RPT_Medicine FRM = new RPT.FRM_RPT_Medicine();
                RPT.SetParameterValue("@ID", txtID.Text);
                FRM.crystalReportViewer1.ReportSource = RPT;
                FRM.ShowDialog();
            }
            catch
            {
                MessageBox.Show("حدث خطأ ما", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExPDF_Click(object sender, EventArgs e)
        {
            try
            {
                RPT.RPT_All_Categories RPT = new RPT.RPT_All_Categories();

                //Create export options
                ExportOptions EXO = new ExportOptions();

                //PDF Format Options object
                PdfFormatOptions PDFFormat = new PdfFormatOptions();

                //Create object for destination
                DiskFileDestinationOptions DFDO = new DiskFileDestinationOptions();

                //Set the path of destination
                DFDO.DiskFileName = @"D:\CategoriesList.pdf";

                //Options
                EXO = RPT.ExportOptions;
                //
                EXO.ExportDestinationType = ExportDestinationType.DiskFile;
                //
                EXO.ExportFormatType = ExportFormatType.PortableDocFormat;
                //
                EXO.ExportFormatOptions = PDFFormat;
                //
                EXO.ExportDestinationOptions = DFDO;

                //Refresh
                RPT.Refresh();

                //Export
                RPT.Export();

                //Show message
                MessageBox.Show("تم تصدير اللائحة بنجاح", "عملية التصدير", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("حدث خطأ ما", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExPDFMed_Click(object sender, EventArgs e)
        {
            try
            {
                RPT.RPT_Single_Category RPT = new RPT.RPT_Single_Category();

                //Create export options
                ExportOptions EXO = new ExportOptions();

                //PDF Format Options object
                PdfFormatOptions PDFFormat = new PdfFormatOptions();

                //Create object for destination
                DiskFileDestinationOptions DFDO = new DiskFileDestinationOptions();

                //Set the path of destination
                DFDO.DiskFileName = @"D:\CategoryDetails.pdf";

                //Options
                EXO = RPT.ExportOptions;
                //
                EXO.ExportDestinationType = ExportDestinationType.DiskFile;
                //
                EXO.ExportFormatType = ExportFormatType.PortableDocFormat;
                //
                EXO.ExportFormatOptions = PDFFormat;
                //
                EXO.ExportDestinationOptions = DFDO;

                //Refresh
                RPT.Refresh();

                //Get parameter
                RPT.SetParameterValue("@ID", txtID.Text);

                //Export
                RPT.Export();

                //Show message
                MessageBox.Show("تم تصدير اللائحة بنجاح", "عملية التصدير", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("حدث خطأ ما", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
