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
        public static void showTypeOnCombox( ComboBox cbType)
        {
            DataTable datable = new DataTable();
            //show combobox type

            datable = DAO.showInforDAO.takeListType();
            //DataRow row = datable.NewRow();
            //row["tenLoai"] = " Tất cả";
            //row["idLoai"] = 0;
            //datable.Rows.Add(row);
            //DataView daView = datable.DefaultView;
            //daView.Sort="idloai ASC";
            cbType.DataSource = datable;
            cbType.DisplayMember = "tenloai";
            cbType.ValueMember = "tenloai";
        }

        public static void showSizeOnCombox(ComboBox combox)
        {

            DataTable datable = new DataTable();
            //show combobox SIZE

           datable = DAO.showInforDAO.takeListSize();                  
            combox.DataSource = datable;
            combox.DisplayMember = "size";
            combox.ValueMember = "size";
        }
        public static void showColorOnCombox(ComboBox combox)
        {
            DataTable datable = new DataTable();
            //show combobox SIZE

            DataRow row= datable.NewRow();
       

            datable = DAO.showInforDAO.takeListColor();

            combox.DataSource = datable;
            combox.DisplayMember = "mausac";
            combox.ValueMember = "Mausac";

        }

        public static void showOnPriceCombox(ComboBox cbPrice)
        {
            //show combobox price
        }
        public static DataTable filterComboxValues(String type, String size, String color)
        {
            DataTable dataView = new DataTable() ;
            //lọc giá giá trị khi thay đổi selectedIndex
            dataView = DAO.showInforDAO.filterCombox(type, size, color);

            return dataView;
        }
        public static DataTable getListProductProsess ()
        {
            return DAO.showInforDAO.getListProduct();

        }
        #endregion
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
