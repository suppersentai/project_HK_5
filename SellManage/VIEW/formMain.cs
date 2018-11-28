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
      DataTable tableCurent;//List product ddang show tren data grid

        DataTable tableProductFull ;//List product chua tat ca product from database
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

            tableProductFull = Controller.showInforProcesss.getListProductProsess();
        
         
     
            sell_dataGrid.DataSource = tableProductFull;
            //đặt header
            //đặt header       
      
            sell_dataGrid.Columns["idSP"].HeaderText = "Mã";     
            sell_dataGrid.Columns["TenSP"].HeaderText = "Tên sản phẩm";
            sell_dataGrid.Columns["tenloai"].HeaderText = "Loại";
            sell_dataGrid.Columns["size"].HeaderText = "Size";
            sell_dataGrid.Columns["mausac"].HeaderText = "Màu sắc";
            sell_dataGrid.Columns["giaban"].HeaderText = "Giá Bán";
            sell_dataGrid.Columns["doituongsudung"].HeaderText = "Phái";
            sell_dataGrid.Columns["note"].HeaderText = "note";
            //sell_dataGrid.Columns["type"].HeaderText = "Loại";

           // //đặt kích thước width 
            sell_dataGrid.Columns["idSP"].Width = 60;
            sell_dataGrid.Columns["size"].Width = 60;
            sell_dataGrid.Columns["doituongsudung"].Width = 60;

            // // HIDE AN column idType in datagrid
            //   sell_dataGrid.Columns["type"].Visible = false;
            // // show infor on 4 combobox
            MessageBox.Show("Do dai table la");
    
                Controller.showInforProcesss.showTypeOnCombox(sell_cbType);
            Controller.showInforProcesss.showSizeOnCombox(sell_cbSize);
            Controller.showInforProcesss.showColorOnCombox(sell_cbColor);
            //// sell_cbPrice.SelectedIndex = 0;
            //
          
            tableCurent = (DataTable)sell_dataGrid.DataSource;
            MessageBox.Show("Do dai table la : " + tableCurent.Rows.Count.ToString());
        }
 
        public void updateDGridWhenChangeValueComboxSize( )
        {
            tableCurent = new DataTable();
       

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

        private void sell_cbType_SelectedValueChanged(object sender, EventArgs e)
        {
           // ShowIInfo();
        }

        private void sell_cbSize_SelectedValueChanged_1(object sender, EventArgs e)
        {
          //  ShowIInfo();
        }

        private void sell_cbColor_SelectedValueChanged(object sender, EventArgs e)
        {
          //  ShowIInfo();
        }

        private void sell_cbPrice_SelectedValueChanged(object sender, EventArgs e)
        {
            //ShowIInfo();
        }
        public void ShowIInfo ()
        {//set datagrid = tất cả san pham
            if (checkAllSelecedIsZero())
            {
                sell_dataGrid.DataSource = tableProductFull;
                MessageBox.Show("xong");
            }
            else
            {
                filterListAndShow();
            }
        }
        public bool checkAllSelecedIsZero()
        {// kiểm tra xem tất cả các value  index có phải  = 0
            if (sell_cbType.SelectedIndex == 0 && sell_cbSize.SelectedIndex == 0 && sell_cbColor.SelectedIndex == 0 && sell_cbPrice.SelectedIndex == 0)
            {
                return true;
            }
            return false;
        }
        public void filterListAndShow()
        {
            //lọc khi thay đổi giá trị của combox
                String typeValue= null;
                String sizeValue = null;
                String colorValue= null;
            if (sell_cbColor.Items.Count != 0)
            {
                 typeValue = sell_cbSize.SelectedValue.ToString();
                 sizeValue = sell_cbSize.SelectedValue.ToString();
                 colorValue = sell_cbColor.SelectedValue.ToString();
            }
            DataTable table=  Controller.showInforProcesss.filterComboxValues(typeValue, sizeValue, colorValue);
            sell_dataGrid.DataSource = table;
        }
    }
}
