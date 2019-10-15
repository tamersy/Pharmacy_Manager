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

namespace Pharmacy_Manager.PL
{
    public partial class FRM_Add_M : Form
    {
        //Var of state
        public string state = "add";

        //CLS_Medicines object
        BL.CLS_Medicines med = new BL.CLS_Medicines();

        public FRM_Add_M()
        {
            InitializeComponent();
            comboBox1.DataSource = med.Get_All_Categories();
            comboBox1.DisplayMember = "Des_Cate";
            comboBox1.ValueMember = "ID_Cate";
            txtID.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Open an image
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Filter = "ملفات الصور | *.JPG; *.PNG; *.GIF; *.BMP";
            if(OFD.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(OFD.FileName);
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
                if (state == "add")
                {
                    //MemoryStream object
                    MemoryStream MS = new MemoryStream();

                    //Save Image
                    pictureBox1.Image.Save(MS, pictureBox1.Image.RawFormat);

                    //Array of binary data
                    byte[] BinIMG = MS.ToArray();

                    //Give Add_Medicine method the parameters
                    med.Add_Medicine(txtID.Text, txtName.Text, Convert.ToInt32(txtQ.Text), txtP.Text, BinIMG, Convert.ToString(comboBox1.SelectedValue));

                    //Show message
                    MessageBox.Show("تمت الإضافة بنجاح", "الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Close Window
                    this.Close();
                }
                else
                {
                    //MemoryStream object
                    MemoryStream MS = new MemoryStream();

                    //Save Image
                    pictureBox1.Image.Save(MS, pictureBox1.Image.RawFormat);

                    //Array of binary data
                    byte[] BinIMG = MS.ToArray();

                    //Give Update_Medicine method the parameters
                    med.Update_Medicine(txtID.Text, txtName.Text, Convert.ToInt32(txtQ.Text), txtP.Text, BinIMG, Convert.ToString(comboBox1.SelectedValue));

                    //Show message
                    MessageBox.Show("تم التعديل بنجاح", "التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Close Window
                    this.Close();
                }
                //Update DataGridView
                FRM_Medicines.getMedicinesForm.dataGridView1.DataSource = med.Get_All_Medicines();
            }
            catch
            {
                MessageBox.Show("حدث خطأ ما", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtID_Validated(object sender, EventArgs e)
        {
            try
            {
                if (state == "add")
                {
                    //Data_Table object
                    DataTable DT = new DataTable();
                    DT = med.VerifyMedicineID(txtID.Text);

                    if (DT.Rows.Count > 0)
                    {
                        MessageBox.Show("هذا المعرف موجود مسبقاً", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtID.Focus();
                        txtID.SelectionStart = 0;
                        txtID.SelectionLength = txtID.TextLength;
                    }
                }
            }
            catch
            {
                MessageBox.Show("حدث خطأ ما", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txtName.Focus();
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txtQ.Focus();
            }
        }

        private void txtQ_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txtP.Focus();
            }
        }
    }
}
