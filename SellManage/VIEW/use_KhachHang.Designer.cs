namespace VIEW
{
    partial class use_KhachHang
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
            this.sell_dgvCustomer = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.sell_dgvCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // sell_dgvCustomer
            // 
            this.sell_dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sell_dgvCustomer.Location = new System.Drawing.Point(3, 3);
            this.sell_dgvCustomer.Name = "sell_dgvCustomer";
            this.sell_dgvCustomer.Size = new System.Drawing.Size(634, 519);
            this.sell_dgvCustomer.TabIndex = 0;
            // 
            // use_KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.Controls.Add(this.sell_dgvCustomer);
            this.Name = "use_KhachHang";
            this.Size = new System.Drawing.Size(984, 525);
            ((System.ComponentModel.ISupportInitialize)(this.sell_dgvCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView sell_dgvCustomer;
    }
}
