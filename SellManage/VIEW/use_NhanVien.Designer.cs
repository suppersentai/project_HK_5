namespace VIEW
{
    partial class use_NhanVien
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nv_dgvNV = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.nv_dgvNV)).BeginInit();
            this.SuspendLayout();
            // 
            // nv_dgvNV
            // 
            this.nv_dgvNV.AllowUserToAddRows = false;
            this.nv_dgvNV.AllowUserToResizeRows = false;
            this.nv_dgvNV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nv_dgvNV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.nv_dgvNV.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.nv_dgvNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nv_dgvNV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nv_dgvNV.GridColor = System.Drawing.Color.MistyRose;
            this.nv_dgvNV.Location = new System.Drawing.Point(3, 3);
            this.nv_dgvNV.MultiSelect = false;
            this.nv_dgvNV.Name = "nv_dgvNV";
            this.nv_dgvNV.ShowEditingIcon = false;
            this.nv_dgvNV.Size = new System.Drawing.Size(701, 518);
            this.nv_dgvNV.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSalmon;
            this.panel1.Location = new System.Drawing.Point(723, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 498);
            this.panel1.TabIndex = 1;
            // 
            // use_NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.nv_dgvNV);
            this.Name = "use_NhanVien";
            this.Size = new System.Drawing.Size(984, 522);
            this.Load += new System.EventHandler(this.use_NhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nv_dgvNV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView nv_dgvNV;
        private System.Windows.Forms.Panel panel1;
    }
}
