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
        private fillterDataComBoxPROCESS fill;
     
      DataTable tableCurent;//List product ddang show tren data grid
        bool check = false;
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
 private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            new LOGIN().Visible = true; this.Visible = false;
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

       
        private void formMain_Load(object sender, EventArgs e)
        {
            UserControl1 u = new UserControl1();
            panel1.Controls.Add(u);
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
            // add colum button

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "click";
            btn.Name ="button";
            btn.Text = "Add";
            btn.Width = 80;
            btn.UseColumnTextForButtonValue = true;
           
            sell_dataGrid.Columns.Add(btn);
       
            // //đặt kích thước width 
            sell_dataGrid.Columns["idSP"].Width = 60;
            sell_dataGrid.Columns["size"].Width = 60;
            sell_dataGrid.Columns["doituongsudung"].Width = 60;
            sell_dataGrid.Columns["button"].Width = 80;
      
            // // HIDE AN column idType in datagrid
            //   sell_dataGrid.Columns["type"].Visible = false;
            // // show infor on 4 combobox


            Controller.showInforProcesss.showTypeOnCombox(sell_cbType);
            Controller.showInforProcesss.showSizeOnCombox(sell_cbSize);
            Controller.showInforProcesss.showColorOnCombox(sell_cbColor);
            //// sell_cbPrice.SelectedIndex = 0;
            //
          
            tableCurent = (DataTable)sell_dataGrid.DataSource;
            // sell_cbType.SelectedIndex = -1;
            check = true;
         }
 
        

      
        private void sell_cbType_SelectedValueChanged(object sender, EventArgs e)
        {
            //ShowIInfo();
            ComboBox com = sender as ComboBox;
            if (check == true)
                if (sell_cbSize.SelectedIndex == 0 && sell_cbColor.SelectedIndex == 0)
                {
                    tableProductFull = Controller.showInforProcesss.getListProductProsess();
                    if (com.SelectedIndex == 0)
                    {
                      
                        sell_dataGrid.DataSource = tableProductFull;

                    }
                    else
                    {
                        tableCurent = Controller.showInforProcesss.filterComboxValues(Convert.ToInt32(com.SelectedValue));
                        sell_dataGrid.DataSource = tableCurent;
                    }
                }
                else
                {
                    ShowIInfo(com);



                }
        }
        private void sell_cbSize_SelectedValueChanged_1(object sender, EventArgs e)
        {
            ComboBox com = sender as ComboBox;
            if (check == true)
                if (sell_cbType.SelectedIndex==0 && sell_cbColor.SelectedIndex == 0 )
                {
                    tableProductFull = Controller.showInforProcesss.getListProductProsess();
                    if (com.SelectedIndex == 0)
                    {
                        tableCurent = tableProductFull;
                        sell_dataGrid.DataSource = tableCurent;
                    }
                    else
                    {
                       
                            DataTable oldDataCurent = tableCurent;
                        DataView daview = oldDataCurent.DefaultView;
                        daview.RowFilter = "size = '" + com.SelectedValue.ToString() + "'";
                        sell_dataGrid.DataSource = tableCurent;
                       
                    }
                }
                else
                {
                    ShowIInfo(com);
                }
            
        }

        private void sell_cbColor_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox com = sender as ComboBox;
            if (check == true)
                if (sell_cbType.SelectedIndex == 0 && sell_cbSize.SelectedIndex == 0)
                {
                    tableProductFull = Controller.showInforProcesss.getListProductProsess();
                    if (com.SelectedIndex == 0)
                    {
                        sell_dataGrid.DataSource = tableProductFull;
                    }
                    else
                    {
                        // DataTable oldDataCurent = (DataTable)sell_dataGrid.DataSource;
                        DataView daview = tableCurent.DefaultView;
                        daview.RowFilter = "mausac = '" + com.SelectedValue.ToString() + "'";
                        sell_dataGrid.DataSource = tableCurent;
                    }
                }
                else
                {
                    ShowIInfo(com);
                }
        }
        public void ShowIInfo(ComboBox com)
        {//set datagrid = tất cả san pham

            string size = null, color = null;
           
            int idType = Convert.ToInt32(sell_cbType.SelectedValue);
            if (sell_cbSize.SelectedIndex != 0)
            {
                size = sell_cbSize.SelectedValue.ToString();

            }
            if (sell_cbColor.SelectedIndex != 0)
            {
                color = sell_cbColor.SelectedValue.ToString();
            }

            fill = new fillterDataComBoxPROCESS();
            DataTable data = fill.fillterTypeCombox(size, idType, color);
            sell_dataGrid.DataSource = data;

        }

        private void sell_cbPrice_SelectedValueChanged(object sender, EventArgs e)
        {
            //ShowIInfo();
        }
      
        public bool checkAllSelecedIsZero()
        {// kiểm tra xem tất cả các value  index có phải  = 0
            if (sell_cbType.SelectedIndex == 0 && sell_cbSize.SelectedIndex == 0 && sell_cbColor.SelectedIndex == 0 )
            {
                return true;
            }
            return false;
        }
        public void filterListAndShow(int idloai)
        {
            //lọc khi thay đổi giá trị của combox
           
          
        }

        private void sell_cbType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            sell_cbType.SelectedIndex = 0;
            sell_cbSize.SelectedIndex = 0;
            sell_cbColor.SelectedIndex = 0;
        }

        private void sell_dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var dgbBtn = (DataGridView)sender;
            if(dgbBtn.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                DataTable tableBill = new DataTable();
                sell_dgvBill.Rows.Add(sell_dataGrid.SelectedRows);

               // MessageBox.Show(sell_dataGrid.SelectedRows.ToString());
            }
            sell_txtID.DataBindings.Clear();
            sell_txtID.DataBindings.Add("text", sell_dataGrid.DataSource, "idsp");
            sell_txtName.DataBindings.Clear();
            sell_txtName.DataBindings.Add("text", sell_dataGrid.DataSource, "tensp");
            sell_txtUnitPrice.DataBindings.Clear();
            sell_txtUnitPrice.DataBindings.Add("text", sell_dataGrid.DataSource, "giaban");
            sell_nudQuantity.DataBindings.Clear();
            sell_nudQuantity.Value = 1;

            int unitPrice =int.Parse(sell_txtUnitPrice.Text.ToString());
            int quantity = int.Parse(sell_nudQuantity.Value.ToString());
            int totalPrice = unitPrice *quantity;
            sell_txtTotalPrice.Text = totalPrice.ToString();
            sell_lbWarrining.Visible = false;
        }

        private void sell_nudQuantity_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown nbr = sender as NumericUpDown;
            if(!String.IsNullOrEmpty(sell_txtID.Text))
            if (nbr.Value<1 || nbr.Value > 10)
            {
                sell_lbWarrining.Visible = true;
            }
            else{ 
                int unitPrice = int.Parse(sell_txtUnitPrice.Text.ToString());
                int quantity = int.Parse(sell_nudQuantity.Value.ToString());
                int totalPrice = unitPrice * quantity;
                sell_txtTotalPrice.Text = totalPrice.ToString();
                sell_lbWarrining.Visible = false;
            }
        }
    }
}
