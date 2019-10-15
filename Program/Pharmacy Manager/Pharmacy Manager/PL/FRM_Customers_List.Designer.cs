namespace Pharmacy_Manager.PL
{
    partial class FRM_Customers_List
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Customers_List));
            this.DGVcustomers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGVcustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVcustomers
            // 
            this.DGVcustomers.AllowUserToAddRows = false;
            this.DGVcustomers.AllowUserToDeleteRows = false;
            this.DGVcustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVcustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVcustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVcustomers.Location = new System.Drawing.Point(0, 0);
            this.DGVcustomers.MultiSelect = false;
            this.DGVcustomers.Name = "DGVcustomers";
            this.DGVcustomers.ReadOnly = true;
            this.DGVcustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVcustomers.Size = new System.Drawing.Size(750, 492);
            this.DGVcustomers.TabIndex = 0;
            this.DGVcustomers.DoubleClick += new System.EventHandler(this.DGVcustomers_DoubleClick);
            // 
            // FRM_Customers_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(750, 492);
            this.Controls.Add(this.DGVcustomers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_Customers_List";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "اختيار عميل";
            ((System.ComponentModel.ISupportInitialize)(this.DGVcustomers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView DGVcustomers;
    }
}