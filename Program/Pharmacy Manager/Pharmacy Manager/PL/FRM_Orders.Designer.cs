namespace Pharmacy_Manager.PL
{
    partial class FRM_Orders
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Orders));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DTP = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CustEmail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CustPhone = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CustLastName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CustName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.CustID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.txtFPMed = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtQMed = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtPMed = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtNameMed = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtIDMed = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSum = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.تعديلToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.حذفالسطرالحاليToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.حذفالكلToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtUser);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.DTP);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtDes);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 192);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات الفاتورة";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtUser
            // 
            this.txtUser.Enabled = false;
            this.txtUser.Location = new System.Drawing.Point(10, 160);
            this.txtUser.Name = "txtUser";
            this.txtUser.ReadOnly = true;
            this.txtUser.Size = new System.Drawing.Size(206, 24);
            this.txtUser.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(224, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "اسم المستخدم :";
            // 
            // DTP
            // 
            this.DTP.Location = new System.Drawing.Point(10, 130);
            this.DTP.Name = "DTP";
            this.DTP.Size = new System.Drawing.Size(206, 24);
            this.DTP.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(224, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "تاريخ البيع :";
            // 
            // txtDes
            // 
            this.txtDes.Location = new System.Drawing.Point(10, 61);
            this.txtDes.Multiline = true;
            this.txtDes.Name = "txtDes";
            this.txtDes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDes.Size = new System.Drawing.Size(206, 63);
            this.txtDes.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "وصف الفاتورة :";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(10, 31);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(206, 24);
            this.txtID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(224, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "رقم الفاتورة :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CustEmail);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.CustPhone);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.CustLastName);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.CustName);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.CustID);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupBox2.Location = new System.Drawing.Point(363, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(521, 192);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "بيانات العميل";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // CustEmail
            // 
            this.CustEmail.Enabled = false;
            this.CustEmail.Location = new System.Drawing.Point(7, 151);
            this.CustEmail.Name = "CustEmail";
            this.CustEmail.ReadOnly = true;
            this.CustEmail.Size = new System.Drawing.Size(393, 24);
            this.CustEmail.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(406, 154);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 17);
            this.label9.TabIndex = 11;
            this.label9.Text = "البريد الالكتروني :";
            // 
            // CustPhone
            // 
            this.CustPhone.Enabled = false;
            this.CustPhone.Location = new System.Drawing.Point(7, 121);
            this.CustPhone.Name = "CustPhone";
            this.CustPhone.ReadOnly = true;
            this.CustPhone.Size = new System.Drawing.Size(393, 24);
            this.CustPhone.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(406, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "الهاتف :";
            // 
            // CustLastName
            // 
            this.CustLastName.Enabled = false;
            this.CustLastName.Location = new System.Drawing.Point(7, 91);
            this.CustLastName.Name = "CustLastName";
            this.CustLastName.ReadOnly = true;
            this.CustLastName.Size = new System.Drawing.Size(393, 24);
            this.CustLastName.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(406, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "اسم العائلة :";
            // 
            // CustName
            // 
            this.CustName.Enabled = false;
            this.CustName.Location = new System.Drawing.Point(7, 61);
            this.CustName.Name = "CustName";
            this.CustName.ReadOnly = true;
            this.CustName.Size = new System.Drawing.Size(393, 24);
            this.CustName.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(406, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "الاسم :";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(7, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CustID
            // 
            this.CustID.Enabled = false;
            this.CustID.Location = new System.Drawing.Point(88, 31);
            this.CustID.Name = "CustID";
            this.CustID.ReadOnly = true;
            this.CustID.Size = new System.Drawing.Size(312, 24);
            this.CustID.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(406, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "معرف العميل :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.txtFPMed);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.txtQMed);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.txtPMed);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.txtNameMed);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txtIDMed);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtSum);
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupBox3.Location = new System.Drawing.Point(12, 226);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(872, 270);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "الأدوية";
            // 
            // button6
            // 
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(795, 40);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(69, 25);
            this.button6.TabIndex = 15;
            this.button6.Text = "...";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label17
            // 
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label17.Location = new System.Drawing.Point(795, 20);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(68, 20);
            this.label17.TabIndex = 14;
            this.label17.Text = "اختيار";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtFPMed
            // 
            this.txtFPMed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFPMed.Enabled = false;
            this.txtFPMed.Location = new System.Drawing.Point(7, 40);
            this.txtFPMed.Name = "txtFPMed";
            this.txtFPMed.ReadOnly = true;
            this.txtFPMed.Size = new System.Drawing.Size(152, 24);
            this.txtFPMed.TabIndex = 13;
            // 
            // label16
            // 
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label16.Location = new System.Drawing.Point(7, 20);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(152, 20);
            this.label16.TabIndex = 12;
            this.label16.Text = "المبلغ";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtQMed
            // 
            this.txtQMed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQMed.Location = new System.Drawing.Point(159, 40);
            this.txtQMed.MaxLength = 8;
            this.txtQMed.Name = "txtQMed";
            this.txtQMed.Size = new System.Drawing.Size(150, 24);
            this.txtQMed.TabIndex = 11;
            this.txtQMed.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQMed_KeyDown);
            this.txtQMed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQMed_KeyPress);
            this.txtQMed.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtQMed_KeyUp);
            // 
            // label15
            // 
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label15.Location = new System.Drawing.Point(159, 20);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(150, 20);
            this.label15.TabIndex = 10;
            this.label15.Text = "الكمية";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPMed
            // 
            this.txtPMed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPMed.Location = new System.Drawing.Point(309, 40);
            this.txtPMed.MaxLength = 8;
            this.txtPMed.Name = "txtPMed";
            this.txtPMed.Size = new System.Drawing.Size(150, 24);
            this.txtPMed.TabIndex = 9;
            this.txtPMed.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPMed_KeyDown);
            this.txtPMed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPMed_KeyPress);
            this.txtPMed.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPMed_KeyUp);
            // 
            // label14
            // 
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label14.Location = new System.Drawing.Point(309, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(150, 20);
            this.label14.TabIndex = 8;
            this.label14.Text = "الثمن";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNameMed
            // 
            this.txtNameMed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNameMed.Enabled = false;
            this.txtNameMed.Location = new System.Drawing.Point(459, 40);
            this.txtNameMed.Name = "txtNameMed";
            this.txtNameMed.ReadOnly = true;
            this.txtNameMed.Size = new System.Drawing.Size(186, 24);
            this.txtNameMed.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Location = new System.Drawing.Point(459, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(186, 20);
            this.label13.TabIndex = 6;
            this.label13.Text = "اسم الدواء";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtIDMed
            // 
            this.txtIDMed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIDMed.Enabled = false;
            this.txtIDMed.Location = new System.Drawing.Point(645, 40);
            this.txtIDMed.Name = "txtIDMed";
            this.txtIDMed.ReadOnly = true;
            this.txtIDMed.Size = new System.Drawing.Size(150, 24);
            this.txtIDMed.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Location = new System.Drawing.Point(645, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(150, 20);
            this.label12.TabIndex = 4;
            this.label12.Text = "معرف الدواء";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(165, 234);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 17);
            this.label10.TabIndex = 3;
            this.label10.Text = "المجموع :";
            // 
            // txtSum
            // 
            this.txtSum.Enabled = false;
            this.txtSum.Location = new System.Drawing.Point(7, 231);
            this.txtSum.Name = "txtSum";
            this.txtSum.ReadOnly = true;
            this.txtSum.Size = new System.Drawing.Size(152, 24);
            this.txtSum.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(7, 73);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(856, 141);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridView1_RowsRemoved);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.تعديلToolStripMenuItem,
            this.toolStripSeparator1,
            this.حذفالسطرالحاليToolStripMenuItem,
            this.حذفالكلToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(169, 76);
            // 
            // تعديلToolStripMenuItem
            // 
            this.تعديلToolStripMenuItem.Name = "تعديلToolStripMenuItem";
            this.تعديلToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.تعديلToolStripMenuItem.Text = "تعديل";
            this.تعديلToolStripMenuItem.Click += new System.EventHandler(this.تعديلToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(165, 6);
            // 
            // حذفالسطرالحاليToolStripMenuItem
            // 
            this.حذفالسطرالحاليToolStripMenuItem.Name = "حذفالسطرالحاليToolStripMenuItem";
            this.حذفالسطرالحاليToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.حذفالسطرالحاليToolStripMenuItem.Text = "حذف السطر الحالي";
            this.حذفالسطرالحاليToolStripMenuItem.Click += new System.EventHandler(this.حذفالسطرالحاليToolStripMenuItem_Click);
            // 
            // حذفالكلToolStripMenuItem
            // 
            this.حذفالكلToolStripMenuItem.Name = "حذفالكلToolStripMenuItem";
            this.حذفالكلToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.حذفالكلToolStripMenuItem.Text = "حذف الكل";
            this.حذفالكلToolStripMenuItem.Click += new System.EventHandler(this.حذفالكلToolStripMenuItem_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.button3.ForeColor = System.Drawing.Color.Lime;
            this.button3.Location = new System.Drawing.Point(259, 526);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 38);
            this.button3.TabIndex = 3;
            this.button3.Text = "فاتورة جديدة";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Tahoma", 10F);
            this.button4.ForeColor = System.Drawing.Color.Blue;
            this.button4.Location = new System.Drawing.Point(387, 526);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(122, 38);
            this.button4.TabIndex = 4;
            this.button4.Text = "حفظ الفاتورة";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Enabled = false;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Tahoma", 10F);
            this.button5.ForeColor = System.Drawing.Color.Aqua;
            this.button5.Location = new System.Drawing.Point(515, 526);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(122, 38);
            this.button5.TabIndex = 5;
            this.button5.Text = "طباعة الفاتورة";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label11.Location = new System.Drawing.Point(862, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(22, 24);
            this.label11.TabIndex = 6;
            this.label11.Text = "X";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            this.label11.MouseEnter += new System.EventHandler(this.label11_MouseEnter);
            this.label11.MouseLeave += new System.EventHandler(this.label11_MouseLeave);
            // 
            // FRM_Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(896, 576);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_Orders";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "عملية بيع الدواء";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DTP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox CustEmail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox CustPhone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox CustLastName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox CustName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox CustID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSum;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPMed;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtNameMed;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtIDMed;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtFPMed;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtQMed;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem تعديلToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem حذفالسطرالحاليToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem حذفالكلToolStripMenuItem;
    }
}