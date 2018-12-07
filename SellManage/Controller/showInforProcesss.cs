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
    

}
