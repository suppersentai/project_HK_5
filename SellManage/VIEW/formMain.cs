using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;

namespace VIEW
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
       
        }

        private void formMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult di = MessageBox.Show("Bạn Chắc Chắc Muốn thoát Không", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (di == DialogResult.Cancel){
                 e.Cancel = true;
            }
            else
            {
                 Environment.Exit(1);
               // Application.Exit();
            }
       
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            new LOGIN().Visible = true; this.Visible = false;
        }

        private void formMain_Load(object sender, EventArgs e)
        {
            showInforDAO proDao = new showInforDAO();
            proDao.fillCombobox(sell_cbType, sell_cbSize, sell_cbColor, sell_cbPrice);
            proDao.showDataGrid(sell_dataGrid);
        }
    }
}
