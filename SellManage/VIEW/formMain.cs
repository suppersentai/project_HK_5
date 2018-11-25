﻿using System;
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
            sell_dataGrid.DataSource = Controller.showInforProcesss.getListProductProsess();

            //đặt header
            sell_dataGrid.Columns["id"].HeaderText = "Mã";     
            sell_dataGrid.Columns["name"].HeaderText = "Tên sản phẩm";
            sell_dataGrid.Columns["type"].HeaderText = "Loại";
            sell_dataGrid.Columns["size"].HeaderText = "Size";
            sell_dataGrid.Columns["color"].HeaderText = "Màu sắc";
            sell_dataGrid.Columns["outPrice"].HeaderText = "Giá Bán";
            sell_dataGrid.Columns["note"].HeaderText = "note";
            //đặt kích thước width 
            sell_dataGrid.Columns["id"].Width = 60;
            sell_dataGrid.Columns["size"].Width = 60;

     
            Controller.showInforProcesss.showTypeOnCombox(sell_cbType);
            
            Controller.showInforProcesss.showSizeOnCombox(sell_cbSize);
 
            Controller.showInforProcesss.showColorOnCombox(sell_cbColor);




        }
    }
}
