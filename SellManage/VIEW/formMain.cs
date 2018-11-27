using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MODEL;


using Controller;

namespace VIEW
{
    public partial class formMain : Form
    {
        private  int showColo = 0;// dung show color khi lan dau load form
        List<product> listCurent;//List product ddang show tren data grid

        List<product> listProduct;//List product chua tat ca product from database
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
           
            listProduct = Controller.showInforProcesss.getListProductProsess();
        
            MessageBox.Show(listProduct.Count.ToString());
     
            sell_dataGrid.DataSource = listProduct;
           //đặt header
            sell_dataGrid.Columns["id"].HeaderText = "Mã";     
            sell_dataGrid.Columns["name"].HeaderText = "Tên sản phẩm";
            sell_dataGrid.Columns["tag"].HeaderText = "Loại";
            sell_dataGrid.Columns["size"].HeaderText = "Size";
            sell_dataGrid.Columns["color"].HeaderText = "Màu sắc";
            sell_dataGrid.Columns["outPrice"].HeaderText = "Giá Bán";
            sell_dataGrid.Columns["note"].HeaderText = "note";
            sell_dataGrid.Columns["type"].HeaderText = "Loại";

           // //đặt kích thước width 
           sell_dataGrid.Columns["id"].Width = 60;
          sell_dataGrid.Columns["size"].Width = 60;

           // // HIDE AN column idType in datagrid
            sell_dataGrid.Columns["type"].Visible = false;
             // // show infor on 4 combobox
          // Controller.showInforProcesss.showTypeOnCombox(sell_cbType);
           // Controller.showInforProcesss.showSizeOnCombox(sell_cbSize);
           // Controller.showInforProcesss.showColorOnCombox(sell_cbColor);
           //// sell_cbPrice.SelectedIndex = 0;

            //set selectted 
            

        }

        private void sell_cbType_SelectionChangeCommitted(object sender, EventArgs e)
        {//even khi thay doi gia gia trong combobox type

            //ComboBox com = sender as ComboBox;
         
            //if ((sell_cbSize.SelectedIndex ==0 && sell_cbColor.SelectedIndex == 0 && sell_cbPrice.SelectedIndex == -1) )
            //{
            ////     MessageBox.Show(com.SelectedValue.ToString());
            //    listCurent = new List<product>();
            //   // cach 1 dung vong for
            //  foreach (var item in listProduct)
            //    {
            //        if (item.Type.ToString() == com.SelectedValue.ToString())
            //            {
            //                listCurent.Add(item);
            //                 MessageBox.Show(item.Type.ToString() + "  ----  " + com.SelectedValue.ToString());
            //            }
            //        }
                
            //    //cach 2 dung dieu kien
            //    //      listCurent = listProduct.Where(id => id.Type.ToString() == com.SelectedValue.ToString()).ToList();
            //    sell_dataGrid.DataSource = listCurent;
            //}
            //else
            //{
            //    //Controller.showInforProcesss
            //  //  sell_dataGrid.DataSource = listCurent;
            //}
           
            
        }

        private void sell_cbSize_SelectedIndexChanged(object sender, EventArgs e)
        {
          //  ComboBox com = sender as ComboBox;

          //  updateDGridWhenChangeValueComboxSize();
        }

        public void updateDGridWhenChangeValueComboxSize( )
        {
            listCurent = new List<product>();
       

            //if ((sell_cbType.SelectedIndex ==0 && sell_cbColor.SelectedIndex == 0 && sell_cbPrice.SelectedIndex == -1)){
            //    foreach (product item in listProduct)
            //    {
            //        string a = item.Size.ToString();
            //        string b =sell_cbSize.SelectedValue.ToString();
                  

            //        bool chec = a.Equals(b);

            //        if (chec)
            //        {
            //            listCurent.Add(item);
            //        }

            //    }
            //      sell_dataGrid.DataSource = listCurent;

            //}
    
        }

        private void sell_cbColor_SelectedIndexChanged(object sender, EventArgs e)
        {
         
            //ComboBox com = sender as ComboBox;
            //sell_dataGrid.DataSource = listProduct;
            //updateDGridWhenChangeValueComboxColor();
           
        }
        public void updateDGridWhenChangeValueComboxColor()
        {
            //    showColo++;
            //    listCurent = new List<product>();
            //  if ((sell_cbType.SelectedIndex == 0 && sell_cbSize.SelectedIndex == 0 && sell_cbPrice.SelectedIndex == -1) && showColo >2)
            //    { 
            //        foreach (product item in listProduct)
            //        {
            //            string a = item.Color.ToString();
            //            string b = sell_cbColor.SelectedValue.ToString();

            //            bool chec = a.Equals(b);

            //            if (chec)
            //            {
            //                listCurent.Add(item);
            //            }

            //        }
            //       sell_dataGrid.DataSource = listCurent;
            //    }
            //
        }
    }
}
