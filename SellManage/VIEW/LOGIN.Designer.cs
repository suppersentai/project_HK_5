namespace VIEW
{
    partial class LOGIN
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
            System.Windows.Forms.Panel panel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LOGIN));
            this.log_btnContact = new System.Windows.Forms.Button();
            this.log_btnLog = new System.Windows.Forms.Button();
            this.log_txtPas = new System.Windows.Forms.TextBox();
            this.log_txtUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = global::VIEW.Properties.Resources.images__3_;
            panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            panel1.Controls.Add(this.log_btnContact);
            panel1.Controls.Add(this.log_btnLog);
            panel1.Controls.Add(this.log_txtPas);
            panel1.Controls.Add(this.log_txtUser);
            panel1.Controls.Add(this.label2);
            panel1.Controls.Add(this.label1);
            panel1.Location = new System.Drawing.Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(347, 180);
            panel1.TabIndex = 0;
            // 
            // log_btnContact
            // 
            this.log_btnContact.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.log_btnContact.ForeColor = System.Drawing.Color.DarkOrange;
            this.log_btnContact.Location = new System.Drawing.Point(207, 96);
            this.log_btnContact.Name = "log_btnContact";
            this.log_btnContact.Size = new System.Drawing.Size(75, 23);
            this.log_btnContact.TabIndex = 4;
            this.log_btnContact.Text = "Liên Hệ";
            this.log_btnContact.UseVisualStyleBackColor = true;
            // 
            // log_btnLog
            // 
            this.log_btnLog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.log_btnLog.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.log_btnLog.ForeColor = System.Drawing.Color.DarkOrange;
            this.log_btnLog.Location = new System.Drawing.Point(130, 96);
            this.log_btnLog.Name = "log_btnLog";
            this.log_btnLog.Size = new System.Drawing.Size(71, 23);
            this.log_btnLog.TabIndex = 3;
            this.log_btnLog.Text = "Đăng Nhập";
            this.log_btnLog.UseVisualStyleBackColor = true;
            this.log_btnLog.Click += new System.EventHandler(this.button1_Click);
            // 
            // log_txtPas
            // 
            this.log_txtPas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.log_txtPas.Location = new System.Drawing.Point(124, 60);
            this.log_txtPas.MaxLength = 30;
            this.log_txtPas.Name = "log_txtPas";
            this.log_txtPas.PasswordChar = 'x';
            this.log_txtPas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.log_txtPas.Size = new System.Drawing.Size(171, 20);
            this.log_txtPas.TabIndex = 2;
            this.log_txtPas.Text = "gaotoan";
            // 
            // log_txtUser
            // 
            this.log_txtUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.log_txtUser.Location = new System.Drawing.Point(124, 21);
            this.log_txtUser.MaxLength = 30;
            this.log_txtUser.Name = "log_txtUser";
            this.log_txtUser.Size = new System.Drawing.Size(171, 20);
            this.log_txtUser.TabIndex = 1;
            this.log_txtUser.Text = "chungtoan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(44, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(44, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name";
            // 
            // LOGIN
            // 
            this.AcceptButton = this.log_btnLog;
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(343, 180);
            this.Controls.Add(panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(359, 219);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(359, 219);
            this.Name = "LOGIN";
            this.Text = "LOGIN";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LOGIN_FormClosing);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button log_btnContact;
        private System.Windows.Forms.Button log_btnLog;
        private System.Windows.Forms.TextBox log_txtPas;
        private System.Windows.Forms.TextBox log_txtUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}