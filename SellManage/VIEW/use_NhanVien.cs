using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controller;
using MODEL;
using Controller.NhanVien;

namespace VIEW
{
    public partial class use_NhanVien : UserControl
    {
        public use_NhanVien()
        {
            InitializeComponent();
        }

        private void use_NhanVien_Load(object sender, EventArgs e)
        {
            loadUserNhanVien();
        }
        private void loadUserNhanVien()
        {
            accountProcess nvProcess = new accountProcess();
            nvProcess.getAllStaff(nv_dgvNV);
        }
    }
}
