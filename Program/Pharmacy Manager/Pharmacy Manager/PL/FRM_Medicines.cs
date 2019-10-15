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
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.CrystalReports;
using CrystalDecisions.Shared;

namespace Pharmacy_Manager.PL
{
    public partial class FRM_Medicines : Form
    {
        //Single Instance
        public static FRM_Medicines Frm;
        //
        static void Frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Frm = null;
        }
        //
        public static FRM_Medicines getMedicinesForm
        {
            get
            {
                if (Frm == null)
                {
                    Frm = new FRM_Medicines();
                    Frm.FormClosed += new FormClosedEventHandler(Frm_FormClosed);
                }
                return Frm;
            }
        }

        //CLS_Medicines object
        BL.CLS_Medicines med = new BL.CLS_Medicines();

        public FRM_Medicines()
        {
            InitializeComponent();
            if(Frm == null)
            {
                Frm = this;
            }

            this.dataGridView1.DataSource = med.Get_All_Medicines();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //DataTable object
            DataTable DT = new DataTable();

            //Give datatable object a value
            DT = med.SearchMedicines(txtSearch.Text);

            //View search results in datagridview
            this.dataGridView1.DataSource = DT;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FRM_Add_M FRM = new FRM_Add_M();
            FRM.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("هل أنت متأكد من أنك تريد الحذف ؟", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    med.DeleteMedicines(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    MessageBox.Show("تم الحذف بنجاح", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.dataGridView1.DataSource = med.Get_All_Medicines();
                }
                else
                {
                    MessageBox.Show("تم إلغاء الحذف بنجاح", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
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
                FRM_Add_M FRM = new FRM_Add_M();
                FRM.txtID.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                FRM.txtName.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                FRM.txtQ.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                FRM.txtP.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                FRM.comboBox1.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
                FRM.Text = "تحديث بيانات الدواء : " + this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                FRM.button2.Text = "تحديث";
                FRM.state = "update";
                FRM.txtID.ReadOnly = true;
                FRM.txtID.Enabled = false;
                byte[] image = (byte[])med.Get_Image_Medicine(this.dataGridView1.CurrentRow.Cells[0].Value.ToString()).Rows[0][0];
                MemoryStream MS = new MemoryStream(image);
                FRM.pictureBox1.Image = Image.FromStream(MS);
                FRM.ShowDialog();
            }
            catch
            {
                MessageBox.Show("حدث خطأ ما", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Red;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Black;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                FRM_Preview FRM = new FRM_Preview();
                byte[] image = (byte[])med.Get_Image_Medicine(this.dataGridView1.CurrentRow.Cells[0].Value.ToString()).Rows[0][0];
                MemoryStream MS = new MemoryStream(image);
                FRM.pictureBox1.Image = Image.FromStream(MS);
                FRM.ShowDialog();
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
                //Print single medicine
                RPT.RPT_Med_Single MedReport = new RPT.RPT_Med_Single();
                //
                MedReport.SetParameterValue("@ID", this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
                //
                RPT.FRM_RPT_Medicine FRM = new RPT.FRM_RPT_Medicine();
                //
                FRM.crystalReportViewer1.ReportSource = MedReport;
                //
                FRM.ShowDialog();
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
                //Print all medicine
                RPT.RPT_Medicines MedsReport = new RPT.RPT_Medicines();
                //
                RPT.FRM_RPT_Medicine FRM = new RPT.FRM_RPT_Medicine();
                //
                FRM.crystalReportViewer1.ReportSource = MedsReport;
                //
                FRM.ShowDialog();
            }
            catch
            {
                MessageBox.Show("حدث خطأ ما", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                RPT.RPT_All_Medicines MedsReport = new RPT.RPT_All_Medicines();

                //Create export options
                ExportOptions EXO = new ExportOptions();

                //Excel Format Options object
                ExcelFormatOptions ExcelFormat = new ExcelFormatOptions();

                //Create object for destination
                DiskFileDestinationOptions DFDO = new DiskFileDestinationOptions();

                //Set the path of destination
                DFDO.DiskFileName = @"D:\MedicineList.xls";

                //Options
                EXO = MedsReport.ExportOptions;
                //
                EXO.ExportDestinationType = ExportDestinationType.DiskFile;
                //
                EXO.ExportFormatType = ExportFormatType.Excel;
                //
                EXO.ExportFormatOptions = ExcelFormat;
                //
                EXO.ExportDestinationOptions = DFDO;

                //Export
                MedsReport.Export();

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
