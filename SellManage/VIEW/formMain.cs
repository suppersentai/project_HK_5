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
            ConnectDAO c = new ConnectDAO();
            
            if (c.getConnect() != null)
            {
                MessageBox.Show("ok thah con", "thong bao");
            }
            else
            {
                MessageBox.Show("ok tach", "thong bao");
            }
        }
    }
}
