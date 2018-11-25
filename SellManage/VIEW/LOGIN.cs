using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controller;
namespace VIEW
{
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            loginProcess log = new loginProcess();
            if (log.checkInvalid(log_txtUser.Text, log_txtPas.Text))
            {
                if (log.checkExistAccount(log_txtUser.Text, log_txtPas.Text))
                {
                       new formMain().Visible=true;
                     this.Visible = false;

                }
                else
                {
                    MessageBox.Show("không tồng tai", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu", "Thông Báo", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void LOGIN_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Environment.Exit(1);
            Application.Exit();
        }
    }
}
