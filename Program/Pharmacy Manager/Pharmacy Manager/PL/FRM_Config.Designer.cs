namespace Pharmacy_Manager.PL
{
    partial class FRM_Config
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Config));
            this.label1 = new System.Windows.Forms.Label();
            this.txtServerName = new System.Windows.Forms.TextBox();
            this.txtDataBase = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RBwin = new System.Windows.Forms.RadioButton();
            this.RBsql = new System.Windows.Forms.RadioButton();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BTNsave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "اسم السيرفر :";
            // 
            // txtServerName
            // 
            this.txtServerName.Location = new System.Drawing.Point(145, 37);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Size = new System.Drawing.Size(338, 27);
            this.txtServerName.TabIndex = 1;
            // 
            // txtDataBase
            // 
            this.txtDataBase.Location = new System.Drawing.Point(145, 70);
            this.txtDataBase.Name = "txtDataBase";
            this.txtDataBase.Size = new System.Drawing.Size(338, 27);
            this.txtDataBase.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "قاعدة البيانات :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "طريقة الدخول :";
            // 
            // RBwin
            // 
            this.RBwin.AutoSize = true;
            this.RBwin.Checked = true;
            this.RBwin.Location = new System.Drawing.Point(145, 104);
            this.RBwin.Name = "RBwin";
            this.RBwin.Size = new System.Drawing.Size(198, 23);
            this.RBwin.TabIndex = 5;
            this.RBwin.TabStop = true;
            this.RBwin.Text = "Windows Authentication";
            this.RBwin.UseVisualStyleBackColor = true;
            this.RBwin.CheckedChanged += new System.EventHandler(this.RBwin_CheckedChanged);
            // 
            // RBsql
            // 
            this.RBsql.AutoSize = true;
            this.RBsql.Location = new System.Drawing.Point(145, 133);
            this.RBsql.Name = "RBsql";
            this.RBsql.Size = new System.Drawing.Size(213, 23);
            this.RBsql.TabIndex = 6;
            this.RBsql.Text = "SQL Server Authentication";
            this.RBsql.UseVisualStyleBackColor = true;
            this.RBsql.CheckedChanged += new System.EventHandler(this.RBsql_CheckedChanged);
            // 
            // txtPassWord
            // 
            this.txtPassWord.Enabled = false;
            this.txtPassWord.Location = new System.Drawing.Point(145, 195);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.PasswordChar = '*';
            this.txtPassWord.ReadOnly = true;
            this.txtPassWord.Size = new System.Drawing.Size(338, 27);
            this.txtPassWord.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "كلمة المرور :";
            // 
            // txtUserName
            // 
            this.txtUserName.Enabled = false;
            this.txtUserName.Location = new System.Drawing.Point(145, 162);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.ReadOnly = true;
            this.txtUserName.Size = new System.Drawing.Size(338, 27);
            this.txtUserName.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "اسم المستخدم :";
            // 
            // BTNsave
            // 
            this.BTNsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNsave.ForeColor = System.Drawing.Color.Lime;
            this.BTNsave.Location = new System.Drawing.Point(177, 268);
            this.BTNsave.Name = "BTNsave";
            this.BTNsave.Size = new System.Drawing.Size(141, 36);
            this.BTNsave.TabIndex = 11;
            this.BTNsave.Text = "حفظ الإعدادات";
            this.BTNsave.UseVisualStyleBackColor = true;
            this.BTNsave.Click += new System.EventHandler(this.BTNsave_Click);
            // 
            // FRM_Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(495, 316);
            this.Controls.Add(this.BTNsave);
            this.Controls.Add(this.txtPassWord);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.RBsql);
            this.Controls.Add(this.RBwin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDataBase);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtServerName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_Config";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "التحكم في إعدادات الاتصال بالسيرفر";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtServerName;
        private System.Windows.Forms.TextBox txtDataBase;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton RBwin;
        private System.Windows.Forms.RadioButton RBsql;
        private System.Windows.Forms.TextBox txtPassWord;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BTNsave;
    }
}