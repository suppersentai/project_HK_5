using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace manageSell
{
    public partial class main : Form
    {
        sellForm sForm;
        manageForm mForm;
        warehouseForm wForm;

        private void button1_Click(object sender, EventArgs e)
        {
            sForm = new sellForm();
            sForm.Visible = true;
            mForm.Visible = false;
            wForm.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
             wForm = new warehouseForm();

        }
        public main()
        {
            InitializeComponent();
        }
    }
}
