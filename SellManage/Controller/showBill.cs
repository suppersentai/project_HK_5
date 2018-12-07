using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
namespace Controller
{
    public class showBill
    {
        static DataTable table = null;
        static int sttDgvBill = 1;
        public static void showDgvBill(DataGridView sell_dataGrid, DataGridView sell_dgvBill)
        {
            // show thông tin trên datagridbill khi click button Add
            table = (DataTable)sell_dgvBill.DataSource;
            int indexRow = sell_dataGrid.CurrentCell.RowIndex;// lấy chỉ số hàng đk chọn
            DataGridViewRow row = new DataGridViewRow();
            row = sell_dataGrid.Rows[indexRow];

            int ma = (int)row.Cells["idsp"].Value;
            string ten = row.Cells["tensp"].Value.ToString();
            string dongia = row.Cells["giaban"].Value.ToString();
            int tien = 0;
            if (sell_dgvBill.Rows.Count != 0)
            {
                int i;

                bool tontai = false;
                for (i = 0; i < sell_dgvBill.Rows.Count; i++)
                {
                    int a = (int)sell_dgvBill.Rows[i].Cells["idsp"].Value;
                    if (a == ma)
                    {
                        int soluong = Convert.ToInt32(sell_dgvBill.Rows[i].Cells[4].Value.ToString());
                        soluong++;
                        sell_dgvBill.Rows[i].Cells[4].Value = soluong;

                        tien = Convert.ToInt32(sell_dgvBill.Rows[i].Cells[3].Value.ToString());
                        tien *= soluong;
                        sell_dgvBill.Rows[i].Cells[5].Value = tien;
                        tontai = true;
                        break;
                       
                    }


                }
                if (!tontai)
                {
                  
                    sell_dgvBill.Rows.Add(sttDgvBill, ma, ten, dongia, 1, dongia);
                    sttDgvBill++;

                }


            }
            else
            {
                MessageBox.Show("o444k");
                sell_dgvBill.Rows.Add(sttDgvBill, ma, ten, dongia, 1, dongia);
                sttDgvBill++;
                table = (DataTable)sell_dgvBill.DataSource;
            }
        }
        public static bool checkRowExist(DataGridView table, int ma)
        {// kiểm tra giá hàng đang thêm đã tồn tại trong dgvBill chưa
            if (table.Rows.Count != 0)
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    int a = (int)table.Rows[i].Cells[1].Value;
                    if (a == ma)
                        return true;
                }
            return false;
        }
        public static int getTotalPriceInDgvBill(DataGridView sell_dgvBill)
        {// lấy tổng tiền cả hóa đơn
            table = (DataTable)sell_dgvBill.DataSource;
            int tongtien = 0;
            if (sell_dgvBill.Rows.Count != 0)
                for (int i = 0; i < sell_dgvBill.Rows.Count; i++)
                {
                    tongtien += Convert.ToInt32(sell_dgvBill.Rows[i].Cells[5].Value.ToString());

                }
            return tongtien;
        }

    }
    public class getData
    {
        public static int getIdBill()
        {
            String query = "select Max(idhd) from hoadon";
            return DAO.ConnectDAO.getDataIDBill(query) + 1;

        }
    }
}
