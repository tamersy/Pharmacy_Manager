namespace Pharmacy_Manager.PL
{
    partial class FRM_Categories
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Categories));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LbPos = new System.Windows.Forms.Label();
            this.btnNex = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnPre = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.txtDes = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnExPDFMed = new System.Windows.Forms.Button();
            this.btnExPDF = new System.Windows.Forms.Button();
            this.btnPMs = new System.Windows.Forms.Button();
            this.btnPA = new System.Windows.Forms.Button();
            this.btnEdt = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LbPos);
            this.groupBox1.Controls.Add(this.btnNex);
            this.groupBox1.Controls.Add(this.btnLast);
            this.groupBox1.Controls.Add(this.btnPre);
            this.groupBox1.Controls.Add(this.btnFirst);
            this.groupBox1.Controls.Add(this.txtDes);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupBox1.Location = new System.Drawing.Point(12, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(963, 165);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات الصنف";
            // 
            // LbPos
            // 
            this.LbPos.AutoSize = true;
            this.LbPos.Location = new System.Drawing.Point(460, 139);
            this.LbPos.Name = "LbPos";
            this.LbPos.Size = new System.Drawing.Size(42, 17);
            this.LbPos.TabIndex = 8;
            this.LbPos.Text = "label3";
            // 
            // btnNex
            // 
            this.btnNex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNex.ForeColor = System.Drawing.Color.Blue;
            this.btnNex.Location = new System.Drawing.Point(374, 136);
            this.btnNex.Name = "btnNex";
            this.btnNex.Size = new System.Drawing.Size(75, 23);
            this.btnNex.TabIndex = 7;
            this.btnNex.Text = ">>";
            this.btnNex.UseVisualStyleBackColor = true;
            this.btnNex.Click += new System.EventHandler(this.btnNex_Click);
            // 
            // btnLast
            // 
            this.btnLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLast.ForeColor = System.Drawing.Color.Blue;
            this.btnLast.Location = new System.Drawing.Point(293, 136);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(75, 23);
            this.btnLast.TabIndex = 6;
            this.btnLast.Text = ">>||";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnPre
            // 
            this.btnPre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPre.ForeColor = System.Drawing.Color.Blue;
            this.btnPre.Location = new System.Drawing.Point(513, 136);
            this.btnPre.Name = "btnPre";
            this.btnPre.Size = new System.Drawing.Size(75, 23);
            this.btnPre.TabIndex = 5;
            this.btnPre.Text = "<<";
            this.btnPre.UseVisualStyleBackColor = true;
            this.btnPre.Click += new System.EventHandler(this.btnPre_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirst.ForeColor = System.Drawing.Color.Blue;
            this.btnFirst.Location = new System.Drawing.Point(594, 136);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(75, 23);
            this.btnFirst.TabIndex = 4;
            this.btnFirst.Text = "||<<";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // txtDes
            // 
            this.txtDes.Location = new System.Drawing.Point(292, 69);
            this.txtDes.Name = "txtDes";
            this.txtDes.Size = new System.Drawing.Size(288, 24);
            this.txtDes.TabIndex = 3;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(292, 30);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(288, 24);
            this.txtID.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(586, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "اسم الصنف:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(586, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "معرف الصنف:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnExPDFMed);
            this.groupBox2.Controls.Add(this.btnExPDF);
            this.groupBox2.Controls.Add(this.btnPMs);
            this.groupBox2.Controls.Add(this.btnPA);
            this.groupBox2.Controls.Add(this.btnEdt);
            this.groupBox2.Controls.Add(this.btnDel);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.btnNew);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 196);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(963, 68);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "العمليات المتاحة";
            // 
            // btnExPDFMed
            // 
            this.btnExPDFMed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExPDFMed.ForeColor = System.Drawing.Color.Maroon;
            this.btnExPDFMed.Location = new System.Drawing.Point(12, 22);
            this.btnExPDFMed.Name = "btnExPDFMed";
            this.btnExPDFMed.Size = new System.Drawing.Size(112, 40);
            this.btnExPDFMed.TabIndex = 14;
            this.btnExPDFMed.Text = "تصدير مع الأدوية";
            this.btnExPDFMed.UseVisualStyleBackColor = true;
            this.btnExPDFMed.Click += new System.EventHandler(this.btnExPDFMed_Click);
            // 
            // btnExPDF
            // 
            this.btnExPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExPDF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExPDF.Location = new System.Drawing.Point(130, 22);
            this.btnExPDF.Name = "btnExPDF";
            this.btnExPDF.Size = new System.Drawing.Size(112, 40);
            this.btnExPDF.TabIndex = 13;
            this.btnExPDF.Text = "تصدير PDF";
            this.btnExPDF.UseVisualStyleBackColor = true;
            this.btnExPDF.Click += new System.EventHandler(this.btnExPDF_Click);
            // 
            // btnPMs
            // 
            this.btnPMs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPMs.ForeColor = System.Drawing.Color.SpringGreen;
            this.btnPMs.Location = new System.Drawing.Point(248, 22);
            this.btnPMs.Name = "btnPMs";
            this.btnPMs.Size = new System.Drawing.Size(112, 40);
            this.btnPMs.TabIndex = 12;
            this.btnPMs.Text = "طباعة مع الأدوية";
            this.btnPMs.UseVisualStyleBackColor = true;
            this.btnPMs.Click += new System.EventHandler(this.btnPMs_Click);
            // 
            // btnPA
            // 
            this.btnPA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPA.ForeColor = System.Drawing.Color.Aqua;
            this.btnPA.Location = new System.Drawing.Point(366, 22);
            this.btnPA.Name = "btnPA";
            this.btnPA.Size = new System.Drawing.Size(112, 40);
            this.btnPA.TabIndex = 11;
            this.btnPA.Text = "طباعة الكل";
            this.btnPA.UseVisualStyleBackColor = true;
            this.btnPA.Click += new System.EventHandler(this.btnPA_Click);
            // 
            // btnEdt
            // 
            this.btnEdt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdt.ForeColor = System.Drawing.Color.Lime;
            this.btnEdt.Location = new System.Drawing.Point(484, 22);
            this.btnEdt.Name = "btnEdt";
            this.btnEdt.Size = new System.Drawing.Size(112, 40);
            this.btnEdt.TabIndex = 10;
            this.btnEdt.Text = "تعديل";
            this.btnEdt.UseVisualStyleBackColor = true;
            this.btnEdt.Click += new System.EventHandler(this.btnEdt_Click);
            // 
            // btnDel
            // 
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.ForeColor = System.Drawing.Color.Red;
            this.btnDel.Location = new System.Drawing.Point(602, 22);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(112, 40);
            this.btnDel.TabIndex = 9;
            this.btnDel.Text = "حذف";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.Blue;
            this.btnAdd.Location = new System.Drawing.Point(720, 22);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 40);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "إضافة";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnNew
            // 
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.ForeColor = System.Drawing.Color.Green;
            this.btnNew.Location = new System.Drawing.Point(838, 22);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(112, 40);
            this.btnNew.TabIndex = 7;
            this.btnNew.Text = "جديد";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupBox3.Location = new System.Drawing.Point(12, 270);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(963, 265);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "قائمة الأصناف";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(951, 236);
            this.dataGridView1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label3.Location = new System.Drawing.Point(953, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            this.label3.MouseEnter += new System.EventHandler(this.label3_MouseEnter);
            this.label3.MouseLeave += new System.EventHandler(this.label3_MouseLeave);
            // 
            // FRM_Categories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(987, 547);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_Categories";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إدارة الأصناف";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LbPos;
        private System.Windows.Forms.Button btnNex;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnPre;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.TextBox txtDes;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEdt;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnExPDFMed;
        private System.Windows.Forms.Button btnExPDF;
        private System.Windows.Forms.Button btnPMs;
        private System.Windows.Forms.Button btnPA;
    }
}