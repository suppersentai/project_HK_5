using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using MODEL;
using System.Data;
using System.Collections;

namespace Controller
{
    public class showInforProcesss
    {
        #region Hiển thị thông tin và chưc năng lọc trong  combobox
        public static void showTypeOnCombox(ComboBox cbType)
        {
            DataTable datable = new DataTable();
            //show combobox type

            datable = DAO.showInforDAO.takeListType();
            DataRow row = datable.NewRow();
            row["tenLoai"] = " Tất cả";
            row["idLoai"] = 0;
            datable.Rows.Add(row);
            DataView daView = datable.DefaultView;
            daView.Sort = "idloai ASC";
            cbType.DataSource = datable;
            cbType.DisplayMember = "tenloai";
            cbType.ValueMember = "idLoai";

        }

        public static void showSizeOnCombox(ComboBox combox)
        {

            DataTable datable = new DataTable();
            //show combobox SIZE
            datable = DAO.showInforDAO.takeListSize();
            DataRow row = datable.NewRow();

            row["size"] = " Tất cả";
            datable.Rows.Add(row);
            DataView daView = datable.DefaultView;
            daView.Sort = "size ASC";

            combox.DataSource = datable;
            combox.DisplayMember = "size";
            combox.ValueMember = "size";
        }
        public static void showColorOnCombox(ComboBox combox)
        {
            DataTable datable = new DataTable();
            //show combobox color
            datable = DAO.showInforDAO.takeListColor();
            DataRow row = datable.NewRow();

            row["mausac"] = " Tất cả";
            datable.Rows.Add(row);
            DataView daView = datable.DefaultView;
            daView.Sort = "mausac ASC";

            combox.DataSource = datable;
            combox.DisplayMember = "mausac";
            combox.ValueMember = "Mausac";

        }

        public static void showOnPriceCombox(ComboBox cbPrice)
        {
            //show combobox price
        }
        public static DataTable filterComboxValues(int idLoai)
        {

            //lọc giá giá trị khi thay đổi selectedIndex
            DataTable dataView = DAO.showInforDAO.filterCombox(idLoai);

            return dataView;
        }


        #endregion
        public static DataTable getListProductProsess()
        {
            return DAO.showInforDAO.getListProduct();

        }
        public void bindigToObject()
        {

        }
    }
    //public class sortListById : IComparer
    //{  so sanh doi tượng bằng giá trị propeties
    //    public int Compare(object a, object b)
    //    {
    //        typeProduct typeProduct = a as typeProduct;
    //        typeProduct typeProduct2 = b as typeProduct;
    //        return typeProduct.Id.CompareTo(typeProduct2.Id);
    //    }

    //}
    public class showBill
    {
        static DataTable table = null;
        static int sttDgvBill = 1;
        public static void showDgvBill(DataGridView sell_dataGrid, DataGridView sell_dgvBill)
        {
           
             table = (DataTable)sell_dgvBill.DataSource;
            int indexRow = sell_dataGrid.CurrentCell.RowIndex;// lấy chỉ số hàng đk chọn
            DataGridViewRow row = new DataGridViewRow();
            detailBill detai = new detailBill();
            row = sell_dataGrid.Rows[indexRow];
            int ma = (int)row.Cells["idsp"].Value;
            string ten = row.Cells["tensp"].Value.ToString();
            string dongia = row.Cells["giaban"].Value.ToString();
            if (sell_dgvBill.Rows.Count != 0)
            {
                if (checkRowExist(sell_dgvBill, ma))
                {

                    int soluong = Convert.ToInt32(sell_dgvBill.Rows[indexRow].Cells[4].Value.ToString());
                    soluong++;
                    sell_dgvBill.Rows[indexRow].Cells[4].Value = soluong;
                   
                    int tien = Convert.ToInt32(sell_dgvBill.Rows[indexRow].Cells[3].Value.ToString()) ;
                    tien *= soluong; MessageBox.Show(soluong.ToString());
                    sell_dgvBill.Rows[indexRow].Cells[5].Value = tien;
                }
                else
                {
                    sell_dgvBill.Rows.Add(sttDgvBill, ma, ten, dongia, 1, dongia);
                    sttDgvBill++;
                }
            }
            else
            {
                sell_dgvBill.Rows.Add(sttDgvBill, ma, ten, dongia, 1, dongia);
                sttDgvBill++;
                table = (DataTable)sell_dgvBill.DataSource;
            }

        }
        public static bool checkRowExist(DataGridView table, int ma)
        {
            if (table.Rows.Count != 0)
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    int a = (int)table.Rows[i].Cells[1].Value ;
                      if(a == ma)
                        return true;
                }

            return false;
        }
       
    }

}
