using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace VIEW
{
    public partial class test : Form
    {
        public test()
        {
            InitializeComponent();
        }

        private void test_Load(object sender, EventArgs e)
        {

            timer1.Start();
        
        }
        public void runTime()
        {
              
             
                //Thread.Sleep(950); MessageBox.Show(h + "---" + p + "--" + s);

             
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            System.Timers.Timer t = sender as System.Timers.Timer;
         
            string h = DateTime.Now.TimeOfDay.Hours.ToString();
                string p = DateTime.Now.TimeOfDay.Minutes.ToString();
                string s = DateTime.Now.TimeOfDay.Seconds.ToString(); 
                lbTimeNow.Text = h + " : " + p + " : " + s;
            
        }
    }
}
