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


        bool billStatus = false;
        private fillterDataComBoxPROCESS fill;

        DataTable tableCurent;//List product ddang show tren data grid
        bool check = false;// dùng để tránh chạy sk valuechange khi đổ data vào combox
        DataTable tableProductFull;//List product chua tat ca product from database
        public formMain()
        {
            InitializeComponent();


        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {// event log out
            new LOGIN().Visible = true;
            this.Visible = false;
        }

        private void formMain_FormClosing(object sender, FormClosingEventArgs e)
        {// event Close Form
            DialogResult di = MessageBox.Show("Bạn Chắc Chắc Muốn thoát Không", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (di == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
            else
            {
                Environment.Exit(1);
                // Application.Exit();
            }
        }


        private void formMain_Load(object sender, EventArgs e)
        {//event LoadForm  First

            tableProductFull = Controller.showInforProcesss.getListProductProsess();
            sell_dataGrid.DataSource = tableProductFull;
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
            Button b = new Button();
            btn.HeaderText = "Click";
            btn.Name = "button";
            btn.Text = "Add";
            btn.Width = 80;
            btn.UseColumnTextForButtonValue = true;

            sell_dataGrid.Columns.Add(btn);

            // //đặt kích thước width 
            sell_dataGrid.Columns["idSP"].Width = 60;
            sell_dataGrid.Columns["size"].Width = 60;
            sell_dataGrid.Columns["doituongsudung"].Width = 60;
            sell_dataGrid.Columns["button"].Width = 80;
            // // show infor on 3 combobox
            Controller.showInforProcesss.showTypeOnCombox(sell_cbType);
            Controller.showInforProcesss.showSizeOnCombox(sell_cbSize);
            Controller.showInforProcesss.showColorOnCombox(sell_cbColor);
            //// sell_cbPrice.SelectedIndex = 0;

            tableCurent = (DataTable)sell_dataGrid.DataSource;
            check = true;
            MessageBox.Show(billStatus.ToString());
            if (!billStatus)
            {
                changeReadOnllytextBoxCustomew(!billStatus);
            }
            else
            {
                changeReadOnllytextBoxCustomew(!billStatus);
            }
        }
        #region combobox change value
        private void sell_cbType_SelectedValueChanged(object sender, EventArgs e)
        {// event combobox type
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
        {// event combobox size
            ComboBox com = sender as ComboBox;
            if (check == true)
                if (sell_cbType.SelectedIndex == 0 && sell_cbColor.SelectedIndex == 0)
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
        #endregion
        private void sell_cbColor_SelectedValueChanged(object sender, EventArgs e)
        {// event combobox màu 
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

        public bool checkAllSelecedIsZero()
        {// kiểm tra xem tất cả các value  index có phải  = 0
            if (sell_cbType.SelectedIndex == 0 && sell_cbSize.SelectedIndex == 0 && sell_cbColor.SelectedIndex == 0)
            {
                return true;
            }
            return false;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {// button tất cả: show all product
            sell_cbType.SelectedIndex = 0;
            sell_cbSize.SelectedIndex = 0;
            sell_cbColor.SelectedIndex = 0;
        }
        private void sell_dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {// event datagridview main
            var dgvBtn = (DataGridView)sender;
            if (CONST.checkCreatedBill)
                if (dgvBtn.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
                {//nếu là column button
                    Controller.showBill.showDgvBill(sell_dataGrid, sell_dgvBill);
                    sell_txtTotaPricelBill.Text = Controller.showBill.getTotalPriceInDgvBill(sell_dgvBill).ToString();
                }
                else
                {
                    MessageBox.Show("Bạn Chưa tạo hóa đơn !", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
        }


        private void sell_txtResetBill_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void sell_txtCreateBill_Click(object sender, EventArgs e)
        {
            billStatus = true;
            changeBackColorBillStatus();
            billStatus = true;
            CONST.checkCreatedBill = true;
            //  hiển thị các textbox tên nhân viên ,,id hóaddonw
            int idBill = Controller.getData.getIdBill();

            sell_txtIdHd.Text = idBill.ToString();
            sell_txtNameStaff.Text = CONST.currenAcount.Name;
            DateTime dateOfsell = DateTime.Now;
            Color mau = Color.PeachPuff;
            changeBackColorEnoughInfoCustomer(mau);

        }
        private void sell_dgvBill_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {

        }
        public bool checkInvalidWhenPay()
        {
            if (!sell_txtNameCus.Equals(""))
            {
                if (sell_txtPhoneCus.Text.Length < 1 || sell_txtPhoneCus.Text.Length > 10)
                {
                    return false;
                }
                else
                {

                    if (!sell_txtAddressCus.Equals(""))
                        if (sell_genderCusBoy.Checked == true || sell_genderCusGirl.Checked == true)
                            if (sell_dgvBill.Rows.Count >= 0)
                                return true;

                }
            }
            return false;
        }
        private String getGenderCus()
        {
            if (sell_genderCusBoy.Checked)
                return sell_genderCusBoy.Text;
            else return sell_genderCusGirl.Text;
        }
        private void sell_btnPay_Click(object sender, EventArgs e)
        {
            if (checkInvalidWhenPay())
            {
                if (CONST.customer == null)
                {
                    customer cus = new customer();
                    cus.Name = sell_txtNameCus.Text;
                    cus.Address = sell_txtAddressCus.Text;
                    cus.Phone = sell_txtPhoneCus.Text;
                    cus.Gender = getGenderCus();
                    CONST.customer = cus;

                    Controller.payProcess.insertNewCustomer(cus); //insert to databbase. luc nay chua co ID

                    Controller.payProcess.getCustomerIfExist(cus.Phone);//lay laij khach hang vua insert de lay ca ID
                    MessageBox.Show("TAI KHOAN CHUA TON  TAI");
                }
                if (sell_dgvBill.Rows.Count >= 1)
                {
                    MessageBox.Show("TAI KHOAN dA TON  TAI");
                    MessageBox.Show("Chưattt", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    bill bil = new bill();
                    bil.IdBill = int.Parse(sell_txtIdHd.Text);
                    bil.IdStaff = CONST.currenAcount.Id;
                    bil.IdCustomer = CONST.customer.Id;
                    // bil.DayOfSell = Convert.ToDateTime( sell_txtDayOfSell.Text,'yyyy/MM/dd');
                    bil.DayOfSell = sell_dateOfSell.Value.Date;
                    MessageBox.Show(bil.DayOfSell.ToString());
                    bil.TotalMoney = int.Parse(sell_txtTotaPricelBill.Text.ToString());
                    Controller.payProcess.createBill(sell_dgvBill, bil);
                    MessageBox.Show("Tạo Hóa Đơn Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    reset();
                    billStatus = false;
                    changeBackColorBillStatus();
                    changeReadOnllytextBoxCustomew(!billStatus);
                }
                else
                {
                    MessageBox.Show("Chưa có sản phẩm", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Thông tin không hợp lệ");
            }
            CONST.customer = null;
        }

        private void changeBackColorBillStatus()
        {
            if (billStatus)
            {
                sell_panTopCus.BackColor = Color.LightGreen;
            }
            else
            {
                sell_panTopCus.BackColor = Color.Red;
            }

        }

        private void sell_txtPhoneCus_TextChanged(object sender, EventArgs e)
        {
            TextBox text = sender as TextBox;

            if (text.Text.Length == 10)
            {
                Controller.payProcess.getCustomerIfExist(text.Text);
                if (CONST.customer != null)
                {
                    sell_txtAddressCus.Text = CONST.customer.Address;
                    sell_txtPhoneCus.Text = CONST.customer.Phone;
                    if (CONST.customer.Gender.Equals("Nam"))
                    {
                        sell_genderCusBoy.Checked = true;
                    }
                    else
                    {
                        sell_genderCusGirl.Checked = true;
                    }
                    sell_txtNameCus.Text = CONST.customer.Name;
                    sell_panInfoCustome.BackColor = Color.LightGreen;
                    Color mau = Color.LightGreen;
                    changeBackColorEnoughInfoCustomer(mau);
                    MessageBox.Show("CONST != NULL");
                }
                else
                {
                    MessageBox.Show("CONST = NULL");
                    changeReadOnllytextBoxCustomew(!billStatus);

                }
            }
        }
        private void changeReadOnllytextBoxCustomew(bool value)
        {

            sell_txtAddressCus.ReadOnly = value;

            sell_txtNameCus.ReadOnly = value;
        }
        private void changeBackColorEnoughInfoCustomer(Color mau)
        {
            // if (sell_txtNameCus.Text.Length > 0)
            //        if (sell_txtPhoneCus.Text.Length > 0)
            //            if (sell_txtGenderCus.Text.Length > 0)
            sell_panInfoCustome.BackColor = mau;
        }
        void reset()
        {

            sell_txtTotaPricelBill.Text = "";
            sell_txtNameCus.Text = "";
            sell_txtPhoneCus.Text = "";
            sell_txtAddressCus.Text = "";

            sell_dgvBill.Rows.Clear();
            Color mau = Color.PeachPuff;
            changeBackColorEnoughInfoCustomer(mau);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // button chuyen sang quan li doanh thu

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Main_panMain.Controls.Clear();
            use_KhachHang kh = new use_KhachHang();
            refontsive(kh);
            Main_panMain.Controls.Add(kh);
        }

        private void btn_sell_Click(object sender, EventArgs e)
        {
            Main_panMain.Controls.Clear();
            Main_panMain.Controls.Add(pan_sell);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Main_panMain.Controls.Clear();
            use_NhanVien nv = new use_NhanVien();
            refontsive(nv);
            Main_panMain.Controls.Add(nv);




        }
        public void refontsive(UserControl nv)
        {
            nv.Anchor = AnchorStyles.Left;
            nv.Anchor = AnchorStyles.Right;
            nv.Dock = DockStyle.Fill;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
